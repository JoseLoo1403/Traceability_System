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

        public Piece GetPieceByPartNumberAndGeneration(string partNumber, int generation)
        {
            return context.Pieces.FirstOrDefault(x => x.PiecePartNumber == partNumber && x.Generation == generation);
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
                result.UserScanned = userCode;
                result.ScannedDate = DateFormatHelper.GetCurrentDate();
                context.SaveChanges();
            }
        }

        public void UpdatePieceActive(int pieceId)
        {
            var piece = context.Pieces.FirstOrDefault(x => x.Id == pieceId);

            if (piece.Active == true)
            {
                piece.Active = false; 
            }
            else
            {
                piece.Active = true;
            }

            context.SaveChanges();
        }

        public void ActivePieceForOneDay(Piece piece)
        {
            var result = context.Pieces.FirstOrDefault(x => x.PiecePartNumber == piece.PiecePartNumber && x.FinishedGood == piece.FinishedGood);

            DateTime today = DateTime.Now;
            DateTime created = (DateTime)piece.CreatedDate;

            int Days = Convert.ToInt32((today - created).TotalDays);

            result.DaysEnable = Days + 1;
            result.Active = true;

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
