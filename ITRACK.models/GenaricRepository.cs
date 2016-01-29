using ITRACK.DBConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITRACK.models
{
   public  class GenaricRepository<TEntity> : IGenaricRepository<TEntity> where TEntity : class
    {
       /// <summary>
       /// 
       /// </summary>
       protected DbSet<TEntity> DbSet;
       /// <summary>
       /// 
       /// </summary>
       private readonly DbContext _dbContext;

       /// <summary>
       /// 
       /// </summary>
       /// <param name="dbContext"></param>
       /// 


       private string GetConnection() {
           try {
               ConnectionDetails Con = new ConnectionDetails();
               return Con.readConnection();
           }
           catch(Exception ex){
               return "";
           }
          
       }

       public GenaricRepository(DbContext dbContext) {
        
           _dbContext = dbContext;
           _dbContext.Database.Connection.ConnectionString = GetConnection();
           _dbContext.Configuration.AutoDetectChangesEnabled = false;
           
           DbSet = _dbContext.Set<TEntity>();
       }
       /// <summary>
       /// 
       /// </summary>
       public GenaricRepository() { 
       
       }


       /// <summary>
       /// find entity by id with wait 
       /// </summary>
       /// <param name="Id"> Record ID</param>
       /// <returns> DbSet</returns>
        public async Task<TEntity> GetIdByAsync(int Id)
        {
            return await DbSet.FindAsync(Id); 
        }


       

        public async Task<TEntity> GetkeyByAsync(string Id)
        {
            return await DbSet.FindAsync(Id); 
        }

       
        public async Task<TEntity> GetIdByAsync(string Id)
        {
            return await DbSet.FindAsync(Id);
        }
       
       /// <summary>
       /// 
       /// </summary>
       /// <param name="predicate"></param>
       /// <returns></returns>
        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
            
        }


       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        
     
        

        public async Task<List<TEntity>> GetAllData()
        {
           
            return await DbSet.ToListAsync();
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="entity"></param>
       /// <returns></returns>
        public async Task EditAsync(TEntity entity)
        {
           _dbContext.Entry(entity).State = EntityState.Modified;
           
            await  _dbContext.SaveChangesAsync();
            MessageBox.Show("Update Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="entity"></param>
       /// <returns></returns>
        public async Task AddAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            if (await _dbContext.SaveChangesAsync() > 0)
            {

                MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Item Already Exist !", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
  

        }



       /// <summary>
       /// 
       /// </summary>
       /// <param name="entity"></param>
       /// <returns></returns>
        public async Task DeleteAsync(TEntity entity)
        {
           // DbSet.Remove(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();
            MessageBox.Show("Delete Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public bool Delete(TEntity entity)
        {
            // DbSet.Remove(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
            if (_dbContext.SaveChanges() > 0) {
                return true;
            }else{
                return false;
            }
     
           
        }


        public bool Edit(TEntity entity)
        {
       

            _dbContext.Entry(entity).State = EntityState.Modified;

            if (_dbContext.SaveChanges() > 0)
            {
                MessageBox.Show("Update Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;

            }
            else
            {
                MessageBox.Show("Item Already Exist !", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
           
        }

        public bool Update(TEntity entity)
        {


            _dbContext.Entry(entity).State = EntityState.Modified;

            if (_dbContext.SaveChanges() > 0)
            {
               
                return true;

            }
            else
            {
               
                return false;

            }

        }
  
       
       
       public bool Insert(TEntity entity)
        {

            try
            {
                DbSet.Add(entity);


                if (_dbContext.SaveChanges() > 0)
                {
                   
                    return true;

                }
                else
                {
         
                    return false;

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }


        }



       public bool InsertLongOpration(TEntity entity,bool isLast)
       {

           try
           {
               DbSet.Add(entity);

               if (isLast == true)
               {
                   if (_dbContext.SaveChanges() > 0)
                   {

                       return true;

                   }


                   else
                   {

                       return false;

                   }
               }
               else {
                   return false;
               }
              
           }
           catch (Exception ex)
           {

               Debug.WriteLine(ex.Message);
               return false;
           }


       }


      

        public bool Add(TEntity entity)
        {

            try {
                DbSet.Add(entity);


                if (_dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    MessageBox.Show("Item Already Exist !", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;

                }
            }
            catch(Exception ex){
                
                Debug.WriteLine(ex.Message);
                return false;
            }
                 

        }







    }
}
