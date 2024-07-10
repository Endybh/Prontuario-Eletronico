# Prontuario-Eletronico

Projeto para fornecer uma aplicação para gerenciar e manter prontuarios e registro de sessões de psicoterapia

Uma clínica de psicoterapia deseja construir uma aplicação simples para manter e gerenciar prontuários de seus pacientes.
Esta aplicação deve fornecer alta segurança de forma somente o terapeuta de determinado paciente possa acessar o seu formulário.
para manter a premissa de sigilo profissional e paciente/cliente, esta aplicação contará com um módulo principal chamado PRONTUÁRIO,
este módulo é o ponto de entrada e o ponto central da aplicação, pois é a partir dele que será acessado as outras funcionalidades da
aplicação. São elas:
 -Registro de Sessão.
 -Atualizar dados cadastrais
 -Tranferência de caso.

 Como primeira entrega, teremos o módulo principal PRONTUÁRIO com as funcionalidades abertura de novo prontuário, registro de sessão e atualização de dados cadastrais e o módulo
 PROFISSIONAL que é responsável por gerir e manter a base de dados de profisisonais que atendem na plataforma.

## MÓDULO PRONTUÁRIO
 ### Abertura de Prontuário:

 - Em um primeiro momento quando ocorrer a primeira sessão de um paciente, ele ainda não existe no sistema, sendo assim o psicologo neste primeira atendimento realizado
 o acolhimento desta pessoa, juntando informações e entendendo a demanda, então o profissional realiza a abertura do prontuário deste paciente no momento em que ele decide
 seguir com o processo terapeutico, nesta tela do sistema, o psicologo cadastra o paciente com os seus principais dados, criando uma relação de confidencialidade entre paciente e
 psicologo, a partir daqui, somente o psicologo que abriu o prontuário deve ter acesso as informações e aos registros de sessão deste paciente. Nenhum outro profissional registrado
 na plataforma deve ter acesso aos registros deste paciente a menos que o caso seja transferido a outro profissional cadastrado na plataforma com devido consentimento do paciente.
 aqui, o psicologo realiza o registro da primeira sessão a qual o paciente traz a demanda ao profissional.

 ### Registro de sessão:
 - Nesta funcionalidade o psicologo após realizar sessão com o paciente e ouvi-lo, acessará a plataforma para realizar o registro da sessão.
 Aqui o psicologo pode registrar todas as anotações das informações que colheu durante a sessão do paciente em formato de memo. sendo assim,
 um prontuário está para uma ou mais sessões e várias sessões está para um prontuário, além do memo que representa as anotações e os registros
 da sessão, essa entidade SESSSÃO deverá contar informações como data e horário que a sessão aconteceu, bem como estar assossiada ao prontuário do paciente.

 Atualização de dados cadastrais
 - Aqui será permitida a atualização dos dados cadastrais do paciente

## MÓDULO PROFISSIONAL

 Esse módulo deve fornecer uma tela incial de consulta dos profissionais cadastrados na plataforma que são previamente cadastrados por um administrador da plataforma.
 na tela de consulta deve ter botões de novo que deve dar acesso a um formulário de cadastro de profissional com as devidas informações e um botão para permitir a edição
 deste profissional caso haja alguma atualização cadastral e um botão para deletar, para remover o profissional da plataforma, neste caso a exclusão do profissional da plataforma
 deverá ser lógica, devendo seus registro permanecerem na plataforma para fins de histórico ou caso ele queira reativar seu cadastro. Ao manter as informações deste profissional
 no banco de dados após sua exclusão lógica, deve ser observada a LGPD e sob hipotese alguma estes dados deverão ser compartilhados.
