echo "building"
dotnet build --no-restore --configuration Release

echo "deploying site"
cd C:\Users\ljaczewski\source\repos\C#\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\bin\Release\net6.0\
scp *.* ptuser@20.82.180.135:~/www/dotnet04/
cd C:\Users\ljaczewski\source\repos\C#\Devops2023Dotnet31MVC\Devops2023Dotnet31MVC\
scp -r .\wwwroot\ ptuser@20.82.180.135:~/www/dotnet04/

echo "restarting service"
ssh ptuser@20.82.180.135 sudo systemctl restart dotnet04.service