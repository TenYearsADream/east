using System;
 namespace lasetCtrl {

partial class Tags {
// ���������,   Real, %MD604  
    public float get_temp_stola ()
    { return (float) m_plc.getMReal(604); }

// ����(1-3),   Real, %MD608  
    public float get_temp__13_ ()
    { return (float) m_plc.getMReal(608); }

// ����(4-6),   Real, %MD612  
    public float get_temp__46_ ()
    { return (float) m_plc.getMReal(612); }

// ����9,   Real, %MD616  
    public float get_davl9 ()
    { return (float) m_plc.getMReal(616); }

// ����10,   Real, %MD620  
    public float get_davl10 ()
    { return (float) m_plc.getMReal(620); }

// ����11,   Real, %MD624  
    public float get_davl11 ()
    { return (float) m_plc.getMReal(624); }

// ��63-1,   Int, %MW628  
    public Int16 get_kl631 ()
    { return (Int16) m_plc.getMWord(628); }

// ��63-2,   Int, %MW630  
    public Int16 get_kl632 ()
    { return (Int16) m_plc.getMWord(630); }

// ��100-3,   Int, %MW632  
    public Int16 get_kl1003 ()
    { return (Int16) m_plc.getMWord(632); }

// �����1,   Int, %MW634  
    public Int16 get_pnevm1 ()
    { return (Int16) m_plc.getMWord(634); }

// �����2,   Int, %MW636  
    public Int16 get_pnevm2 ()
    { return (Int16) m_plc.getMWord(636); }

// �����3,   Int, %MW638  
    public Int16 get_pnevm3 ()
    { return (Int16) m_plc.getMWord(638); }

// �����4,   Int, %MW640  
    public Int16 get_pnevm4 ()
    { return (Int16) m_plc.getMWord(640); }

// �������,   Real, %MD642  
    public float get_linejka ()
    { return (float) m_plc.getMReal(642); }

// �������,   Real, %MD646  
    public float get_tolshhina ()
    { return (float) m_plc.getMReal(646); }

// ��͠������������,   Real, %MD650  
    public float get_tjen_stola_tek_moshhn ()
    { return (float) m_plc.getMReal(650); }

// ����1,   DInt, %MD654  
    public Int64 get_test1 ()
    { return (Int64) m_plc.getMDWord(654); }

// ����2,   DInt, %MD658  
    public Int64 get_test2 ()
    { return (Int64) m_plc.getMDWord(658); }

// ���Po1,   Real, %MD662  
    public float get_ga_po1 ()
    { return (float) m_plc.getMReal(662); }

// ���Po2,   Real, %MD666  
    public float get_ga_po2 ()
    { return (float) m_plc.getMReal(666); }

// ���Po3,   Real, %MD670  
    public float get_ga_po3 ()
    { return (float) m_plc.getMReal(670); }

// ���Ph2,   Real, %MD674  
    public float get_ga_ph2 ()
    { return (float) m_plc.getMReal(674); }

// ���E1,   Real, %MD682  
    public float get_ga_e1 ()
    { return (float) m_plc.getMReal(682); }

// ���E2,   Real, %MD686  
    public float get_ga_e2 ()
    { return (float) m_plc.getMReal(686); }

// ���E3,   Real, %MD690  
    public float get_ga_e3 ()
    { return (float) m_plc.getMReal(690); }

// ���E4,   Real, %MD694  
    public float get_ga_e4 ()
    { return (float) m_plc.getMReal(694); }

// ���I_IVG1,   Real, %MD698  
    public float get_ga_i_ivg1 ()
    { return (float) m_plc.getMReal(698); }

// ���I_IVG2,   Real, %MD702  
    public float get_ga_i_ivg2 ()
    { return (float) m_plc.getMReal(702); }

// ���T1,   Real, %MD706  
    public float get_ga_t1 ()
    { return (float) m_plc.getMReal(706); }

// ���T2,   Real, %MD710  
    public float get_ga_t2 ()
    { return (float) m_plc.getMReal(710); }

// ���T3,   Real, %MD714  
    public float get_ga_t3 ()
    { return (float) m_plc.getMReal(714); }

// ���T4,   Real, %MD718  
    public float get_ga_t4 ()
    { return (float) m_plc.getMReal(718); }

// ���Tros,   Real, %MD722  
    public float get_ga_tros ()
    { return (float) m_plc.getMReal(722); }

// ���Tivg,   Real, %MD726  
    public float get_ga_tivg ()
    { return (float) m_plc.getMReal(726); }

// ���Ph2o,   Real, %MD730  
    public float get_ga_ph2o ()
    { return (float) m_plc.getMReal(730); }

// ���������,   Real, %MD734  
    public float get_kar_tek_poz ()
    { return (float) m_plc.getMReal(734); }

// ����������,   Real, %MD738  
    public float get_stol_tek_poz ()
    { return (float) m_plc.getMReal(738); }

// ��͠(1-3)��������,   Real, %MD678  
    public float get_tjen__13__tek_moshhn ()
    { return (float) m_plc.getMReal(678); }

// ��͠(4-6)��������,   Real, %MD742  
    public float get_tjen__46__tek_moshhn ()
    { return (float) m_plc.getMReal(742); }

// �������,   Int, %MW746  
    public Int16 get_ohl_skan ()
    { return (Int16) m_plc.getMWord(746); }

// ��������,   DInt, %MD748  
    public Int64 get_schjot_slojov ()
    { return (Int64) m_plc.getMDWord(748); }

// ����3,   Real, %MD752  
    public float get_tok_sh3 ()
    { return (float) m_plc.getMReal(752); }

// �������,   Int, %MW756  
    public Int16 get_ost_slojov ()
    { return (Int16) m_plc.getMWord(756); }

// �������������������,   Int, %MW758  
    public Int16 get_ost_slojov_dlya_dozatora ()
    { return (Int16) m_plc.getMWord(758); }

// ���������,   Int, %MW760  
    public Int16 get_inkrement ()
    { return (Int16) m_plc.getMWord(760); }

// ���������,   Int, %MW764  
    public Int16 get_dekrement ()
    { return (Int16) m_plc.getMWord(764); }

// �����������,   Int, %MW766  
    public Int16 get_nomer_vyhoda ()
    { return (Int16) m_plc.getMWord(766); }

    }
 }
