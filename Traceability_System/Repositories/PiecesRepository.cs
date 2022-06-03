using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Repositories
{
    public class PiecesRepository
    {
        private Traceability_System_DbContext context;

        public PiecesRepository()
        {
            context = new Traceability_System_DbContext();
        }

        public Piece GetPieceByPartNumber(string partNumber)
        {
            return context.Pieces.FirstOrDefault(x => x.PiecePartNumber == partNumber);
        }

        public void UpdateScannedPieces(List<Piece> pieces, int userCode)
        {
            DateTime date = DateTime.Now;
            date = new DateTime(date.Ticks - (date.Ticks % TimeSpan.TicksPerSecond), date.Kind);

            foreach (var piece in pieces)
            {
                var result = context.Pieces.FirstOrDefault(x => x.Id == piece.Id);
                result.Active = false;
                result.UserScanned = userCode;
                result.ScannedDate = date;
                context.SaveChanges();
            }
        }
    }
}
