# Daiwa
Daiwa coding test for identifying and removing the outlier values from the provided CSV
===============================================================================

1. The application developed is a Windows forms application
2. Please select the CSV file having Price details clicking the Browse button in the UI
3. Data will be loaded in a data grid
4. Outlier calculation implemented in 2 ways
	i)Method 1
		a) Using formula with help of Standard deviation and average for the static values in the CSV file.
		b) this value will be loaded below the label 'Calculation using Standard formula'
		c) When you click 'Remove outlier and reload data' the grid will be refreshed after removing that single record
		d) the above button will be read only after 1 click.
	ii) Method 2
		a) Comparing the price between one day against its previous day. The largest difference record is considered as outlier.
		b) this value will be loaded below the label 'Calculation using Historical record'
		c) When you click 'Remove outlier and reload data' below, the grid will be refreshed after removing that single record
		d) the above button will be read only after 1 click.
5.  THe CSV file hase been loaded to a datatable and all calculations done within the table only.

Thanks!!