using Сафари.Data.Enum;
using Сафари.Data.Models;
using Сафари.Data.Models.MaterialsModels;

namespace Сафари.Data.MainData
{
    public class SettingMaterialsDataBase
    {
        public void AddData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                AddCategoryMaterials();              
                AddMaterials();

            };
        }
        public void AddCategoryMaterials()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.CategoryMaterials.AddRange(
                    new CategoryMaterials() { Name = "Матеріал для стін" },
                    new CategoryMaterials() { Name = "Матеріал для даху" },
                    new CategoryMaterials() { Name = "Матеріал для фундаменту" },                    
                    new CategoryMaterials() { Name = "Матеріал для підлоги" },
                    new CategoryMaterials() { Name = "Матеріал для стелі" });                
                db.SaveChanges();
            };
        }
        public void AddMaterials()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Materials.AddRange(
                    //Матеріал для стін
                    new Materials() { Name= "Цегла керамічна", Measure = "Поштучно", UnitPrice = 7, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    new Materials() { Name = "Цегла силікатна", Measure = "Поштучно", UnitPrice = 5, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    new Materials() { Name = "Оциліндрований брус", Measure = "м3", UnitPrice = 7000, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    new Materials() { Name = "Клеєний профільований брус", Measure = "м3", UnitPrice = 17971, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    new Materials() { Name = "Газобетонний  блок", Measure = "м3", UnitPrice = 7000, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    new Materials() { Name = "Керамоблоки", Measure = "Поштучно", UnitPrice = 42, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    new Materials() { Name = "Піноблоки", Measure = "м3", UnitPrice = 2460, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForWalls) },
                    //Матеріал для даху
                    new Materials() { Name = "Металочерепиця", Measure = "м2", UnitPrice = 150, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },
                    new Materials() { Name = "Бітумна черепиця", Measure = "м2", UnitPrice = 500, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },
                    new Materials() { Name = "Композитна черепиця", Measure = "м2", UnitPrice = 600, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },
                    new Materials() { Name = "Шифер", Measure = "Поштучно", UnitPrice = 189, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },
                    new Materials() { Name = "Ондулін", Measure = "Поштучно", UnitPrice = 256, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },
                    new Materials() { Name = "Профнастил", Measure = "м2", UnitPrice = 216, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },                   
                    new Materials() { Name = "Ондулін", Measure = "Поштучно", UnitPrice = 256, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForRoofing) },
                    //Матеріал для фундаменту
                    new Materials() { Name = "Фундаментні блоки", Measure = "Поштучно", UnitPrice = 300, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFoundation) },
                    new Materials() { Name = "Бетон", Measure = "м3", UnitPrice = 1225, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFoundation) },
                    new Materials() { Name = "Пісок", Measure = "Тонна", UnitPrice = 135, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFoundation) },
                    new Materials() { Name = "Щебінь", Measure = "Тонна", UnitPrice = 125, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFoundation) },
                    new Materials() { Name = "Арматура", Measure = "Метр", UnitPrice = 5, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFoundation) },
                    //Матеріал для підлоги
                    new Materials() { Name = "Лінолеум ", Measure = "м2", UnitPrice = 176, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFloor) },
                    new Materials() { Name = "Коркова підлога", Measure = "м2", UnitPrice = 1400, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFloor) },
                    new Materials() { Name = "Ламінат", Measure = "м2", UnitPrice = 300, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFloor) },
                    new Materials() { Name = "Керамічна плитка", Measure = "Поштучно", UnitPrice = 162, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForFloor) },
                    //Матеріал для стелі
                    new Materials() { Name = "Гіпсокартон ", Measure = "Лист", UnitPrice = 139, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForCeilings) },
                    new Materials() { Name = "Пластикові панелі", Measure = "Лист", UnitPrice = 80, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForCeilings) },
                    new Materials() { Name = "Глянцеві натяжні стелі", Measure = "м2", UnitPrice = 190, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForCeilings) },
                    new Materials() { Name = "Стельова плитка", Measure = "м2", UnitPrice = 32, CategoryMaterialsId = ((int)EnumForCategoryMaterials.MaterialsForCeilings) }

                    );
                db.SaveChanges();
            };
        }
    }
}
