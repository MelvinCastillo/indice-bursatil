using System;
using System.Data;

namespace Gobix.BusinessLayer
{
    public class GobixData
    {
        private Gobix.DataLayer.GobixData _GobixData = new DataLayer.GobixData();

        public DataSet exe_SP_GET_Gobix_Data(int index)
        {
            return _GobixData.exe_SP_GET_Gobix_Data(index);
        }

        public DataSet exe_SP_GET_TBL_INDEX_MASTER()
        {
            return _GobixData.exe_SP_GET_TBL_INDEX_MASTER();
        }

        public DataSet exe_SP_Validate_Before_Execute(DateTime date)
        {
            return _GobixData.exe_SP_Validate_Before_Execute(date);
        }

        public DataSet exe_SP_Sel_Index_Result(DateTime date)
        {
            return _GobixData.exe_SP_Sel_Index_Result(date);
        }

        public DataSet exe_SP_CALC_Index_With_Result(DateTime date, int IdRebalancing)
        {
            return _GobixData.exe_SP_CALC_Index_With_Result(date, IdRebalancing);
        }

        public DataSet exe_SP_Sel_Rebalancing_Master(int? id)
        {
            return _GobixData.exe_SP_Sel_Rebalancing_Master(id);
        }

        public DataSet exe_SP_Sel_Rebalancing(int? id)
        {
            return _GobixData.exe_SP_Sel_Rebalancing(id);
        }

        public DataSet exe_SP_Set_Activate_Rebalancing(int IdRebalancing)
        {
            return _GobixData.exe_SP_Set_Activate_Rebalancing(IdRebalancing);
        }

        public bool exe_SP_Create_Rebalancing(DateTime RebalancingDate, double Tipp)
        {            
            return _GobixData.exe_SP_Create_Rebalancing(RebalancingDate, Tipp);
        }

        public DataSet exe_SP_Sel_Index_View(int ID, DateTime FechaIni, DateTime FechaFin)
        {
            return _GobixData.exe_SP_Sel_Index_View(ID, FechaIni, FechaFin);
        }
        
        public DataSet exe_exe_SP_Next_Rebalancing_Master()
        {
            return _GobixData.exe_SP_Next_Rebalancing_Master();
        }

        public DataSet exe_SP_LastDates_Rebalancing_Master()
        {
            return _GobixData.exe_SP_LastDates_Rebalancing_Master();
        }

        public bool exe_SP_Insert_Rebalancing_Master(DateTime CurrentDate,
                                                     DateTime LastData,
                                                     DateTime BeforeLastDate,
                                                     double tippp,
                                                     bool Status)
        {
            return _GobixData.exe_SP_Insert_Rebalancing_Master(CurrentDate,
                                                               LastData,
                                                               BeforeLastDate,
                                                               tippp,
                                                               Status);
        }
        
        public bool exe_SP_Insert_Datos_Ponderacion_Total(int ID_Master,
                                                        float VALOR_MERCADO_TOTAL,
                                                        float PONDERACION_TOTAL_POR,
                                                        float PONDERACION_TOTAL_DEC)
        {
            return _GobixData.exe_SP_Insert_Datos_Ponderacion_Total(ID_Master,
                                                                    VALOR_MERCADO_TOTAL,
                                                                    PONDERACION_TOTAL_POR,
                                                                    PONDERACION_TOTAL_DEC);
        }
        
        public bool exe_SP_Insert_Rebalancing_Details(int ID_Master,
                                                       DateTime Date,
                                                       string ISIN,
                                                       double Tasa,
                                                       DateTime CuponDate,
                                                       bool Status)
        {
            return _GobixData.exe_SP_Insert_Rebalancing_Details(ID_Master,
                                                       Date,
                                                       ISIN,
                                                       Tasa,
                                                       CuponDate,
                                                       Status);
        }

        public bool exe_SP_Insert_Rebalancing_Excluded(int ID_Master,
                                                       DateTime Date,
                                                       string ISIN)
        {
            return _GobixData.exe_SP_Insert_Rebalancing_Excluded(ID_Master,
                                                       Date,
                                                       ISIN);
        }

        public bool exe_SP_Insert_DATOS_PONDERACION(int ID_Master,
                                                    DateTime FECHA_DE_LOS_DATOS,
                                                    string ISIN,
                                                    float PRECIO_SUCIO,
                                                    float MONTO_EMITIDO,
                                                    float VALOR_MERCADO,
                                                    float PONDERACION,
                                                    float PONDERACION_POR)
        {
            return _GobixData.exe_SP_Insert_DATOS_PONDERACION(ID_Master,
                                                    FECHA_DE_LOS_DATOS,
                                                    ISIN,
                                                    PRECIO_SUCIO,
                                                    MONTO_EMITIDO,
                                                    VALOR_MERCADO,
                                                    PONDERACION,
                                                    PONDERACION_POR);
        }
        
    }
}
