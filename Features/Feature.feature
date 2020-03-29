Feature: PegasusBDD
	

@mytag
Scenario: SenaryoOne
	* 2 saniye bekle
	* '//*[@id='fligth-searh']/div[2]/div[1]/div/span/span[1]/span/span[2]' objesine tıklanır..
	* 'select2-search__field' objesine 'istanbul-' yazılır. 
	* '//*[@id='fligth-searh']/div[2]/div[2]/div/span/span[1]/span/span[2]' objesine tıklanır..
	* 'select2-search__field' objesine 'kayseri' yazılır.
	* '//*[@id='fligth-searh']/div[3]/div[1]/div/div[1]/span' objesine tıklanır..
	* 'Gidiş Bilet' seçimi '10.Mayıs.2020'
	* 'Dönüş Bileti' seçimi '23.Kasım.2020'
	* 2 saniye bekle
	* '//*[@id='flight']//button' objesine tıklanır..
	* 'Gidiş için' uçuş seçimi yapılır. '//*[@id='boarding-card-body']/div[1]/div[3]/div[2]/div[2]/div[2]/div[1]'
	* 'Gidiş için' Ekonomik paket seçimi yapılır. '//*[@id='boarding-card-body']/div[1]/div[3]/div[2]/div[2]/div[2]/div[1]/div/div[2]/div[1]/button/div[2]/div'
	* 2 saniye bekle
	* 'Dönüş için' uçuş seçimi yapılır. '//*[@id="boarding-card-body"]/div[1]/div[3]/div[3]/div[2]/div[2]/div[1]'
	* 'Döüş için' Ekonomik paket seçimi yapılır. '//*[@id="boarding-card-body"]/div[1]/div[3]/div[3]/div[2]/div[2]/div[1]/div/div[2]/div[1]/button/div[2]/div'
	* 3 saniye bekle
	
	
	
	#* Rastgele 'Dönüş için' uçuş seçimi yapılır.
	#* 10 saniye bekle
	#* 'Gidiş bileti için' Ekonomik paket seçimi yapılır. '//*[@id='boarding-card-body']/div[1]/div[3]/div[2]/div[2]/div[2]/div[2]/div/div[2]/div[1]/button/div[2]'
	
	#* 'Dönüş bileti için' Ekonomik paket seçimi yapılır. '//*[@id="boarding-card-body"]/div[1]/div[3]/div[3]/div[2]/div[2]/div[3]/div/div[2]/div[1]/button/div[2]/div'
	

#	* 'Gidiş Bileti' için '//*[@id='search-flight-datepicker-departure']/div/div[1]/div/div/span[2]' objesinde '2021' senesi seçilir.
#	* 'Gidiş Bileti' için '//*[@id='search-flight-datepicker-departure']/div/div[1]/div/div/span[1]' objesinde 'Şubat' ay'ı seçilir.
#	* 'Gidiş Bileti' için '//*[@id='search-flight-datepicker-departure']/div/div[1]//tbody//a' objesinde '12' günü seçilir.
#	* 2 saniye bekle
#	* 'Dönüş Bileti' için '//*[@id="search-flight-datepicker-arrival"]/div/div[1]/div/div/span[2]' objesinde '2022' senesi seçilir.
#	* 'Dönüş Bileti' için '//*[@id='search-flight-datepicker-arrival']/div/div[1]/div/div/span[1]' objesinde 'Mayıs' ay'ı seçilir.
#	* 'Dönüş Bileti' için '//*[@id="search-flight-datepicker-arrival"]/div/div[1]//tbody//a' objesinde '10' günü seçilir.
#	* 5 saniye bekle