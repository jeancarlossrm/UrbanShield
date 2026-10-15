# UrbanShield

**Projeto Integrador — Documento de Definição do Projeto**  
**Aplicativo de Prevenção de Furtos no Trânsito Urbano**  
**Equipe EchoElite — Senac TDS**

---

## Briefing

### Missão
Prevenir e alertar usuários sobre áreas com risco de furto ou roubo em tempo real, permitindo que cada pessoa tome decisões mais seguras no dia a dia.

### Público-Alvo
O UrbanShield é voltado para motoristas e pessoas com acesso a tecnologia que usam o celular enquanto estão no trânsito de grandes cidades como São Paulo. São pessoas que, no dia a dia, passam por semáforos, congestionamentos e ruas movimentadas sem saber quais locais têm maior risco de furto naquele horário.

### Proposta de Valor
O UrbanShield ajuda motoristas a evitarem furtos através de alertas inteligentes baseados em localização, horário e histórico criminal.

---

## Personas

### Persona 1 – Quem já foi vítima.
Para entender melhor quem usa o aplicativo, criamos uma persona: Carlos tem 34 anos e rala como motorista de app nas noites de São Paulo. A vida dele é o trânsito: são umas 8 horas por dia rodando com o celular no painel, grudado no GPS para pegar as corridas.

Era uma quinta-feira, 18h30. Carlos estava parado no semáforo da Avenida Paulista com o celular na mão. Em segundos, um homem bateu no vidro e levou o aparelho. Ele não tinha como saber que aquele cruzamento registrava mais de 40 furtos por mês naquele horário. Nenhum app avisou. Nenhuma notificação chegou.

Após o ocorrido e a compra de um novo aparelho, ele descobriu o aplicativo UrbanShield, com avaliações boas sobre alerta de furtos durante o trânsito. As palavras dele antes de navegar com o app são: *"Eu estava parado lá sem saber de nada. Se alguém tivesse me avisado, eu teria guardado o celular."*

### Persona 2 – Quem se preveniu
Joyce depende do carro diariamente para o trajeto de ida e volta do trabalho. Sua rota principal inclui a Marginal Tietê, que ela costuma atravessar exatamente no horário de pico, um cenário marcado pelo trânsito lento e por uma maior vulnerabilidade a furtos rápidos.

Como muitos motoristas, ela sempre mantém o celular no suporte do painel para acompanhar o trajeto. Porém, após um colega de trabalho ser assaltado no trânsito nessas mesmas condições, o alerta acendeu. Buscando uma forma de se prevenir, ela baixou o UrbanShield. Quando ao diminuir a velocidade em horário de pico devido a trânsito lento de um dia típico o celular apitou e mostrou o alerta: *"Área de alto risco de furto. Guarde o celular e seus pertences, mantenha os vidros fechados."*

Sem hesitar, ela retirou o aparelho do suporte e o escondeu. Apenas dois minutos depois do aviso, a ameaça se confirmou: Joyce presenciou um homem tentando abordar o veículo que estava logo ao lado do seu. Após o acontecimento a frase da Joyce foi a seguinte: *"O app avisou antes que eu percebesse o perigo. Guardei o celular e não aconteceu nada. Simples assim."*

---

## Sobre o Produto
O UrbanShield é um aplicativo para celular que avisa o usuário quando ele está passando por uma área com histórico de furtos e roubos. Ele faz isso cruzando três informações: onde o usuário está agora, que horas são e o que aconteceu naquele local no passado. Com esses dados, o app calcula se o risco está baixo, médio ou alto e manda um aviso sonoro ou visual para a tela do celular.

O diferencial do UrbanShield é que ele não mostra apenas um mapa estático com pontos perigosos ele analisa o momento atual e avisa somente quando faz sentido, evitando notificações desnecessárias.

### Concorrência

| Aplicativo | Foco Principal | Limitação |
| :--- | :--- | :--- |
| **Waze** | Trânsito e acidentes | Não foca em crimes, avisos genéricos |
| **Google Maps** | Navegação geral | Sem dados de segurança criminal |
| **SafeApp** | Segurança urbana | Pouca cobertura e dados desatualizados |
| **UrbanShield** | Prevenção de furtos | Foco exclusivo em criminalidade, com análise por horário |

---

## Análise de Mercado
O mercado de segurança urbana digital está em crescimento acelerado no Brasil. Segundo o Fórum Brasileiro de Segurança Pública, o país registrou mais de 800 mil celulares roubados ou furtados em 2023, com concentração nas regiões metropolitanas. Só em São Paulo, a Secretaria de Segurança Pública (SSP-SP) registrou mais de 180 mil furtos de aparelhos celulares nesse mesmo período.

Esse cenário cria uma demanda real por soluções que vão além do que aplicativos de navegação já oferecem. O UrbanShield se posiciona no cruzamento entre três segmentos em expansão: aplicativos de segurança pessoal, mobilidade urbana e tecnologia para cidades inteligentes (Smart Cities). Esse último segmento tem atraído investimentos de prefeituras e empresas privadas, o que representa uma oportunidade de parceria e patrocínio para o projeto.

---

## Objetivos do Projeto

### Objetivo Geral
Criar um aplicativo para celular que avise os usuários, em tempo real, quando estiverem passando por regiões com alto índice de furtos e roubos, ajudando a reduzir a chance de vitimização no trânsito urbano.

### Objetivos Específicos
Para alcançar o objetivo geral, o projeto precisa cumprir as seguintes metas:
- Usar o GPS do celular para saber onde o usuário está a todo momento.
- Verificar, em tempo real, se aquela região tem histórico de crimes no horário atual.
- Calcular se o risco é baixo, médio, alto ou extremo e exibir isso de forma clara.
- Emitir um aviso sonoro e uma mensagem na tela quando o risco for alto.
- Mostrar um mapa com as áreas mais perigosas destacadas por cor.
- Dar dicas de proteção ao usuário, como guardar o celular ou fechar os vidros do carro.

---

## Justificativa do Projeto
O número de furtos de celular no Brasil não para de crescer. De acordo com dados da SSP-SP disponíveis em base de dados oficial de SSP-SP, o estado de São Paulo registra dezenas de milhares de celulares subtraídos por mês, com concentração em horários e locais específicos — o que comprova que esses crimes seguem padrões identificáveis.

Apesar de existirem aplicativos de navegação como Waze e Google Maps, nenhum deles foi criado para prevenir furtos. Eles avisam sobre acidentes, buracos e radares, mas não informam ao motorista se ele está parado em um semáforo de uma rua com histórico de abordagem rápida naquele horário.

O UrbanShield nasce para preencher esse espaço. Usando dados públicos da Secretaria de Segurança Pública de São Paulo e a localização do próprio celular do usuário, o aplicativo transforma informação em prevenção — de forma simples, automática e acessível para qualquer pessoa que tenha um smartphone Android com acesso à internet.

---

## Definição do Problema
Motoristas com acesso a tecnologia que usam o celular no trânsito não têm como saber, naquele momento exato, se o local onde estão parados ou transitando tem alto risco de furto. As informações sobre criminalidade existem, mas estão espalhadas em relatórios difíceis de acessar e não chegam até o usuário de forma prática.

O resultado disso é que as pessoas se tornam vítimas sem ter tido nenhuma chance de se precaver. O UrbanShield resolve esse problema conectando os dados de ocorrências com a localização do usuário em tempo real, traduzindo tudo isso em um aviso simples e direto: *"Atenção você está em uma área de risco alto agora."*

---

## O Que o Aplicativo Precisa Fazer

### Funções Principais do Aplicativo
Abaixo estão descritas as principais funções que o aplicativo precisa ter para funcionar como esperado. Cada item está explicado de forma simples, sem termos técnicos:

| ID | O que o aplicativo faz |
| :--- | :--- |
| **RF01** | Saber onde o usuário está usando o GPS do próprio celular, atualizando a localização a todo momento. |
| **RF02** | Consultar o histórico de crimes registrados naquela região e naquele horário, usando dados da SSP-SP. |
| **RF03** | Comparar a localização atual, o horário e o histórico de crimes para entender o nível de perigo. |
| **RF04** | Definir se o risco é baixo, médio, alto ou extremo e mostrar isso para o usuário na tela. |
| **RF05** | Emitir um aviso sonoro e uma mensagem visível na tela quando o risco for alto. |
| **RF06** | Exibir um mapa com as áreas perigosas destacadas por cores diferentes conforme o nível de risco. |
| **RF07** | Perceber se o veículo está parado ou em movimento lento, o que aumenta o risco de abordagem. |
| **RF08** | Repetir esse processo automaticamente, sem que o usuário precise fazer nada. |
| **RF09** | Dar dicas de segurança ao usuário, como guardar o celular ou fechar os vidros do carro. |

---

## O Que o Aplicativo Precisa Para Funcionar
Para que o UrbanShield funcione corretamente, o usuário precisará ter:

| ID | Requisito |
| :--- | :--- |
| **RNF01** | Um smartphone Android com acesso à internet (wi-fi ou dados móveis), para que o app receba as informações atualizadas sobre as áreas de risco. |
| **RNF02** | O GPS do celular ativado, para que o aplicativo saiba onde o usuário está. |
| **RNF03** | Espaço disponível na memória do celular, para guardar os mapas de risco e funcionar mesmo sem internet em momentos de queda de sinal. |
| **RNF04** | Sistema operacional Android (versão inicial) - a versão para iPhone está prevista para uma etapa futura do projeto. |
| **RNF05** | Uma tela que permita ler facilmente as notificações, pois a interface foi pensada para ser simples e direta. |
| **RNF06** | Velocidade de processamento básica — funciona até em aparelhos mais simples. |

---

## O Que Está Incluído no Projeto

### O Que Será Desenvolvido
Nesta primeira versão, o UrbanShield irá conter:
- Monitoramento de localização em tempo real usando o GPS do celular.
- Análise automática do risco com base no local, no horário e no histórico de crimes.
- Avisos sonoros e visuais quando o usuário entrar em área de risco alto.
- Mapa interativo com as regiões de risco destacadas por cores.
- Banco de dados com histórico de furtos e roubos extraído das planilhas públicas da SSP-SP, será atualizado vip API através do link pelo site da SSP disponíveis em base de dados oficial de SSP-SP.
- Versão para celulares Android.

### O Que Não Fará Parte Desta Versão
Para manter o projeto viável dentro do prazo, alguns recursos foram deixados para versões futuras:
- Integração direta com a polícia ou com a central 190.
- Rastreamento de celulares já furtados.
- Câmeras ou monitoramento por vídeo.
- Versão para iPhone (iOS) - prevista para uma etapa futura.
- Central de atendimento com pessoas físicas.

---

## Como o Aplicativo Funciona
O funcionamento do UrbanShield pode ser dividido em três partes: o que ele recebe, o que ele processa e o que ele mostra para o usuário.

### O Que o Aplicativo Recebe
A cada atualização, o aplicativo coleta automaticamente:
- A localização exata do usuário, fornecida pelo GPS do celular.
- O horário atual do sistema.
- A velocidade aproximada do deslocamento (se está parado, lento ou em movimento).
- Os registros históricos de crimes da região, vindos dos dados da SSP-SP.

### O Que o Aplicativo Analisa
Com essas informações, o aplicativo verifica se aquela região tem histórico de crimes, se o horário atual coincide com os horários de maior risco e se o usuário está parado ou em movimento lento, situação que aumenta a vulnerabilidade. Com base nessa análise, o sistema define o nível de risco.

### O Que o Usuário Recebe
Dependendo do que foi analisado, o usuário recebe um dos seguintes retornos:

| Situação | O que o app mostra |
| :--- | :--- |
| Região sem histórico de crimes | Nada, o mapa fica limpo, sem alertas. |
| Região com crimes, mas fora do horário de risco | Aviso discreto na tela, sem som. |
| Região com crimes no horário de risco, usuário em movimento | Mensagem de atenção moderada na tela. |
| Região com crimes, horário de risco e usuário parado | Alarme sonoro + mensagem de alerta na tela. |

---

## Metas do Projeto — Matriz SMART
A Matriz SMART é uma ferramenta que ajuda a definir metas claras e alcançáveis. Cada letra representa uma característica que a meta precisa ter:

| Critério | Descrição |
| :--- | :--- |
| **S — Específico** | Desenvolver um MVP funcional e validá-lo com pelo menos 30 usuários durante o projeto. |
| **M — Mensurável** | Acompanhar o número de usuários cadastrados, os alertas emitidos e a avaliação do app nas lojas digitais, com meta de manter nota acima de 4 estrelas. |
| **A — Atingível** | Utilizar dados gratuitos e públicos da SSP-SP, o GPS padrão dos celulares Android e ferramentas de desenvolvimento gratuitas, sem necessidade de grandes investimentos iniciais. |
| **R — Relevante** | Reduzir a sensação de insegurança dos usuários no trânsito, contribuindo para que menos pessoas sejam pegas de surpresa em situações de risco. |
| **T — Temporal** | Versão funcional em até 12 meses. Meta principal: 5.000 usuários ativos e mais de 2.000 horas de uso nos primeiros 6 meses após o lançamento. |

**Resumindo a meta principal:** *"Alcançar 5.000 usuários ativos e gerar mais de 2.000 horas de uso nos primeiros 6 meses após o lançamento."*

---

## Cronograma

| Período | O que será feito |
| :--- | :--- |
| **1º Mês** | Coleta e organização dos dados históricos da SSP-SP. Definição dos requisitos, escopo e layout do aplicativo. |
| **2º Mês** | Desenvolvimento do backend — a parte do sistema que processa os dados e calcula o risco. |
| **3º Mês** | Desenvolvimento do frontend — a tela que o usuário vê, com o mapa, avisos e notificações. |
| **4º ao 12º Mês** | Testes com usuários reais (motoristas), ajustes, divulgação do app, coleta de feedback e pitch acadêmico final. |

---

## Quem Está Envolvido no Projeto
Stakeholders são todas as pessoas ou grupos que têm alguma relação com o projeto — seja porque serão afetados por ele, porque contribuem com algo ou porque têm interesse no resultado.

| Quem | Papel no Projeto |
| :--- | :--- |
| **Usuários do aplicativo** | As pessoas que vão usar o app no dia a dia para se proteger de furtos no trânsito. |
| **Equipe EchoElite** | Os alunos responsáveis por criar, desenvolver e apresentar o projeto. |
| **SSP-SP (Secretaria de Segurança Pública)** | Fornece os dados públicos de ocorrências que alimentam o banco de informações do app. |
| **Empresas de mobilidade (Uber, 99, Waze)** | Possíveis parceiros estratégicos que poderiam integrar ou patrocinar a solução. |
| **Prefeituras e órgãos públicos** | Potenciais investidores dentro do conceito de Cidades Inteligentes (Smart Cities). |

---

## Riscos do Projeto e Como Evitá-los
Todo projeto tem riscos — situações que podem dar errado e atrasar ou prejudicar o resultado. Identificamos os principais abaixo, junto com o que faremos para evitá-los ou reduzir o impacto:

| O que pode dar errado | Probabilidade | Impacto | O que faremos se acontecer |
| :--- | :--- | :--- | :--- |
| **Dados da SSP-SP desatualizados ou indisponíveis** | Média | Alto | Combinar os dados oficiais com relatos dos próprios usuários do app. |
| **Queda de internet durante o uso** | Alta | Alto | Salvar os mapas de risco no próprio celular para funcionar offline. |
| **GPS impreciso (dentro de túneis ou prédios)** | Média | Médio | Usar a última localização conhecida e uma margem de área ao redor. |
| **Poucos usuários nos primeiros meses** | Média | Médio | Divulgar o app por meio de parcerias com faculdades e grupos de motoristas. |
| **Dificuldade de acessar dados públicos de segurança** | Média | Alto | Usar arquivos locais como alternativa enquanto as fontes externas não estão disponíveis. |

---

## Estimativa de Orçamento
Para que o projeto seja viável, é importante estimar os custos envolvidos. Por ser um projeto acadêmico desenvolvido por alunos, a maioria das ferramentas utilizadas é gratuita. Ainda assim, alguns custos podem surgir ao longo do desenvolvimento:

| Pesquisa de Itens | Tipo | Custo Estimado |
| :--- | :--- | :--- |
| **SQLServer (banco de dados e autenticação)** | Gratuito na versão básica | R$ 0,00 |
| **Google Maps API (mapas e geolocalização)** | Gratuito até certo volume de uso | R$ 0,00 — R$ 200,00/mês |
| **Publicação na Google Play Store** | Taxa única | R$ 125,00 (aprox. US$ 25) |
| **Ferramentas de desenvolvimento (VS Code, Flutter, .NET Maui)** | Gratuitas | R$ 0,00 |
| **Design de interface (Figma)** | Gratuito para equipes pequenas | R$ 0,00 |
| **Hospedagem (Github) e servidor (se necessário)** | Variável | R$ 0,00 — R$ 150,00/mês |
| **Total estimado (fase inicial)** | | **R$ 125,00 a R$ 475,00/mês** |

*Vale destacar que o uso dos dados da SSP-SP é gratuito e público, o que elimina o custo de compra de base de dados — uma das maiores vantagens competitivas do projeto.*

---

## Quando o Projeto Estará Pronto
Para considerar o aplicativo pronto para uso, ele precisará atender aos seguintes critérios:
- Emitir avisos em tempo real quando o usuário entrar em área de risco alto.
- Mostrar o mapa com as regiões perigosas corretamente identificadas por nível de risco.
- Atualizar as informações automaticamente, sem que o usuário precise fazer nada.
- Exibir o nível de risco de forma clara e fácil de entender na tela.
- Tocar um aviso sonoro e exibir uma mensagem visível nos casos de risco alto.
- Funcionar em celulares Android com GPS e internet.

---

## Tecnologias Utilizadas
Abaixo estão as ferramentas e tecnologias que serão usadas para construir o UrbanShield. Todas são amplamente utilizadas no mercado e compatíveis com o nível de desenvolvimento da equipe:

| Para que serve | Ferramenta escolhida |
| :--- | :--- |
| Criar as telas do aplicativo (o que o usuário vê) | Linguagem ou app de FrontEnd |
| Guardar os dados dos usuários e das ocorrências | Modelar e Guardar via Banco de dados |
| Mostrar o mapa e calcular a localização | API Mapa + GPS do celular |
| Obter os dados de crimes de São Paulo | Planilhas públicas da SSP-SP (link oficial) |
| Enviar alertas e atualizações em tempo real | Via Notificação ou PopUp |

---

## EAP — Estrutura do Projeto por Etapas
A EAP (Estrutura Analítica do Projeto) organiza tudo o que precisa ser feito em partes menores e gerenciáveis. Cada item é uma entrega concreta que a equipe deve completar:

**1. Planejamento**
*   1.1 Levantamento de requisitos e escopo
*   1.2 Pesquisa de dados da SSP-SP e análise de viabilidade
*   1.3 Definição do cronograma e distribuição de tarefas

**2. Design**
*   2.1 UX — mapeamento da experiência do usuário e fluxos de navegação
*   2.2 UI — criação das telas e identidade visual no Figma

**3. Desenvolvimento**
*   3.1 Backend — lógica de cálculo de risco e integração com SSP-SP
*   3.2 Frontend — telas do app, mapa interativo e notificações
*   3.3 Banco de Dados — estruturação e importação dos dados de ocorrências

**4. Testes**
*   4.1 Testes funcionais — verificar se cada função do app funciona corretamente
*   4.2 Testes de performance — verificar se o app é rápido e estável
*   4.3 Testes com usuários reais — coletar feedback de motoristas em campo

**5. Encerramento**
*   5.1 Documentação técnica final
*   5.2 Apresentação e pitch acadêmico
*   5.3 Publicação do app e coleta de feedback inicial

---

## Próximos Passos e Expansões Futuras
Após o lançamento da primeira versão, o UrbanShield poderá crescer com novos recursos:
- Definir metas preditivas sobre onde os crimes vão acontecer antes mesmo de ocorrerem.
- Mapa de calor atualizado diariamente com as regiões mais perigosas da cidade.
- Sistema de relatos colaborativos, onde os próprios usuários registram ocorrências em tempo real.
- Versão para iPhone (iOS).
- Parcerias com prefeituras para integrar os dados do app ao monitoramento das cidades.
- Integração com seguradoras e aplicativos de mobilidade como Uber e 99.

---

## Por Que o UrbanShield é Diferente
> "O UrbanShield não apenas mostra áreas perigosas. Ele analisa o momento, o local e o horário para agir antes que o problema aconteça."

A maioria dos aplicativos mostra um mapa com pontos perigosos mas não te avisa naquele momento, naquele segundo, que você está parado em um local de risco alto às 18h de uma quinta-feira. O UrbanShield faz exatamente isso: cruza o onde, o quando e o histórico para entregar um alerta que realmente faz sentido naquela situação.

Não é um app de navegação. Não é um app de câmera. É um app de prevenção pensado para funcionar silenciosamente em segundo plano e só interromper o usuário quando vale a pena.

---

## Diagramas

*(Nota: Como este é um documento em texto, as imagens originais dos diagramas devem ser anexadas ou visualizadas no arquivo original.)*

### Diagrama - Caso de uso 
`[Imagem: Diagrama de Caso de Uso]`

### Diagrama de caso de Uso UML
`[Imagem: Diagrama de Caso de Uso UML]`

### Fluxograma
`[Imagem: Fluxograma]`