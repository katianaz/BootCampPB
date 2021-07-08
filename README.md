# Katiana Mara Zeitz

### Criação de WEB API em C# e .Net para o cadastro de nome e email em um sistema. A aplicação também é capaz de consultar os nomes e emails já registrados, além de atualizar e excluír os dados.

1. Dentro de "Model" foi acrescentado as classes ("InteresseModel") do projeto e seus atributos ("Nome" e "Email");
    
2. Em "Services" foi acrescentado os objetos de retorno das funções, bem comoos parâmetros, tanto na interface quanto na classe;

3. Criou-se uma lista dentro da classe InteresseService para salvar em memória os dados;

>3.1 Método "Atualizar": baseado no email que foi requisitado, pega-se o índice deste email na lista de dados salvos, e esse índice é usado para substituir o objeto que veio por parâmetro, então retorna verdadeiro, caso contrário retorna falso; 

 >3.2 Método "Consultar": verifica se o email requisitado corresponde a algum e email já existente da lista, e retorna o objeto correspondente; 

>3.3 Método "ConsultarTodos": retorna a lista com todos os cadastros já realizados; 
>3.4 Método "Excluir": verifica se o email requisitado corresponde a algum e email já existente da lista, e exclui o objeto correspondente da lista e retorna verdadeiro, caso contrário retorna falso; 

>3.5 Método "Incluir": verifica se o email requisitado corresponde a algum e email já existente da lista, caso não exista inclui e retorna verdadeiro, caso contrário retorna falso;

4. Em "InteresseController" foi implementado os métodos contidos em "InteresseService" e retornardo os códigos HTTP condizentes;

>4.1 Método "ConsultarTodosInteresses": utiliza a função de consultar todos os interesses de "InteresseService" e então verifica se há algum objeto cadastrado na lista, caso haja retorna a lista e o status OK, caso contrário retorna Not Found. Em caso de erro, retorna Internal Server Error; 

>4.2 Método "ConsultarInteresse": utiliza a função de consultar a interessada por email, e então verifica se há este objeto cadastrado na lista, caso haja retorna o objeto e o status OK, caso contrário retorna Not Found. Em caso de erro, retorna Internal Server Error;

>4.3 Método "AdicionarInteresse": utiliza a função de incluir do serviço, caso o retorno seja verdadeiro retorna status OK, caso contrário retorna Bad Request. Em caso de erro, retorna Internal Server Error;

>4.4 Método "AtualizarInteresse": utiliza a função atualizar do serviço, caso o retorno seja verdadeiro retorna status OK, caso contrário retorna Not Found. Em caso de erro, retorna Internal Server Error; 

>4.5 Método "ExcluirInteresse": utiliza a função excluir do serviço, caso o retorno seja verdadeiro retorna status OK, caso contrário retorna Not Found. Em caso de erro, retorna Internal Server Error;

 5. No "ArquivoBaseBootCamp.xml" foi adicionado o restante das funções do Controller.
