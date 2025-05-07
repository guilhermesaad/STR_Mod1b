#STR_SoftwareMockup
Software que simula comportamento de uma Measure Unit de subestação, gera pacotes JSON com essas medições mockup e envia via broadcast pelo protocolo UDP. Sistema em tempo real com critérios de temporização bem definidos. App WinFomr, feito em C#.


#Integrantes
- Guilherme Saad Botrel 12121ECP018
- Marco Túllio Silva 12121ECP011


#Projeto
No repositório existem 2 aplicativos:
- Mod1bSWMockup: módulo 1b, software mockup
- AppAnalisePacotes: teste de análise e recebimento de pacotes


#Divisão de tarefas
- Guilherme Saad:
   - Interfaces gráficas dos dois aplicativos;
   - pag Sobre;
   - Cadastro de MU;
   - Modelagem da máquina de estados (MU.cs linha 88).

- Marco Túllio:
   - pag Dashboard;
   - Lógica de redes no envio e recebimento de pacotes;
   - Aplicativo de recebimento completo;
   - Uso de treads no envio (1 thread p/ cada MU)
