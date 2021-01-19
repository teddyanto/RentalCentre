﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rental_Centre.Models
{
    public class model_msrental
    {
        RCDB _DB = new RCDB();
        public IEnumerable<msrental> getAllData()
        {
            var msrental = (from data in _DB.msrental
                            select data);
            return msrental;
        }
        public void addData(msrental msrental)
        {
            _DB.msrental.Add(msrental);
            _DB.SaveChanges();
        }
        public void editPassword(msrental msrental)
        {
            msrental oldData = _DB.msrental.Single<msrental>(s => s.id_rental == msrental.id_rental);
            oldData.password = msrental.password;
            _DB.SaveChanges();
        }
        public void editData(msrental msrental)
        {
            msrental oldData = _DB.msrental.Single<msrental>(s => s.id_rental == msrental.id_rental);

            oldData.nama_rental = msrental.nama_rental;
            oldData.nama_toko = msrental.nama_toko;
            oldData.no_telp = msrental.no_telp;
            oldData.NIK = msrental.NIK;
            oldData.email = msrental.email;
            oldData.tempat_lahir = msrental.tempat_lahir;
            oldData.tgl_lahir = msrental.tgl_lahir;
            oldData.alamat = msrental.alamat;
            oldData.alamat_toko = msrental.alamat_toko;
            oldData.kodepos = msrental.kodepos;
            oldData.jenis_kelamin = msrental.jenis_kelamin;            
            oldData.nama_bank = msrental.nama_bank;
            oldData.no_rek = msrental.no_rek;            
            oldData.modidate = msrental.modidate;
            if(msrental.profil != "")
            {
                oldData.profil = msrental.profil;
            }
            if(msrental.berkas1 != "")
            {
                oldData.berkas1 = msrental.berkas1;
            }
            if(msrental.berkas2 != "")
            {
                oldData.berkas2 = msrental.berkas2;
            }                        
            _DB.SaveChanges();

        }
        public void hapusData(int id)
        {
            msrental msrental = _DB.msrental.Single<msrental>(s => s.id_rental == id);
            msrental.status = 0;
            _DB.SaveChanges();
        }
    }
}