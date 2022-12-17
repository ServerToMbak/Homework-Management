using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entites;

namespace Core.Interfaces
{
    
    public interface IGenericRepository<T> where T:BaseEntity//Generic tip sadece BaseEntity Olacak yani
    //entitylerimiz için ortak bir repository oluşturacaz
    {
        Task<T> GetByIdAsycn(int id);//id ile asenkron olarak tek entity döndüren metot 
        Task<IReadOnlyList<T>> ListAllAsync(); //Generic olarak verilen entity türündeki tüm veriyi 
        //asenkron olarak döndüren metot 

        
    }
}