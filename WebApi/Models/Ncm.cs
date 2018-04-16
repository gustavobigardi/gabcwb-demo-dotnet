using System;
using System.Text;

namespace WebApi.Models
{
    public class Ncm
    {
        public long Id { get; set; }
        public string Chapter { get; set; }
        public string ChapterDescription { get; set; }
        public string Position { get; set; }
        public string PositionDescription { get; set; }
        public string SubPosition { get; set; }
        public string SubPositionDescription { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string SubItem { get; set; }
        public string SubItemDescription { get; set; }
        public string Unit { get; set; }
        public string UnitDescription { get; set; }
        public DateTime LastUpdate { get; set; }

        public string FullDescription {
            get {
                return ""
                    + (ChapterDescription ?? "") + "\n"
                    + (PositionDescription ?? "") + "\n"
                    + (SubPositionDescription ?? "") + "\n"
                    + (ItemDescription ?? "") + "\n"
                    + (SubItemDescription ?? "") + "\n";
            }
        }

        public string FullCode {
            get {
                return SubItem;
            }
        }
    }
}