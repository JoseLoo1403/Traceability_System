using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Helpers
{
    public class EndScannedModel
    {
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public int ComponentNumber { get; set; }
        public int SerialNumber { get; set; }
        public int FinishedGood { get; set; }

        public EndScannedModel(Piece piece, int serialNumber)
        {
            Name = piece.PieceName;
            PartNumber = piece.PiecePartNumber;
            ComponentNumber = (int)piece.ComponentNumber;
            SerialNumber = serialNumber;
            FinishedGood = piece.FinishedGood == null ? 0 : (int)piece.FinishedGood;
        }
    }
}
