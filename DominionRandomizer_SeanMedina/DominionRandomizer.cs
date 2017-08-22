//*****************************************************************************************************************************************************
// Program:        Dominion Randomizer
// Files:          DominionRandomizer.cs
//                 Dominion.cs
// Description:    A collection of all Dominion kingdom cards and other objects (events, landmarks, etc).
//                 Collection is searchable via different criteria.
//                 Can come up with a set of 10 random kingdom cards to use in a game
// Version:        1.1
// Author:         Sean Medina 
// Date created:   2017.July.21?
// Last modified:  2017.Aug.18
//*****************************************************************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows;

namespace DominionRandomizer_SeanMedina
{
    public enum DominionCardFilterOption
    {
        None = 0, Set, Type, Cost, Potion
    }

    public partial class DominionRandomizer : Form
    {
        private List<Dominion> _cardList = new List<Dominion>();            // Entire collection of dominion cards.
        private Random _rng = new Random();

        public DominionRandomizer()
        {
            InitializeComponent();

            // Link all filter type radio buttons to the same event handler.
            foreach (RadioButton rb in UI_GroupBox_Filter.Controls)
                rb.Click += UI_RadioButton_FilterType_Click;

            // Populate the filter combobox based on the initially selected radio button.
            PopulateFilterDDL();
        }

        private void DominionRandomizer_Load(object sender, EventArgs e)
        {
            // For creation of binary file from .csv file.
            //ParseCSVFileToCardList();
            //SerializeCardList();

            // Read the prepared binary file to obtain a list of dominion cards.
            _cardList = DeserializeCardList();

            // At startup, show all cards in alphabetical order.
            UpdateCardList(DominionCardFilterOption.None);
        }

        #region Event Handlers

        private void UI_RadioButton_FilterType_Click(object sender, EventArgs e)
        {
            // Populate the combobox with appropriate values, based on the selected radio button.
            PopulateFilterDDL();
        }

        private void UI_Button_SearchByFilter_Click(object sender, EventArgs e)
        {
            // Based on the selected filter radio button, filter the card list.
            if (UI_RadioButton_FilterType_Cost.Checked)
                UpdateCardList(DominionCardFilterOption.Cost);

            else if (UI_RadioButton_FilterType_Potion.Checked)
                UpdateCardList(DominionCardFilterOption.Potion);

            else if (UI_RadioButton_FilterType_Set.Checked)
                UpdateCardList(DominionCardFilterOption.Set);

            else if (UI_RadioButton_FilterType_Type.Checked)
                UpdateCardList(DominionCardFilterOption.Type);
        }

        private void UI_Button_FullList_Click(object sender, EventArgs e)
        {
            UpdateCardList(DominionCardFilterOption.None);
        }

        private void UI_Button_SearchByText_Click(object sender, EventArgs e)
        {
            UpdateCardList(UI_TextBox_SearchTextFilter.Text);
        }

        private void UI_Button_Randomize_Click(object sender, EventArgs e)
        {
            UpdateCardList();
        }

        #endregion

        private void PopulateFilterDDL()
        {
            // Clear existing DDL items.
            UI_ComboBox_FilterValue.Items.Clear();

            // Based on the checked radio button, populate the combo box with the appropriate filter options.
            if (UI_RadioButton_FilterType_Cost.Checked)
                PopulateFilterDDLWithCosts();

            else if (UI_RadioButton_FilterType_Potion.Checked)
            {
                // Does the card cost a potion? Only two options.
                UI_ComboBox_FilterValue.Items.Add(true);
                UI_ComboBox_FilterValue.Items.Add(false);
            }

            else if (UI_RadioButton_FilterType_Set.Checked)
                PopulateFilterDDLWithSets();

            else if (UI_RadioButton_FilterType_Type.Checked)
                PopulateFilterDDLWithTypes();

            // Select the first item in the DDL.
            UI_ComboBox_FilterValue.SelectedIndex = 0;
        }

        private void PopulateFilterDDLWithCosts()
        {
            List<int> coinCosts = new List<int>();

            // Get all potential coin costs for the dominion cards.
            // Go through all cards and find unique coin costs.
            foreach (Dominion card in _cardList)
                if (!coinCosts.Contains(card.CoinCost))
                    coinCosts.Add(card.CoinCost);

            // Populate the combo box with the potential coin costs.
            foreach (int cost in coinCosts.OrderBy(c => c))
                UI_ComboBox_FilterValue.Items.Add(cost);
        }

        private void PopulateFilterDDLWithSets()
        {
            // Use the enum to populate the DDL. Order alphabetically.
            foreach (string set in Enum.GetNames(typeof(DominionSet)).OrderBy(s => s))
                UI_ComboBox_FilterValue.Items.Add(set);
        }

        private void PopulateFilterDDLWithTypes()
        {
            // Use the enum to populate the DDL. Order alphabetically.
            foreach (string type in Enum.GetNames(typeof(DominionCardType)).OrderBy(s => s))
                UI_ComboBox_FilterValue.Items.Add(type);
        }

        // Randomizer!
        // Using the selected sets, obtain a random set of 10 dominion cards.
        // TODO: Events? Event checkbox with NUD (suggested 2)
        private void UpdateCardList()
        {
            BindingSource bs = new BindingSource();
            UI_DGV_CardList.DataSource = bs;

            List<DominionSet> selectedSets = new List<DominionSet>();

            // For each selected checkbox, add to the pool of possible sets from which to pull cards.
            if (UI_CheckBox_RandomizerSet_Adventures.Checked)   selectedSets.Add(DominionSet.Adventures);
            if (UI_CheckBox_RandomizerSet_Alchemy.Checked)      selectedSets.Add(DominionSet.Alchemy);
            if (UI_CheckBox_RandomizerSet_Base.Checked)         selectedSets.Add(DominionSet.Base);
            if (UI_CheckBox_RandomizerSet_Cornucopia.Checked)   selectedSets.Add(DominionSet.Cornucopia);
            if (UI_CheckBox_RandomizerSet_DarkAges.Checked)     selectedSets.Add(DominionSet.DarkAges);
            if (UI_CheckBox_RandomizerSet_Guilds.Checked)       selectedSets.Add(DominionSet.Guilds);
            if (UI_CheckBox_RandomizerSet_Hinterlands.Checked)  selectedSets.Add(DominionSet.Hinterlands);
            if (UI_CheckBox_RandomizerSet_Intrigue.Checked)     selectedSets.Add(DominionSet.Intrigue);
            if (UI_CheckBox_RandomizerSet_Promo.Checked)        selectedSets.Add(DominionSet.Promo);
            if (UI_CheckBox_RandomizerSet_Prosperity.Checked)   selectedSets.Add(DominionSet.Prosperity);
            if (UI_CheckBox_RandomizerSet_Seaside.Checked)      selectedSets.Add(DominionSet.Seaside);

            // At least one set must be selected.
            if (selectedSets.Count > 0)
            {
                // Obtain card pool using selected sets.
                List<Dominion> possibleCards = _cardList.FindAll(c => selectedSets.Contains(c.Set));

                // Need at least 10 cards to form a kingdom.
                if (possibleCards.Count >= 10)
                {
                    // Generate indices of the 10 random cards to select from the pool.
                    HashSet<int> indices = new HashSet<int>();

                    while (indices.Count < 10)
                        // HashSet Add() returns false and will not add element if it is already present.
                        indices.Add(_rng.Next(possibleCards.Count));

                    // Using the generated indices, get the 10 random cards from the pool.
                    List<Dominion> randomizerCards = new List<Dominion>();

                    foreach (int i in indices)
                        randomizerCards.Add(possibleCards[i]);

                    bs.DataSource = randomizerCards;

                    FormatCardList();
                }
            }
        }

        private void UpdateCardList(string searchText)
        {
            // Search cards for the specified text.
            Regex regex = new Regex(searchText, RegexOptions.IgnoreCase);

            BindingSource bs = new BindingSource();
            UI_DGV_CardList.DataSource = bs;

            bs.DataSource = from card
                            in _cardList
                            where regex.IsMatch(card.Name + card.Text)      // Search the card name and text for the specified text.
                            orderby card.Name
                            select card;

            FormatCardList();
        }

        private void UpdateCardList(DominionCardFilterOption filter)
        {
            BindingSource bs = new BindingSource();
            UI_DGV_CardList.DataSource = bs;

            // Show all cards in alphabetical order by name.
            if (filter == DominionCardFilterOption.None)
            {
                bs.DataSource = from card
                                in _cardList
                                orderby card.Name
                                select card;
            }

            // Show cards that belong to the selected set in the combobox.
            else if (filter == DominionCardFilterOption.Set)
            {
                DominionSet selectedSet;

                // Try to get the selected set from the combobox.
                if (Enum.TryParse(UI_ComboBox_FilterValue.SelectedItem.ToString(), out selectedSet))
                {

                    bs.DataSource = from card
                                    in _cardList
                                    where card.Set == selectedSet
                                    select card;
                }

                else
                    Console.WriteLine("Error parsing selected card set from combobox");
            }

            // Show cards whose type includes the selected type in the combobox.
            else if (filter == DominionCardFilterOption.Type)
            {
                DominionCardType selectedType;

                // Try to get the selected type from the combobox.
                if (Enum.TryParse(UI_ComboBox_FilterValue.SelectedItem.ToString(), out selectedType))
                {
                    // Select cards whose type contains the combobox value.
                    bs.DataSource = from card
                                    in _cardList
                                    where card.Types.Contains(selectedType)
                                    select card;
                }

                else
                    Console.WriteLine("Error parsing selected card tye from combobox");
            }

            // Show cards whose coin cost matches the selected cost in the combobox.
            else if (filter == DominionCardFilterOption.Cost)
            {
                bs.DataSource = from card
                                in _cardList
                                where card.CoinCost == int.Parse(UI_ComboBox_FilterValue.SelectedItem.ToString())
                                select card;
            }

            // Show cards that do / do not cost a potion, based on the combobox value.
            else if (filter == DominionCardFilterOption.Potion)
            {
                // Combobox contains true or false.
                bs.DataSource = from card
                                in _cardList
                                where card.CostsAPotion == bool.Parse(UI_ComboBox_FilterValue.SelectedItem.ToString())
                                select card;
            }

            FormatCardList();
        }

        private void FormatCardList()
        {
            // Any cards ?
            if (UI_DGV_CardList.ColumnCount > 0)
            {
                // Column formatting resets when repopulating dgv.
                // Make all columns, except the last, fit all cell contents.
                for (int i = 0; i < UI_DGV_CardList.ColumnCount - 2; ++i)
                    UI_DGV_CardList.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Make the last column, which is card text, fill the rest of the dgv.
                UI_DGV_CardList.Columns[UI_DGV_CardList.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        #region File IO

        public void SerializeCardList()
        {
            // Create a binary file from the list of dominion cards.
            FileStream fs = null;

            try
            {
                fs = new FileStream("DominionCardList.bin", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, _cardList);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error serializing card list : " + ex.Message);
            }

            finally
            {
                fs?.Close();
            }
        }

        public List<Dominion> DeserializeCardList()
        {
            List<Dominion> cardList = null;
            
            // Read the prepared binary file to obtain a list of dominion cards.
            //if (File.Exists("DominionCardList.bin"))
            {
                FileStream fs = null;

                try
                {
                    //fs = new FileStream("DominionCardList.bin", FileMode.Open, FileAccess.Read);

                    // Dominion card list binary file is a project resource. Can access it as a byte array, create a stream, and deserialize it.
                    BinaryFormatter bf = new BinaryFormatter();
                    cardList = (List<Dominion>)bf.Deserialize(new MemoryStream(Properties.Resources.DominionCardList));
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error deserializing card list : " + ex.Message);
                }

                finally
                {
                    fs?.Close();
                }
            }

            return cardList;
        }

        public void ParseCSVFileToCardList()
        {
            // Create object used to process .csv file.
            TextFieldParser parser = new TextFieldParser(@"../../../DominionCardList.csv");

            // Ensure fields enclosed by double-quotes are treated verbatim.
            // Commas may appear within card text, which will mess up a straight .Split() on commas.
            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");

            // Skip the first line, which contains column headers / titles.
            parser.ReadLine();

            // Read the entire file.
            while (!parser.EndOfData)
            {
                // Each line contains data for a single card.
                // Read a line and break it into separate pieces of info.
                string[] cardInfo = parser.ReadFields();

                // Column number - Description
                // 0 - Name
                // 1 - Set number
                // 2 - Set
                // 3 - Type
                // 4 - Cost (ex. $3, $2P)
                // 5 - QRankCat (ex. Cost 3, Potion)
                // 6 - 2012QRank1
                // 7 - 2012QRank2
                // 8 - 2013QRank
                // 9 - 2014QRank
                // 10 - Text

                // Card text contains extra delimiters to emulate the actual text on the physical cards.
                // Replace delimiters to get "pure" text.
                cardInfo[10] = cardInfo[10].Replace("\\n", ". ").Replace("\\d", ". ");

                List<DominionCardType> types = new List<DominionCardType>();

                // Individual card types separated by a hyphen.
                string[] cardTypes = cardInfo[3].Split('-');

                foreach (string type in cardTypes)
                {
                    try
                    {
                        // Attempt to parse a card type from the string and add it to the list of types that define the card.
                        types.Add((DominionCardType)Enum.Parse(typeof(DominionCardType), type, ignoreCase: true));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error parsing card type for [" + cardInfo[0] + "] : " + ex.Message);
                    }
                }

                DominionSet set = DominionSet.Base;

                try
                {
                    // Using slightly modified terminology from source data.
                    cardInfo[2] = cardInfo[2].Replace("Base Cards", "Supply");
                    cardInfo[2] = cardInfo[2].Replace("Dark Ages", "DarkAges");
                    cardInfo[2] = cardInfo[2].Replace("Dominion", "Base");

                    set = (DominionSet)Enum.Parse(typeof(DominionSet), cardInfo[2], ignoreCase: true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing card set for [" + cardInfo[0] + "] : " + ex.Message);
                }

                // Extract the coin cost from one of the fields.
                int coinCost = 0;
                int.TryParse(new string(cardInfo[4].Where(c => char.IsDigit(c)).ToArray()), out coinCost);

                // Determine if the card costs a potion to buy.
                bool costsAPotion = cardInfo[5].Equals("Potion", StringComparison.CurrentCultureIgnoreCase);

                _cardList.Add(new Dominion(cardInfo[0],             // Card name
                                               cardInfo[10],            // Processed card text
                                               set,                     // Processed card set
                                               types,                   // Processed card types
                                               coinCost,                // Extracted coin cost
                                               costsAPotion));          // Does it cost a potion to buy?
            }
        }

        #endregion
    }
}
