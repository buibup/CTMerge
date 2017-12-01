﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CTMerge.API.Repositories;
using CTMerge.API.ViewModel;

namespace CTMerge.API.Services
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientVisitRepository;
        public PatientService()
        {
            _patientVisitRepository = new PatientRepository();
        }

        public Task<IEnumerable<PatientVM>> GetPatientBCTAsync(string search)
        {
            return _patientVisitRepository.GetPatientBCT(search);
        }

        public Task<IEnumerable<BasePatientVM>> GetPatientSCTByHNAsync(string hn)
        {
            return _patientVisitRepository.GetPatientSCTByHN(hn);
        }

        public Task<IEnumerable<BasePatientVM>> GetPatientSCTByNameAsync(string firstName, string lastName)
        {
            return _patientVisitRepository.GetPatientSCTByName(firstName, lastName);
        }

        public Task<bool> IsPatientExistsAsync(string hn)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientVisitVM>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PatientVisitVM> ReadOneAsync(string hn)
        {
            throw new NotImplementedException();
        }
    }
}