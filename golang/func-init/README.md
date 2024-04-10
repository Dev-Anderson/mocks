Em Go, a funão "init()"  é especial, pois ela é chamada automaticamente pelo tempo de execução antes da função 
"main()" ser executada. Ela é usada para a inicialização de pacotes. 
A função "init()" é usada principalmente para realizar qualquer inicialização necessária antes que o programa comece a ser executado. Isso pode incluir a inicialização de variáveis, a configurçaão de vlaores padrão, a execução de tarefas de configuração ou até mesmo a execução de códgioo que requer a execução antes da função "main()". 
Cada pacote pode ter uma ou mais funções "init()" e essas funções são chamadas na ordem em que são declaradas dentro do arquivo de código fonte. No entanto, não é pos´sivel ontrolar diretamente a ordem em que as funções "init()" de diferentes pacotes são executadas, então é uma boa prática escrever o códgioo de forma que ela não dependa da ordem especifica em que as fuçnões "init()" são chamadas. 