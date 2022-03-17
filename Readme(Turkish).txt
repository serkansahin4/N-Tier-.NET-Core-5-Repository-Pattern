.Net CORE 5 ile birlikte genel olarak Onion Architecture kullanıldığı için, Araştırdığım hiçbir kaynakta
N-Tier Architecture ile repository tasarım kalıbının net bir şekilde anlatıldığını görmedim. Bu yüzden bu
tasarım kalıbının N-Tier Architecture ile kullanımını paylaşmak istedim. 

Burada yaptığım şunlardır;

Öncelikle
DataAccess
Business
Entities
UI (WebAPI kullandım)

Katmanlarını oluşturdum.

Repository Design Pattern, "Don't repeat yourself" düşüncesi ile birlikte kullanılan bir pattern.
Bu yüzden bana göre, her repository için ayrı ayrı aynı CRUD işlemlerini yazmak yerine, CRUD işlemlerinin
bir çatı altında toplanıp, bu çatının repositorylere miras verilerek kullanılması Repository Design Pattern'ının
asıl kullanım amacıdır.



.Net Core da repository design patternını kullanırken

(((((((PROBLEM))))))))
AK47ccContext(DbContextOptions<AK47Context> options):base(options){}    (AK47 Nin CONSTRUCTOR'ı)

EfEntityRepositoryBase<TEntity,TContext> => iken

ProductDal:EfEntityRepositoryBase<Product, AK47ccContext> => bu tarz bir kullanımda AK47cc Contextinin Constructor parametresi problem çıkartıyordu

(((((((ÇÖZÜM)))))))

EfEntityRepositoryBase<TEntity,TContext> yerine EfEntityRepositoryBase<TEntity> şeklinde yapılan hatayı düzeltmektir.
Detayları
Projenin katmanları içerisinde gezinerek çok net bir şekilde neyin nerede olduğunu ve nasıl olması gerektiğini anlacaksınız.



