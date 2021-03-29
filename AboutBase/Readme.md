## : base(props)

Quando temos uma classe pai, temos propriedades, contrutores e metodos dentro dessa classe.

Quando herdamos ela para uma classe filha, as propriedades, contrutores e metodos passam para a mesma(filha). Se usarmos um construtor da classe pai na classe filha, que tem um ou mais parametros, temos que usar o ": base()" informando os parametros a serem passados para o construtor pai.

Se não informar-mos o base, a classe filha vai ser criada com o primeiro construtor encontrado na classe pai, no qual pode surgir problemas.

Quando usamos o base em um contrutor, o base chama o construtor pai que é o primeiro a ser executado, logo após, o construtor do filho vai ser executado, porem, alterando as variaveis apenas da instancia do filho.
