# Rest provider on MSSQL

![](https://www.handybackup.net/images/icons/mssql-backup.png)

Rest provider on MSSQL of CLR (C#) using WebRequest
## Descriptions
- available method 
  - POST
  - GET

- available options
  - Headers <br>
    use this structure <b>key</b> <span style='color:red'> : </span>  <b>value</b> <font color="blue"> | </font> <b>key</b> <span style='color:red'> : </span>  <b>value</b>


## Configuration
```sql
sp_configure 'clr enabled', 1;
GO
RECONFIGURE;
GO
```

## Instalation
