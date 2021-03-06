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

        public Task<PatientVisitVM> GetPatientBCTVisitAsync(string hn)
        {
            return _patientVisitRepository.GetPatientBCTVisit(hn);
        }

        public Task<IEnumerable<BasePatientVM>> GetPatientSCTByHNAsync(string hn)
        {
            return _patientVisitRepository.GetPatientSCTByHN(hn);
        }

        public Task<IEnumerable<BasePatientVM>> GetPatientSCTByNameAsync(string firstName, string lastName)
        {
            return _patientVisitRepository.GetPatientSCTByName(firstName, lastName);
        }

        public async Task<bool> IsPatientExistsAsync(string hn)
        {
            return await _patientVisitRepository.HasPatient(hn);
        }

        public async Task<bool> MergedLog(PatientMergedLogVM log)
        {
            return await _patientVisitRepository.MergedLog(log);
        }

        public Task<bool> PatientMergeAsync(string BCT_HN, string SCT_HN, string USERNAME, string FULLNAME, string STATUS)
        {
            return _patientVisitRepository.PatientMerge(BCT_HN, SCT_HN, USERNAME, FULLNAME, STATUS);
        }
    }
}