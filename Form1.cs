using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TabelaASCII();
        }

        public void ASCII_Automatico()
        {
            //Instanciando a classe ASCII
            ASCII ascii = new ASCII();

            //Convertendo a string ASCII para hexadecimal
            rtxHexadecimal.Text = ascii.StringToHexadecimal(rtbASCII.Text, txtDelimitador.Text);


            //Convertendo a string ASCII para Binario
            rtxBinario.Text = ascii.StringToBinary(rtbASCII.Text, txtDelimitador.Text);

            //Convertendo a string ASCII para Decimal
            rxtDecimal.Text = ascii.StringToDecimal(rtbASCII.Text, txtDelimitador.Text);

            //Alterar as labels de contagem
            ContagemLabels();
        }

        private void rtbASCII_TextChanged(object sender, EventArgs e)
        {
            ASCII_Automatico();
        }


        private void txtDelimitador_TextChanged(object sender, EventArgs e)
        {
            ASCII_Automatico();
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {//Copiar automaticamente para a area de transferencia
            Clipboard.SetText(rtxBinario.Text);
        }

        private void btnCopy3_Click(object sender, EventArgs e)
        {//Copiar automaticamente para a area de transferencia
            Clipboard.SetText(rxtDecimal.Text);
        }

        private void lblContagemASCII_Click(object sender, EventArgs e)
        {
            ASCII_Automatico();
        }

        private void btnCopy1_Click_1(object sender, EventArgs e)
        {
            //Copiar automaticamente para a area de transferencia
            Clipboard.SetText(rtxHexadecimal.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar todos os campos
            rtbASCII.Clear();
            rtxBinario.Clear();
            rtxHexadecimal.Clear();
            rxtDecimal.Clear();
        }

        private void ContagemLabels()
        {
            //Alterar as labels de contagem
            lblContagemASCII.Text = "(" + rtbASCII.Text.Length + " digitos)";

            if (txtDelimitador.Text.Equals(""))
            {
                lblContagemBinario.Text = "(" + rtxBinario.Text.Length + " digitos)";
                lblContagemHexadecimal.Text = "(" + rtxHexadecimal.Text.Length + " digitos)";
                lblContagemDecimal.Text = "(" + rxtDecimal.Text.Length + " digitos)";
            }
            else
            {
                //remover todo o delimitador da string e contar os digitos
                lblContagemBinario.Text = "(" + rtxBinario.Text.Replace(txtDelimitador.Text, "").Length + " digitos)";
                lblContagemHexadecimal.Text = "(" + rtxHexadecimal.Text.Replace(txtDelimitador.Text, "").Length + " digitos)";
                lblContagemDecimal.Text = "(" + rxtDecimal.Text.Replace(txtDelimitador.Text, "").Length + " digitos)";
            }
        }

        private void TabelaASCII()
        {
            DataSet data = new DataSet("ASCII");

            if (rdbControlChar.Checked)
            {
                DataTable table = new DataTable("0-31");
                table.Columns.Add("Symbol", typeof(string));
                table.Columns.Add("Description", typeof(string));
                table.Columns.Add("DEC", typeof(string));
                table.Columns.Add("OCT", typeof(string));
                table.Columns.Add("HEX", typeof(string));
                table.Columns.Add("BIN", typeof(string));
                table.Columns.Add("HTML Name", typeof(string));
                table.Columns.Add("HTML Number", typeof(string));

                table.Rows.Add("NUL", "Null character", "0", "0", "0", "0", "", "&#00;");
                table.Rows.Add("SOH", "Start of Heading", "1", "1", "1", "1", "", "&#01;");
                table.Rows.Add("STX", "Start of Text", "2", "2", "2", "10", "", "&#02;");
                table.Rows.Add("ETX", "End of Text", "3", "3", "3", "11", "", "&#03;");
                table.Rows.Add("EOT", "End of Transmission", "4", "4", "4", "100", "", "&#04;");
                table.Rows.Add("ENQ", "Enquiry", "5", "5", "5", "101", "", "&#05;");
                table.Rows.Add("ACK", "Acknowledge", "6", "6", "6", "110", "", "&#06;");
                table.Rows.Add("BEL", "Bell, Alert", "7", "7", "7", "111", "", "&#07;");
                table.Rows.Add("BS", "Backspace", "8", "10", "8", "1000", "", "&#08;");
                table.Rows.Add("HT", "Horizontal Tab", "9", "11", "9", "1001", "", "&#09;");
                table.Rows.Add("LF", "Line Feed", "10", "12", "0A", "1010", "", "&#10;");
                table.Rows.Add("VT", "Vertical Tabulation", "11", "13", "0B", "1011", "", "&#11;");
                table.Rows.Add("FF", "Form Feed", "12", "14", "0C", "1100", "", "&#12;");
                table.Rows.Add("CR", "Carriage Return", "13", "15", "0D", "1101", "", "&#13;");
                table.Rows.Add("SO", "Shift Out", "14", "16", "0E", "1110", "", "&#14;");
                table.Rows.Add("SI", "Shift In", "15", "17", "0F", "1111", "", "&#15;");
                table.Rows.Add("DLE", "Data Link Escape", "16", "20", "10", "10000", "", "&#16;");
                table.Rows.Add("DC1", "Device Control One (XON)", "17", "21", "11", "10001", "", "&#17;");
                table.Rows.Add("DC2", "Device Control Two", "18", "22", "12", "10010", "", "&#18;");
                table.Rows.Add("DC3", "Device Control Three (XOFF)", "19", "23", "13", "10011", "", "&#19;");
                table.Rows.Add("DC4", "Device Control Four", "20", "24", "14", "10100", "", "&#20;");
                table.Rows.Add("NAK", "Negative Acknowledge", "21", "25", "15", "10101", "", "&#21;");
                table.Rows.Add("SYN", "Synchronous Idle", "22", "26", "16", "10110", "", "&#22;");
                table.Rows.Add("ETB", "End of Transmission Block", "23", "27", "17", "10111", "", "&#23;");
                table.Rows.Add("CAN", "Cancel", "24", "30", "18", "11000", "", "&#24;");
                table.Rows.Add("EM", "End of medium", "25", "31", "19", "11001", "", "&#25;");
                table.Rows.Add("SUB", "Substitute", "26", "32", "1A", "11010", "", "&#26;");
                table.Rows.Add("ESC", "Escape", "27", "33", "1B", "11011", "", "&#27;");
                table.Rows.Add("FS", "File Separator", "28", "34", "1C", "11100", "", "&#28;");
                table.Rows.Add("GS", "Group Separator", "29", "35", "1D", "11101", "", "&#29;");
                table.Rows.Add("RS", "Record Separator", "30", "36", "1E", "11110", "", "&#30;");
                table.Rows.Add("US", "Unit Separator", "31", "37", "1F", "11111", "", "&#31;");

                data.Tables.Add(table);
                dgvASCII.DataSource = data.Tables[0];
            }

            if (rdbPrintChar.Checked)
            {
                DataTable secondTable = new DataTable("32-127");
                secondTable.Columns.Add("Symbol", typeof(string));
                secondTable.Columns.Add("Description", typeof(string));
                secondTable.Columns.Add("DEC", typeof(string));
                secondTable.Columns.Add("OCT", typeof(string));
                secondTable.Columns.Add("HEX", typeof(string));
                secondTable.Columns.Add("BIN", typeof(string));
                secondTable.Columns.Add("HTML Name", typeof(string));
                secondTable.Columns.Add("HTML Number", typeof(string));

                secondTable.Rows.Add("SP", "Space", "32", "40", "20", "100000", "", "&#32;");
                secondTable.Rows.Add("!", "Exclamation mark", "33", "41", "21", "100001", "&excl;", "&#33;");
                secondTable.Rows.Add("\"", "Double quotes (or speech marks)", "34", "42", "22", "100010", "&quot;", "&#34;");
                secondTable.Rows.Add("#", "Number sign", "35", "43", "23", "100011", "&num;", "&#35;");
                secondTable.Rows.Add("$", "Dollar", "36", "44", "24", "100100", "&dollar;", "&#36;");
                secondTable.Rows.Add("%", "Per cent sign", "37", "45", "25", "100101", "&percnt;", "&#37;");
                secondTable.Rows.Add("&", "Ampersand", "38", "46", "26", "100110", "&amp;", "&#38;");
                secondTable.Rows.Add("'", "Single quote", "39", "47", "27", "100111", "&apos;", "&#39;");
                secondTable.Rows.Add("(", "Open parenthesis (or open bracket)", "40", "50", "28", "101000", "&lparen;", "&#40;");
                secondTable.Rows.Add(")", "Close parenthesis (or close bracket)", "41", "51", "29", "101001", "&rparen;", "&#41;");
                secondTable.Rows.Add("*", "Asterisk", "42", "52", "2A", "101010", "&ast;", "&#42;");
                secondTable.Rows.Add("+", "Plus", "43", "53", "2B", "101011", "&plus;", "&#43;");
                secondTable.Rows.Add(",", "Comma", "44", "54", "2C", "101100", "&comma;", "&#44;");
                secondTable.Rows.Add("-", "Hyphen-minus", "45", "55", "2D", "101101", "", "&#45;");
                secondTable.Rows.Add(".", "Period, dot or full stop", "46", "56", "2E", "101110", "&period;", "&#46;");
                secondTable.Rows.Add("/", "Slash or divide", "47", "57", "2F", "101111", "&sol;", "&#47;");
                secondTable.Rows.Add("0", "Zero", "48", "60", "30", "110000", "", "&#48;");
                secondTable.Rows.Add("1", "One", "49", "61", "31", "110001", "", "&#49;");
                secondTable.Rows.Add("2", "Two", "50", "62", "32", "110010", "", "&#50;");
                secondTable.Rows.Add("3", "Three", "51", "63", "33", "110011", "", "&#51;");
                secondTable.Rows.Add("4", "Four", "52", "64", "34", "110100", "", "&#52;");
                secondTable.Rows.Add("5", "Five", "53", "65", "35", "110101", "", "&#53;");
                secondTable.Rows.Add("6", "Six", "54", "66", "36", "110110", "", "&#54;");
                secondTable.Rows.Add("7", "Seven", "55", "67", "37", "110111", "", "&#55;");
                secondTable.Rows.Add("8", "Eight", "56", "70", "38", "111000", "", "&#56;");
                secondTable.Rows.Add("9", "Nine", "57", "71", "39", "111001", "", "&#57;");
                secondTable.Rows.Add(":", "Colon", "58", "72", "3A", "111010", "&colon;", "&#58;");
                secondTable.Rows.Add(";", "Semicolon", "59", "73", "3B", "111011", "&semi;", "&#59;");
                secondTable.Rows.Add("<", "Less than (or open angled bracket)", "60", "74", "3C", "111100", "&lt;", "&#60;");
                secondTable.Rows.Add("=", "Equals", "61", "75", "3D", "111101", "&equals;", "&#61;");
                secondTable.Rows.Add(">", "Greater than (or close angled bracket)", "62", "76", "3E", "111110", "&gt;", "&#62;");
                secondTable.Rows.Add("?", "Question mark", "63", "77", "3F", "111111", "&quest;", "&#63;");
                secondTable.Rows.Add("@", "At sign", "64", "100", "40", "1000000", "&commat;", "&#64;");
                secondTable.Rows.Add("A", "Uppercase A", "65", "101", "41", "1000001", "", "&#65;");
                secondTable.Rows.Add("B", "Uppercase B", "66", "102", "42", "1000010", "", "&#66;");
                secondTable.Rows.Add("C", "Uppercase C", "67", "103", "43", "1000011", "", "&#67;");
                secondTable.Rows.Add("D", "Uppercase D", "68", "104", "44", "1000100", "", "&#68;");
                secondTable.Rows.Add("E", "Uppercase E", "69", "105", "45", "1000101", "", "&#69;");
                secondTable.Rows.Add("F", "Uppercase F", "70", "106", "46", "1000110", "", "&#70;");
                secondTable.Rows.Add("G", "Uppercase G", "71", "107", "47", "1000111", "", "&#71;");
                secondTable.Rows.Add("H", "Uppercase H", "72", "110", "48", "1001000", "", "&#72;");
                secondTable.Rows.Add("I", "Uppercase I", "73", "111", "49", "1001001", "", "&#73;");
                secondTable.Rows.Add("J", "Uppercase J", "74", "112", "4A", "1001010", "", "&#74;");
                secondTable.Rows.Add("K", "Uppercase K", "75", "113", "4B", "1001011", "", "&#75;");
                secondTable.Rows.Add("L", "Uppercase L", "76", "114", "4C", "1001100", "", "&#76;");
                secondTable.Rows.Add("M", "Uppercase M", "77", "115", "4D", "1001101", "", "&#77;");
                secondTable.Rows.Add("N", "Uppercase N", "78", "116", "4E", "1001110", "", "&#78;");
                secondTable.Rows.Add("O", "Uppercase O", "79", "117", "4F", "1001111", "", "&#79;");
                secondTable.Rows.Add("P", "Uppercase P", "80", "120", "50", "1010000", "", "&#80;");
                secondTable.Rows.Add("Q", "Uppercase Q", "81", "121", "51", "1010001", "", "&#81;");
                secondTable.Rows.Add("R", "Uppercase R", "82", "122", "52", "1010010", "", "&#82;");
                secondTable.Rows.Add("S", "Uppercase S", "83", "123", "53", "1010011", "", "&#83;");
                secondTable.Rows.Add("T", "Uppercase T", "84", "124", "54", "1010100", "", "&#84;");
                secondTable.Rows.Add("U", "Uppercase U", "85", "125", "55", "1010101", "", "&#85;");
                secondTable.Rows.Add("V", "Uppercase V", "86", "126", "56", "1010110", "", "&#86;");
                secondTable.Rows.Add("W", "Uppercase W", "87", "127", "57", "1010111", "", "&#87;");
                secondTable.Rows.Add("X", "Uppercase X", "88", "130", "58", "1011000", "", "&#88;");
                secondTable.Rows.Add("Y", "Uppercase Y", "89", "131", "59", "1011001", "", "&#89;");
                secondTable.Rows.Add("Z", "Uppercase Z", "90", "132", "5A", "1011010", "", "&#90;");
                secondTable.Rows.Add("[", "Opening bracket", "91", "133", "5B", "1011011", "&lsqb;", "&#91;");
                secondTable.Rows.Add("\\", "Backslash", "92", "134", "5C", "1011100", "&bsol;", "&#92;");
                secondTable.Rows.Add("]", "Closing bracket", "93", "135", "5D", "1011101", "&rsqb;", "&#93;");
                secondTable.Rows.Add("^", "Caret - circumflex", "94", "136", "5E", "1011110", "&Hat;", "&#94;");
                secondTable.Rows.Add("_", "Underscore", "95", "137", "5F", "1011111", "&lowbar;", "&#95;");
                secondTable.Rows.Add("`", "Grave accent", "96", "140", "60", "1100000", "&grave;", "&#96;");
                secondTable.Rows.Add("a", "Lowercase a", "97", "141", "61", "1100001", "", "&#97;");
                secondTable.Rows.Add("b", "Lowercase b", "98", "142", "62", "1100010", "", "&#98;");
                secondTable.Rows.Add("c", "Lowercase c", "99", "143", "63", "1100011", "", "&#99;");
                secondTable.Rows.Add("d", "Lowercase d", "100", "144", "64", "1100100", "", "&#100;");
                secondTable.Rows.Add("e", "Lowercase e", "101", "145", "65", "1100101", "", "&#101;");
                secondTable.Rows.Add("f", "Lowercase f", "102", "146", "66", "1100110", "", "&#102;");
                secondTable.Rows.Add("g", "Lowercase g", "103", "147", "67", "1100111", "", "&#103;");
                secondTable.Rows.Add("h", "Lowercase h", "104", "150", "68", "1101000", "", "&#104;");
                secondTable.Rows.Add("i", "Lowercase i", "105", "151", "69", "1101001", "", "&#105;");
                secondTable.Rows.Add("j", "Lowercase j", "106", "152", "6A", "1101010", "", "&#106;");
                secondTable.Rows.Add("k", "Lowercase k", "107", "153", "6B", "1101011", "", "&#107;");
                secondTable.Rows.Add("l", "Lowercase l", "108", "154", "6C", "1101100", "", "&#108;");
                secondTable.Rows.Add("m", "Lowercase m", "109", "155", "6D", "1101101", "", "&#109;");
                secondTable.Rows.Add("n", "Lowercase n", "110", "156", "6E", "1101110", "", "&#110;");
                secondTable.Rows.Add("o", "Lowercase o", "111", "157", "6F", "1101111", "", "&#111;");
                secondTable.Rows.Add("p", "Lowercase p", "112", "160", "70", "1110000", "", "&#112;");
                secondTable.Rows.Add("q", "Lowercase q", "113", "161", "71", "1110001", "", "&#113;");
                secondTable.Rows.Add("r", "Lowercase r", "114", "162", "72", "1110010", "", "&#114;");
                secondTable.Rows.Add("s", "Lowercase s", "115", "163", "73", "1110011", "", "&#115;");
                secondTable.Rows.Add("t", "Lowercase t", "116", "164", "74", "1110100", "", "&#116;");
                secondTable.Rows.Add("u", "Lowercase u", "117", "165", "75", "1110101", "", "&#117;");
                secondTable.Rows.Add("v", "Lowercase v", "118", "166", "76", "1110110", "", "&#118;");
                secondTable.Rows.Add("w", "Lowercase w", "119", "167", "77", "1110111", "", "&#119;");
                secondTable.Rows.Add("x", "Lowercase x", "120", "170", "78", "1111000", "", "&#120;");
                secondTable.Rows.Add("y", "Lowercase y", "121", "171", "79", "1111001", "", "&#121;");
                secondTable.Rows.Add("z", "Lowercase z", "122", "172", "7A", "1111010", "", "&#122;");
                secondTable.Rows.Add("{", "Opening brace", "123", "173", "7B", "1111011", "&lcub;", "&#123;");
                secondTable.Rows.Add("|", "Vertical bar", "124", "174", "7C", "1111100", "&verbar;", "&#124;");
                secondTable.Rows.Add("}", "Closing brace", "125", "175", "7D", "1111101", "&rcub;", "&#125;");
                secondTable.Rows.Add("~", "Equivalency sign - tilde", "126", "176", "7E", "1111110", "&tilde;", "&#126;");
                secondTable.Rows.Add("DEL", "Delete", "127", "177", "7F", "1111111", "", "&#127;");

                data.Tables.Add(secondTable);
                dgvASCII.DataSource = data.Tables[0];
            }

            if (rdbExtendedChar.Checked)
            {
                DataTable thirdTable = new DataTable("128-255");
                thirdTable.Columns.Add("Symbol", typeof(string));
                thirdTable.Columns.Add("Description", typeof(string));
                thirdTable.Columns.Add("DEC", typeof(string));
                thirdTable.Columns.Add("OCT", typeof(string));
                thirdTable.Columns.Add("HEX", typeof(string));
                thirdTable.Columns.Add("BIN", typeof(string));
                thirdTable.Columns.Add("HTML Name", typeof(string));
                thirdTable.Columns.Add("HTML Number", typeof(string));

                thirdTable.Rows.Add("€", "Euro sign", "128", "200", "80", "10000000", "&euro;", "&#8364;");
                thirdTable.Rows.Add("", "Unused", "129", "201", "81", "10000001", "", "");
                thirdTable.Rows.Add("‚", "Single low-9 quotation mark", "130", "202", "82", "10000010", "&sbquo;", "&#130;");
                thirdTable.Rows.Add("ƒ", "Latin small letter f with hook", "131", "203", "83", "10000011", "&fnof;", "&#131;");
                thirdTable.Rows.Add("„", "Double low-9 quotation mark", "132", "204", "84", "10000100", "&bdquo;", "&#132;");
                thirdTable.Rows.Add("…", "Horizontal ellipsis", "133", "205", "85", "10000101", "&hellip;", "&#133;");
                thirdTable.Rows.Add("†", "Dagger", "134", "206", "86", "10000110", "&dagger;", "&#134;");
                thirdTable.Rows.Add("‡", "Double dagger", "135", "207", "87", "10000111", "&Dagger;", "&#135;");
                thirdTable.Rows.Add("ˆ", "Modifier letter circumflex accent", "136", "210", "88", "10001000", "&circ;", "&#136;");
                thirdTable.Rows.Add("‰", "Per mille sign", "137", "211", "89", "10001001", "&permil;", "&#137;");
                thirdTable.Rows.Add("Š", "Latin capital letter S with caron", "138", "212", "8A", "10001010", "&Scaron;", "&#138;");
                thirdTable.Rows.Add("‹", "Single left-pointing angle quotation", "139", "213", "8B", "10001011", "&lsaquo;", "&#139;");
                thirdTable.Rows.Add("Œ", "Latin capital ligature OE", "140", "214", "8C", "10001100", "&OElig;", "&#140;");
                thirdTable.Rows.Add("", "Unused", "141", "215", "8D", "10001101", "", "");
                thirdTable.Rows.Add("Ž", "Latin capital letter Z with caron", "142", "216", "8E", "10001110", "&Zcaron;", "&#142;");
                thirdTable.Rows.Add("", "Unused", "143", "217", "8F", "10001111", "", "");
                thirdTable.Rows.Add("", "Unused", "144", "220", "90", "10010000", "", "");
                thirdTable.Rows.Add("‘", "Left single quotation mark", "145", "221", "91", "10010001", "&lsquo;", "&#145;");
                thirdTable.Rows.Add("’", "Right single quotation mark", "146", "222", "92", "10010010", "&rsquo;", "&#146;");
                thirdTable.Rows.Add("“", "Left double quotation mark", "147", "223", "93", "10010011", "&ldquo;", "&#147;");
                thirdTable.Rows.Add("”", "Right double quotation mark", "148", "224", "94", "10010100", "&rdquo;", "&#148;");
                thirdTable.Rows.Add("•", "Bullet", "149", "225", "95", "10010101", "&bull;", "&#149;");
                thirdTable.Rows.Add("–", "En dash", "150", "226", "96", "10010110", "&ndash;", "&#150;");
                thirdTable.Rows.Add("—", "Em dash", "151", "227", "97", "10010111", "&mdash;", "&#151;");
                thirdTable.Rows.Add("˜", "Small tilde", "152", "230", "98", "10011000", "&tilde;", "&#152;");
                thirdTable.Rows.Add("™", "Trade mark sign", "153", "231", "99", "10011001", "&trade;", "&#153;");
                thirdTable.Rows.Add("š", "Latin small letter S with caron", "154", "232", "9A", "10011010", "&scaron;", "&#154;");
                thirdTable.Rows.Add("›", "Single right-pointing angle quotation mark", "155", "233", "9B", "10011011", "&rsaquo;", "&#155;");
                thirdTable.Rows.Add("œ", "Latin small ligature oe", "156", "234", "9C", "10011100", "&oelig;", "&#156;");
                thirdTable.Rows.Add("", "Unused", "157", "235", "9D", "10011101", "", "");
                thirdTable.Rows.Add("ž", "Latin small letter z with caron", "158", "236", "9E", "10011110", "&zcaron;", "&#158;");
                thirdTable.Rows.Add("Ÿ", "Latin capital letter Y with diaeresis", "159", "237", "9F", "10011111", "&Yuml;", "&#159;");
                thirdTable.Rows.Add("NBSP", "Non-breaking space", "160", "240", "A0", "10100000", "&nbsp;", "&#160;");
                thirdTable.Rows.Add("¡", "Inverted exclamation mark", "161", "241", "A1", "10100001", "&iexcl;", "&#161;");
                thirdTable.Rows.Add("¢", "Cent sign", "162", "242", "A2", "10100010", "&cent;", "&#162;");
                thirdTable.Rows.Add("£", "Pound sign", "163", "243", "A3", "10100011", "&pound;", "&#163;");
                thirdTable.Rows.Add("¤", "Currency sign", "164", "244", "A4", "10100100", "&curren;", "&#164;");
                thirdTable.Rows.Add("¥", "Yen sign", "165", "245", "A5", "10100101", "&yen;", "&#165;");
                thirdTable.Rows.Add("¦", "Pipe, broken vertical bar", "166", "246", "A6", "10100110", "&brvbar;", "&#166;");
                thirdTable.Rows.Add("§", "Section sign", "167", "247", "A7", "10100111", "&sect;", "&#167;");
                thirdTable.Rows.Add("¨", "Spacing diaeresis - umlaut", "168", "250", "A8", "10101000", "&uml;", "&#168;");
                thirdTable.Rows.Add("©", "Copyright sign", "169", "251", "A9", "10101001", "&copy;", "&#169;");
                thirdTable.Rows.Add("ª", "Feminine ordinal indicator", "170", "252", "AA", "10101010", "&ordf;", "&#170;");
                thirdTable.Rows.Add("«", "Left double angle quotes", "171", "253", "AB", "10101011", "&laquo;", "&#171;");
                thirdTable.Rows.Add("¬", "Negation", "172", "254", "AC", "10101100", "&not;", "&#172;");
                thirdTable.Rows.Add("­SHY", "Soft hyphen", "173", "255", "AD", "10101101", "&shy;", "&#173;");
                thirdTable.Rows.Add("®", "Registered trade mark sign", "174", "256", "AE", "10101110", "&reg;", "&#174;");
                thirdTable.Rows.Add("¯", "Spacing macron - overline", "175", "257", "AF", "10101111", "&macr;", "&#175;");
                thirdTable.Rows.Add("°", "Degree sign", "176", "260", "B0", "10110000", "&deg;", "&#176;");
                thirdTable.Rows.Add("±", "Plus-or-minus sign", "177", "261", "B1", "10110001", "&plusmn;", "&#177;");
                thirdTable.Rows.Add("²", "Superscript two - squared", "178", "262", "B2", "10110010", "&sup2;", "&#178;");
                thirdTable.Rows.Add("³", "Superscript three - cubed", "179", "263", "B3", "10110011", "&sup3;", "&#179;");
                thirdTable.Rows.Add("´", "Acute accent - spacing acute", "180", "264", "B4", "10110100", "&acute;", "&#180;");
                thirdTable.Rows.Add("µ", "Micro sign", "181", "265", "B5", "10110101", "&micro;", "&#181;");
                thirdTable.Rows.Add("¶", "Pilcrow sign - paragraph sign", "182", "266", "B6", "10110110", "&para;", "&#182;");
                thirdTable.Rows.Add("·", "Middle dot - Georgian comma", "183", "267", "B7", "10110111", "&middot;", "&#183;");
                thirdTable.Rows.Add("¸", "Spacing cedilla", "184", "270", "B8", "10111000", "&cedil;", "&#184;");
                thirdTable.Rows.Add("¹", "Superscript one", "185", "271", "B9", "10111001", "&sup1;", "&#185;");
                thirdTable.Rows.Add("º", "Masculine ordinal indicator", "186", "272", "BA", "10111010", "&ordm;", "&#186;");
                thirdTable.Rows.Add("»", "Right double angle quotes", "187", "273", "BB", "10111011", "&raquo;", "&#187;");
                thirdTable.Rows.Add("¼", "Fraction one quarter", "188", "274", "BC", "10111100", "&frac14;", "&#188;");
                thirdTable.Rows.Add("½", "Fraction one half", "189", "275", "BD", "10111101", "&frac12;", "&#189;");
                thirdTable.Rows.Add("¾", "Fraction three quarters", "190", "276", "BE", "10111110", "&frac34;", "&#190;");
                thirdTable.Rows.Add("¿", "Inverted question mark", "191", "277", "BF", "10111111", "&iquest;", "&#191;");
                thirdTable.Rows.Add("À", "Latin capital letter A with grave", "192", "300", "C0", "11000000", "&Agrave;", "&#192;");
                thirdTable.Rows.Add("Á", "Latin capital letter A with acute", "193", "301", "C1", "11000001", "&Aacute;", "&#193;");
                thirdTable.Rows.Add("Â", "Latin capital letter A with circumflex", "194", "302", "C2", "11000010", "&Acirc;", "&#194;");
                thirdTable.Rows.Add("Ã", "Latin capital letter A with tilde", "195", "303", "C3", "11000011", "&Atilde;", "&#195;");
                thirdTable.Rows.Add("Ä", "Latin capital letter A with diaeresis", "196", "304", "C4", "11000100", "&Auml;", "&#196;");
                thirdTable.Rows.Add("Å", "Latin capital letter A with ring above", "197", "305", "C5", "11000101", "&Aring;", "&#197;");
                thirdTable.Rows.Add("Æ", "Latin capital letter AE", "198", "306", "C6", "11000110", "&AElig;", "&#198;");
                thirdTable.Rows.Add("Ç", "Latin capital letter C with cedilla", "199", "307", "C7", "11000111", "&Ccedil;", "&#199;");
                thirdTable.Rows.Add("È", "Latin capital letter E with grave", "200", "310", "C8", "11001000", "&Egrave;", "&#200;");
                thirdTable.Rows.Add("É", "Latin capital letter E with acute", "201", "311", "C9", "11001001", "&Eacute;", "&#201;");
                thirdTable.Rows.Add("Ê", "Latin capital letter E with circumflex", "202", "312", "CA", "11001010", "&Ecirc;", "&#202;");
                thirdTable.Rows.Add("Ë", "Latin capital letter E with diaeresis", "203", "313", "CB", "11001011", "&Euml;", "&#203;");
                thirdTable.Rows.Add("Ì", "Latin capital letter I with grave", "204", "314", "CC", "11001100", "&Igrave;", "&#204;");
                thirdTable.Rows.Add("Í", "Latin capital letter I with acute", "205", "315", "CD", "11001101", "&Iacute;", "&#205;");
                thirdTable.Rows.Add("Î", "Latin capital letter I with circumflex", "206", "316", "CE", "11001110", "&Icirc;", "&#206;");
                thirdTable.Rows.Add("Ï", "Latin capital letter I with diaeresis", "207", "317", "CF", "11001111", "&Iuml;", "&#207;");
                thirdTable.Rows.Add("Ð", "Latin capital letter ETH", "208", "320", "D0", "11010000", "&ETH;", "&#208;");
                thirdTable.Rows.Add("Ñ", "Latin capital letter N with tilde", "209", "321", "D1", "11010001", "&Ntilde;", "&#209;");
                thirdTable.Rows.Add("Ò", "Latin capital letter O with grave", "210", "322", "D2", "11010010", "&Ograve;", "&#210;");
                thirdTable.Rows.Add("Ó", "Latin capital letter O with acute", "211", "323", "D3", "11010011", "&Oacute;", "&#211;");
                thirdTable.Rows.Add("Ô", "Latin capital letter O with circumflex", "212", "324", "D4", "11010100", "&Ocirc;", "&#212;");
                thirdTable.Rows.Add("Õ", "Latin capital letter O with tilde", "213", "325", "D5", "11010101", "&Otilde;", "&#213;");
                thirdTable.Rows.Add("Ö", "Latin capital letter O with diaeresis", "214", "326", "D6", "11010110", "&Ouml;", "&#214;");
                thirdTable.Rows.Add("÷", "Division sign", "247", "367", "F7", "11110111", "&divide;", "&#247;");
                thirdTable.Rows.Add("ø", "Latin small letter o with slash", "248", "370", "F8", "11111000", "&oslash;", "&#248;");
                thirdTable.Rows.Add("ù", "Latin small letter u with grave", "249", "371", "F9", "11111001", "&ugrave;", "&#249;");
                thirdTable.Rows.Add("ú", "Latin small letter u with acute", "250", "372", "FA", "11111010", "&uacute;", "&#250;");
                thirdTable.Rows.Add("û", "Latin small letter u with circumflex", "251", "373", "FB", "11111011", "&ucirc;", "&#251;");
                thirdTable.Rows.Add("ü", "Latin small letter u with diaeresis", "252", "374", "FC", "11111100", "&uuml;", "&#252;");
                thirdTable.Rows.Add("ý", "Latin small letter y with acute", "253", "375", "FD", "11111101", "&yacute;", "&#253;");
                thirdTable.Rows.Add("þ", "Latin small letter thorn", "254", "376", "FE", "11111110", "&thorn;", "&#254;");
                thirdTable.Rows.Add("ÿ", "Latin small letter y with diaeresis", "255", "377", "FF", "11111111", "&yuml;", "&#255;");

                data.Tables.Add(thirdTable);
                dgvASCII.DataSource = data.Tables[0];
            }
        }
        private void dgvASCII_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbControlChar_CheckedChanged(object sender, EventArgs e)
        {
            TabelaASCII();

        }

        private void rdbPrintChar_CheckedChanged(object sender, EventArgs e)
        {
            TabelaASCII();

        }

        private void rdbExtendedChar_CheckedChanged(object sender, EventArgs e)
        {
            TabelaASCII();
        }
    }
}
