using System;
namespace DeckOfCardsAPI.Models
{
    public partial class ReshuffleDeckModel
    {
        public bool Success { get; set; }
        public string DeckId { get; set; }
        public long Remaining { get; set; }
        public bool Shuffled { get; set; }
    }
}

