using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;
using Traceability_System.Helpers;

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

        public Piece GetPieceByPartNumberAndFinishedGood(string partNumber, int finishedGood)
        {
            return context.Pieces.FirstOrDefault(x => x.PiecePartNumber == partNumber && x.FinishedGood == finishedGood);
        }

        public List<Piece> GetAllPieces()
        {
            return context.Pieces.ToList();
        }

        public void UpdateScannedPieces(List<Piece> pieces, int userCode)
        {
            foreach (var piece in pieces)
            {
                var result = context.Pieces.FirstOrDefault(x => x.Id == piece.Id);
                result.Active = false;
                result.UserScanned = userCode;
                result.ScannedDate = DateFormatHelper.GetCurrentDate();
                context.SaveChanges();
            }
        }

        public void UpdatePieceActive(int pieceId)
        {
            var piece = context.Pieces.FirstOrDefault(x => x.Id == pieceId);
            piece.Active = false;
            context.SaveChanges();
        }

        public bool FinishGoodExist(int? code)
        {
            var res = context.Pieces.FirstOrDefault(x => x.FinishedGood == code);
            return res != null;
        }

        public void AddPiece(Piece piece)
        {
            context.Pieces.Add(piece);
            context.SaveChanges();
        }

        public void DeletePiece(Piece piece)
        {
            context.Pieces.Remove(piece);
            context.SaveChanges();
        }
    }
}
