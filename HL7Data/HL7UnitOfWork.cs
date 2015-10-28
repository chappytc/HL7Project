using System;
using System.Diagnostics.CodeAnalysis;
using HL7Data.Repositories;
using HL7Data.Repositories.Interfaces;
using HL7Model;

namespace HL7Data
{
    public class HL7UnitOfWork : IHL7UnitOfWork, IDisposable
    {
        private HL7DbContext _dbContext { get; set; }

        public HL7UnitOfWork()
        {
            CreateDbContext();
        }
        
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        private IPatientRepository _patientsRepository;
        public IPatientRepository Patients
        {
            get
            {
                if (_patientsRepository == null)
                {
                    _patientsRepository = new PatientRepository(_dbContext);

                }
                return _patientsRepository;
            }
        }

        private IDiagnosisRepository _diagnosesRepository;
        public IDiagnosisRepository Diagnoses
        {
            get
            {
                if (_diagnosesRepository == null)
                {
                    _diagnosesRepository = new DiagnosisRepository(_dbContext);

                }
                return _diagnosesRepository;
            }
        }

        protected void CreateDbContext()
        {
            _dbContext = new HL7DbContext();

            // Do NOT enable proxied entities, else serialization fails.
            //if false it will not get the associated certification and skills when we
            //get the applicants
            //_dbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            //_dbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            //_dbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                }
            }
        }
    }
}
