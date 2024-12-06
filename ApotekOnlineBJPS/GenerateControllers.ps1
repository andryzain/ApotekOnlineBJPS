
# Tentukan folder untuk models dan controllers
$modelsFolder = "Models"
$controllersFolder = "Controllers"
$contextClass = "ApplicationDbContext"

# Ambil semua file model yang ada dalam folder
$models = Get-ChildItem -Path $modelsFolder -Filter "*.cs"

# Loop untuk setiap model dan jalankan scaffolding untuk controller
foreach ($model in $models) {
    $modelName = $model.BaseName
    $controllerName = $modelName + "Controller"
    Write-Host "Membuat controller untuk model: $modelName"

    # Jalankan scaffolding untuk setiap model
    dotnet aspnet-codegenerator controller -name $controllerName -m $modelName -dc $contextClass --relativeFolderPath $controllersFolder --useDefaultLayout
}
