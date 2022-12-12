using Dapper;
using First.CORE.COMMON;
using First.CORE.DATA;
using First.CORE.DTO;
using First.CORE.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace First.INFRA.REPOSITORY
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbContext _dbContext;
        public TestimonialRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CREATEtestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("TNAME", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TIMAGEPATH", testimonial.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TFEEDBACK", testimonial.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TSTATUSID", testimonial.Statusid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("testimonial_package.CREATEtestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public void Deletetestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("testimonialID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("testimonial_package.Deletetestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public List<Testimonial> GETALLtestimonial()
        {
            IEnumerable<Testimonial> result = _dbContext.Connection.Query<Testimonial>("testimonial_package.GETALLtestimonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<TestimonialDTO> GETALLtestimonialDTO()
        {
            IEnumerable<TestimonialDTO> result = _dbContext.Connection.Query<TestimonialDTO>("testimonial_package.getAllTestimonialDTO", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Testimonialstatus> GETALLtestimonialStatus()
        {
            IEnumerable<Testimonialstatus> result = _dbContext.Connection.Query<Testimonialstatus>("testimonial_package.getAllTestimonialStatus", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public Testimonial GETtestimonialBYID(int id)
        {
            var p = new DynamicParameters();
            p.Add("testimonialID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Testimonial> result = _dbContext.Connection.Query<Testimonial>("testimonial_package.GETtestimonialBYID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public Testimonialstatus GETtestimonialStatusBYID(int id)
        {
            var p = new DynamicParameters();
            p.Add("testimonialStatusID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Testimonialstatus> result = _dbContext.Connection.Query<Testimonialstatus>("testimonial_package.getTestimonialStatusByID", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UPDATETESTIMONIAL(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("testimonialID", testimonial.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("TSTATUSID", testimonial.Statusid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("testimonial_package.UPDATETESTIMONIAL", p, commandType: CommandType.StoredProcedure);
        }

        public List<Testimonial> getApprovedTestimonial()
        {
            IEnumerable<Testimonial> result = _dbContext.Connection.Query<Testimonial>("getApprovedTestimonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Testimonial> getTestimonialByName(string username)
        {

            var p = new DynamicParameters();
            p.Add("username", username, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Testimonial> result = _dbContext.Connection.Query<Testimonial>("testimonial_package.getTestimonialByName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
