# Ejercicio1Api

Para ejecutar en docker:

Port: 5010

ENV:

    - ASPNETCORE_URLS=http://+:5010

    - ConnectionStrings__DefaultConnection=Server=server; Database=db;User Id=sa;Password=password;


## Docker exec

docker build -t api .

docker run --network=nt0 -p 5010:5010 --name api-1 api