using IniParser;
using IniParser.Model;
using System;
using System.Drawing;

namespace Zekotec01.Models
{
    class FontDialogParse
    {

        public Font GetFont()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("FontSetting.ini");
            Font font = new Font(data["GridFont"]["fontType"], int.Parse(data["GridFont"]["fontSize"]));
            return font;
        }

        public bool SaveFont(Font dlg)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("FontSetting.ini");
            data["GridFont"]["fontSize"] = Math.Ceiling(dlg.Size).ToString(); ;
            data["GridFont"]["fontType"] = dlg.FontFamily.Name;
            parser.WriteFile("FontSetting.ini", data);
            return true;
        }

    }
}
