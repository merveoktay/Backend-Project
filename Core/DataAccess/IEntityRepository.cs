using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
	public interface IEntityRepository<T> where T:class,IEntity,new()//Entities nesnelerini alması için yaptık
	{
		List<T> GetAll(Expression<Func<T,bool>>filter=null);//filtreleyerek listeleme işlemi için kullanılır null boş da olsa olur demek
		T Get(Expression<Func<T, bool>> filter );
		void Add(T entity); 
		void Update(T entity);
		void Delete(T entity);

	} 
}
