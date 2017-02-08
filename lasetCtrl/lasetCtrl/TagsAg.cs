using System;
 namespace lasetCtrl {

partial class Tags {
//-----------------------------------------------------------------------------
//tags/am.xml
//-----------------------------------------------------------------------------
// темп стола,   Real, %MD604   reg = M  width = UInt32
    public float get_temp_stola ()
    { return (float) m_mem.getMFloat(604); }

    public void set_temp_stola (float val)
    { m_mem.setMFloat(604, (float) val); }

// темп (1-3),   Real, %MD608   reg = M  width = UInt32
    public float get_temp_1_3 ()
    { return (float) m_mem.getMFloat(608); }

    public void set_temp_1_3 (float val)
    { m_mem.setMFloat(608, (float) val); }

// темп (4-6),   Real, %MD612   reg = M  width = UInt32
    public float get_temp_4_6 ()
    { return (float) m_mem.getMFloat(612); }

    public void set_temp_4_6 (float val)
    { m_mem.setMFloat(612, (float) val); }

// давл9,   Real, %MD616   reg = M  width = UInt32
    public float get_davl9 ()
    { return (float) m_mem.getMFloat(616); }

    public void set_davl9 (float val)
    { m_mem.setMFloat(616, (float) val); }

// давл10,   Real, %MD620   reg = M  width = UInt32
    public float get_davl10 ()
    { return (float) m_mem.getMFloat(620); }

    public void set_davl10 (float val)
    { m_mem.setMFloat(620, (float) val); }

// давл11,   Real, %MD624   reg = M  width = UInt32
    public float get_davl11 ()
    { return (float) m_mem.getMFloat(624); }

    public void set_davl11 (float val)
    { m_mem.setMFloat(624, (float) val); }

// кл63-1,   Int, %MW628   reg = M  width = UInt16
    public Int16 get_kl63_1 ()
    { return (Int16) m_mem.getMUInt16(628); }

    public void set_kl63_1 (Int16 val)
    { m_mem.setMUInt16(628, (UInt16) val); }

// кл63-2,   Int, %MW630   reg = M  width = UInt16
    public Int16 get_kl63_2 ()
    { return (Int16) m_mem.getMUInt16(630); }

    public void set_kl63_2 (Int16 val)
    { m_mem.setMUInt16(630, (UInt16) val); }

// кл100-3,   Int, %MW632   reg = M  width = UInt16
    public Int16 get_kl100_3 ()
    { return (Int16) m_mem.getMUInt16(632); }

    public void set_kl100_3 (Int16 val)
    { m_mem.setMUInt16(632, (UInt16) val); }

// пневм1,   Int, %MW634   reg = M  width = UInt16
    public Int16 get_pnevm1 ()
    { return (Int16) m_mem.getMUInt16(634); }

    public void set_pnevm1 (Int16 val)
    { m_mem.setMUInt16(634, (UInt16) val); }

// пневм2,   Int, %MW636   reg = M  width = UInt16
    public Int16 get_pnevm2 ()
    { return (Int16) m_mem.getMUInt16(636); }

    public void set_pnevm2 (Int16 val)
    { m_mem.setMUInt16(636, (UInt16) val); }

// пневм3,   Int, %MW638   reg = M  width = UInt16
    public Int16 get_pnevm3 ()
    { return (Int16) m_mem.getMUInt16(638); }

    public void set_pnevm3 (Int16 val)
    { m_mem.setMUInt16(638, (UInt16) val); }

// пневм4,   Int, %MW640   reg = M  width = UInt16
    public Int16 get_pnevm4 ()
    { return (Int16) m_mem.getMUInt16(640); }

    public void set_pnevm4 (Int16 val)
    { m_mem.setMUInt16(640, (UInt16) val); }

// линейка,   Real, %MD642   reg = M  width = UInt32
    public float get_linejka ()
    { return (float) m_mem.getMFloat(642); }

    public void set_linejka (float val)
    { m_mem.setMFloat(642, (float) val); }

// толщина,   Real, %MD646   reg = M  width = UInt32
    public float get_tolshhina ()
    { return (float) m_mem.getMFloat(646); }

    public void set_tolshhina (float val)
    { m_mem.setMFloat(646, (float) val); }

// ТЭН стола тек мощн,   Real, %MD650   reg = M  width = UInt32
    public float get_tjen_stola_tek_moshhn ()
    { return (float) m_mem.getMFloat(650); }

    public void set_tjen_stola_tek_moshhn (float val)
    { m_mem.setMFloat(650, (float) val); }

// тест1,   DInt, %MD654   reg = M  width = UInt32
    public Int32 get_test1 ()
    { return (Int32) m_mem.getMUInt32(654); }

    public void set_test1 (Int32 val)
    { m_mem.setMUInt32(654, (UInt32) val); }

// тест2,   DInt, %MD658   reg = M  width = UInt32
    public Int32 get_test2 ()
    { return (Int32) m_mem.getMUInt32(658); }

    public void set_test2 (Int32 val)
    { m_mem.setMUInt32(658, (UInt32) val); }

// ГА Po1,   Real, %MD662   reg = M  width = UInt32
    public float get_ga_po1 ()
    { return (float) m_mem.getMFloat(662); }

    public void set_ga_po1 (float val)
    { m_mem.setMFloat(662, (float) val); }

// ГА Po2,   Real, %MD666   reg = M  width = UInt32
    public float get_ga_po2 ()
    { return (float) m_mem.getMFloat(666); }

    public void set_ga_po2 (float val)
    { m_mem.setMFloat(666, (float) val); }

// ГА Po3,   Real, %MD670   reg = M  width = UInt32
    public float get_ga_po3 ()
    { return (float) m_mem.getMFloat(670); }

    public void set_ga_po3 (float val)
    { m_mem.setMFloat(670, (float) val); }

// ГА Ph2,   Real, %MD674   reg = M  width = UInt32
    public float get_ga_ph2 ()
    { return (float) m_mem.getMFloat(674); }

    public void set_ga_ph2 (float val)
    { m_mem.setMFloat(674, (float) val); }

// ГА E1,   Real, %MD682   reg = M  width = UInt32
    public float get_ga_e1 ()
    { return (float) m_mem.getMFloat(682); }

    public void set_ga_e1 (float val)
    { m_mem.setMFloat(682, (float) val); }

// ГА E2,   Real, %MD686   reg = M  width = UInt32
    public float get_ga_e2 ()
    { return (float) m_mem.getMFloat(686); }

    public void set_ga_e2 (float val)
    { m_mem.setMFloat(686, (float) val); }

// ГА E3,   Real, %MD690   reg = M  width = UInt32
    public float get_ga_e3 ()
    { return (float) m_mem.getMFloat(690); }

    public void set_ga_e3 (float val)
    { m_mem.setMFloat(690, (float) val); }

// ГА E4,   Real, %MD694   reg = M  width = UInt32
    public float get_ga_e4 ()
    { return (float) m_mem.getMFloat(694); }

    public void set_ga_e4 (float val)
    { m_mem.setMFloat(694, (float) val); }

// ГА I_IVG1,   Real, %MD698   reg = M  width = UInt32
    public float get_ga_i_ivg1 ()
    { return (float) m_mem.getMFloat(698); }

    public void set_ga_i_ivg1 (float val)
    { m_mem.setMFloat(698, (float) val); }

// ГА I_IVG2,   Real, %MD702   reg = M  width = UInt32
    public float get_ga_i_ivg2 ()
    { return (float) m_mem.getMFloat(702); }

    public void set_ga_i_ivg2 (float val)
    { m_mem.setMFloat(702, (float) val); }

// ГА T1,   Real, %MD706   reg = M  width = UInt32
    public float get_ga_t1 ()
    { return (float) m_mem.getMFloat(706); }

    public void set_ga_t1 (float val)
    { m_mem.setMFloat(706, (float) val); }

// ГА T2,   Real, %MD710   reg = M  width = UInt32
    public float get_ga_t2 ()
    { return (float) m_mem.getMFloat(710); }

    public void set_ga_t2 (float val)
    { m_mem.setMFloat(710, (float) val); }

// ГА T3,   Real, %MD714   reg = M  width = UInt32
    public float get_ga_t3 ()
    { return (float) m_mem.getMFloat(714); }

    public void set_ga_t3 (float val)
    { m_mem.setMFloat(714, (float) val); }

// ГА T4,   Real, %MD718   reg = M  width = UInt32
    public float get_ga_t4 ()
    { return (float) m_mem.getMFloat(718); }

    public void set_ga_t4 (float val)
    { m_mem.setMFloat(718, (float) val); }

// ГА Tros,   Real, %MD722   reg = M  width = UInt32
    public float get_ga_tros ()
    { return (float) m_mem.getMFloat(722); }

    public void set_ga_tros (float val)
    { m_mem.setMFloat(722, (float) val); }

// ГА Tivg,   Real, %MD726   reg = M  width = UInt32
    public float get_ga_tivg ()
    { return (float) m_mem.getMFloat(726); }

    public void set_ga_tivg (float val)
    { m_mem.setMFloat(726, (float) val); }

// ГА Ph2o,   Real, %MD730   reg = M  width = UInt32
    public float get_ga_ph2o ()
    { return (float) m_mem.getMFloat(730); }

    public void set_ga_ph2o (float val)
    { m_mem.setMFloat(730, (float) val); }

// кар тек поз,   Real, %MD734   reg = M  width = UInt32
    public float get_kar_tek_poz ()
    { return (float) m_mem.getMFloat(734); }

    public void set_kar_tek_poz (float val)
    { m_mem.setMFloat(734, (float) val); }

// стол тек поз,   Real, %MD738   reg = M  width = UInt32
    public float get_stol_tek_poz ()
    { return (float) m_mem.getMFloat(738); }

    public void set_stol_tek_poz (float val)
    { m_mem.setMFloat(738, (float) val); }

// ТЭН (1-3) тек мощн,   Real, %MD678   reg = M  width = UInt32
    public float get_tjen_1_3_tek_moshhn ()
    { return (float) m_mem.getMFloat(678); }

    public void set_tjen_1_3_tek_moshhn (float val)
    { m_mem.setMFloat(678, (float) val); }

// ТЭН (4-6) тек мощн,   Real, %MD742   reg = M  width = UInt32
    public float get_tjen_4_6_tek_moshhn ()
    { return (float) m_mem.getMFloat(742); }

    public void set_tjen_4_6_tek_moshhn (float val)
    { m_mem.setMFloat(742, (float) val); }

// охл скан,   Int, %MW746   reg = M  width = UInt16
    public Int16 get_ohl_skan ()
    { return (Int16) m_mem.getMUInt16(746); }

    public void set_ohl_skan (Int16 val)
    { m_mem.setMUInt16(746, (UInt16) val); }

// счёт слоёв,   DInt, %MD748   reg = M  width = UInt32
    public Int32 get_schjot_slojov ()
    { return (Int32) m_mem.getMUInt32(748); }

    public void set_schjot_slojov (Int32 val)
    { m_mem.setMUInt32(748, (UInt32) val); }

// ток ш3,   Real, %MD752   reg = M  width = UInt32
    public float get_tok_sh3 ()
    { return (float) m_mem.getMFloat(752); }

    public void set_tok_sh3 (float val)
    { m_mem.setMFloat(752, (float) val); }

// ост слоёв,   Int, %MW756   reg = M  width = UInt16
    public Int16 get_ost_slojov ()
    { return (Int16) m_mem.getMUInt16(756); }

    public void set_ost_slojov (Int16 val)
    { m_mem.setMUInt16(756, (UInt16) val); }

// ост слоёв для дозатора,   Int, %MW758   reg = M  width = UInt16
    public Int16 get_ost_slojov_dlya_dozatora ()
    { return (Int16) m_mem.getMUInt16(758); }

    public void set_ost_slojov_dlya_dozatora (Int16 val)
    { m_mem.setMUInt16(758, (UInt16) val); }

// инкремент,   Int, %MW760   reg = M  width = UInt16
    public Int16 get_inkrement ()
    { return (Int16) m_mem.getMUInt16(760); }

    public void set_inkrement (Int16 val)
    { m_mem.setMUInt16(760, (UInt16) val); }

// декремент,   Int, %MW764   reg = M  width = UInt16
    public Int16 get_dekrement ()
    { return (Int16) m_mem.getMUInt16(764); }

    public void set_dekrement (Int16 val)
    { m_mem.setMUInt16(764, (UInt16) val); }

// номер выхода,   Int, %MW766   reg = M  width = UInt16
    public Int16 get_nomer_vyhoda ()
    { return (Int16) m_mem.getMUInt16(766); }

    public void set_nomer_vyhoda (Int16 val)
    { m_mem.setMUInt16(766, (UInt16) val); }

// real,   Real, %MD768   reg = M  width = UInt32
    public float get_real ()
    { return (float) m_mem.getMFloat(768); }

    public void set_real (float val)
    { m_mem.setMFloat(768, (float) val); }

// dint,   DInt, %MD772   reg = M  width = UInt32
    public Int32 get_dint ()
    { return (Int32) m_mem.getMUInt32(772); }

    public void set_dint (Int32 val)
    { m_mem.setMUInt32(772, (UInt32) val); }

// bool,   Bool, %M776.0   reg = M  width = Bit
    public bool get_bool ()
    { return (bool) m_mem.getMBit(776, 0); }

    public void set_bool (bool val)
    { m_mem.setMBit(776, 0, (bool) val); }

//-----------------------------------------------------------------------------
//tags/com.xml
//-----------------------------------------------------------------------------
// ком кл63-1 откр,   Bool, %M517.0   reg = M  width = Bit
    public bool get_kom_kl63_1_otkr ()
    { return (bool) m_mem.getMBit(517, 0); }

    public void set_kom_kl63_1_otkr (bool val)
    { m_mem.setMBit(517, 0, (bool) val); }

// ком кл63-1 закр,   Bool, %M517.1   reg = M  width = Bit
    public bool get_kom_kl63_1_zakr ()
    { return (bool) m_mem.getMBit(517, 1); }

    public void set_kom_kl63_1_zakr (bool val)
    { m_mem.setMBit(517, 1, (bool) val); }

// ком кл63-2 откр,   Bool, %M517.2   reg = M  width = Bit
    public bool get_kom_kl63_2_otkr ()
    { return (bool) m_mem.getMBit(517, 2); }

    public void set_kom_kl63_2_otkr (bool val)
    { m_mem.setMBit(517, 2, (bool) val); }

// ком кл63-2 закр,   Bool, %M517.3   reg = M  width = Bit
    public bool get_kom_kl63_2_zakr ()
    { return (bool) m_mem.getMBit(517, 3); }

    public void set_kom_kl63_2_zakr (bool val)
    { m_mem.setMBit(517, 3, (bool) val); }

// ком кл100-3 откр,   Bool, %M517.4   reg = M  width = Bit
    public bool get_kom_kl100_3_otkr ()
    { return (bool) m_mem.getMBit(517, 4); }

    public void set_kom_kl100_3_otkr (bool val)
    { m_mem.setMBit(517, 4, (bool) val); }

// ком кл100-3 закр,   Bool, %M517.5   reg = M  width = Bit
    public bool get_kom_kl100_3_zakr ()
    { return (bool) m_mem.getMBit(517, 5); }

    public void set_kom_kl100_3_zakr (bool val)
    { m_mem.setMBit(517, 5, (bool) val); }

// ком замок шериф,   Bool, %M517.6   reg = M  width = Bit
    public bool get_kom_zamok_sherif ()
    { return (bool) m_mem.getMBit(517, 6); }

    public void set_kom_zamok_sherif (bool val)
    { m_mem.setMBit(517, 6, (bool) val); }

// ком С4 выкат,   Bool, %M517.7   reg = M  width = Bit
    public bool get_kom_s4_vykat ()
    { return (bool) m_mem.getMBit(517, 7); }

    public void set_kom_s4_vykat (bool val)
    { m_mem.setMBit(517, 7, (bool) val); }

// ком С3 закат,   Bool, %M518.0   reg = M  width = Bit
    public bool get_kom_s3_zakat ()
    { return (bool) m_mem.getMBit(518, 0); }

    public void set_kom_s3_zakat (bool val)
    { m_mem.setMBit(518, 0, (bool) val); }

// ком С2 опускание,   Bool, %M518.1   reg = M  width = Bit
    public bool get_kom_s2_opuskanie ()
    { return (bool) m_mem.getMBit(518, 1); }

    public void set_kom_s2_opuskanie (bool val)
    { m_mem.setMBit(518, 1, (bool) val); }

// ком С1 подъём,   Bool, %M518.2   reg = M  width = Bit
    public bool get_kom_s1_pod_jom ()
    { return (bool) m_mem.getMBit(518, 2); }

    public void set_kom_s1_pod_jom (bool val)
    { m_mem.setMBit(518, 2, (bool) val); }

// ком стол абс,   Bool, %M518.4   reg = M  width = Bit
    public bool get_kom_stol_abs ()
    { return (bool) m_mem.getMBit(518, 4); }

    public void set_kom_stol_abs (bool val)
    { m_mem.setMBit(518, 4, (bool) val); }

// ком ТП пуск,   Bool, %M518.6   reg = M  width = Bit
    public bool get_kom_tp_pusk ()
    { return (bool) m_mem.getMBit(518, 6); }

    public void set_kom_tp_pusk (bool val)
    { m_mem.setMBit(518, 6, (bool) val); }

// ком ТП прер,   Bool, %M518.7   reg = M  width = Bit
    public bool get_kom_tp_prer ()
    { return (bool) m_mem.getMBit(518, 7); }

    public void set_kom_tp_prer (bool val)
    { m_mem.setMBit(518, 7, (bool) val); }

// ком кар абс,   Bool, %M519.0   reg = M  width = Bit
    public bool get_kom_kar_abs ()
    { return (bool) m_mem.getMBit(519, 0); }

    public void set_kom_kar_abs (bool val)
    { m_mem.setMBit(519, 0, (bool) val); }

// ком стол стоп,   Bool, %M519.2   reg = M  width = Bit
    public bool get_kom_stol_stop ()
    { return (bool) m_mem.getMBit(519, 2); }

    public void set_kom_stol_stop (bool val)
    { m_mem.setMBit(519, 2, (bool) val); }

// ком каретка стоп,   Bool, %M519.3   reg = M  width = Bit
    public bool get_kom_karetka_stop ()
    { return (bool) m_mem.getMBit(519, 3); }

    public void set_kom_karetka_stop (bool val)
    { m_mem.setMBit(519, 3, (bool) val); }

// ком ш1 вперёд,   Bool, %M519.4   reg = M  width = Bit
    public bool get_kom_sh1_vperjod ()
    { return (bool) m_mem.getMBit(519, 4); }

    public void set_kom_sh1_vperjod (bool val)
    { m_mem.setMBit(519, 4, (bool) val); }

// ком ш1 назад,   Bool, %M519.5   reg = M  width = Bit
    public bool get_kom_sh1_nazad ()
    { return (bool) m_mem.getMBit(519, 5); }

    public void set_kom_sh1_nazad (bool val)
    { m_mem.setMBit(519, 5, (bool) val); }

// ком ш2 вперёд,   Bool, %M519.6   reg = M  width = Bit
    public bool get_kom_sh2_vperjod ()
    { return (bool) m_mem.getMBit(519, 6); }

    public void set_kom_sh2_vperjod (bool val)
    { m_mem.setMBit(519, 6, (bool) val); }

// ком ш2 назад,   Bool, %M519.7   reg = M  width = Bit
    public bool get_kom_sh2_nazad ()
    { return (bool) m_mem.getMBit(519, 7); }

    public void set_kom_sh2_nazad (bool val)
    { m_mem.setMBit(519, 7, (bool) val); }

// ком ш3 вперёд,   Bool, %M520.0   reg = M  width = Bit
    public bool get_kom_sh3_vperjod ()
    { return (bool) m_mem.getMBit(520, 0); }

    public void set_kom_sh3_vperjod (bool val)
    { m_mem.setMBit(520, 0, (bool) val); }

// ком ш3 назад,   Bool, %M520.1   reg = M  width = Bit
    public bool get_kom_sh3_nazad ()
    { return (bool) m_mem.getMBit(520, 1); }

    public void set_kom_sh3_nazad (bool val)
    { m_mem.setMBit(520, 1, (bool) val); }

// ком ш1 стоп,   Bool, %M520.2   reg = M  width = Bit
    public bool get_kom_sh1_stop ()
    { return (bool) m_mem.getMBit(520, 2); }

    public void set_kom_sh1_stop (bool val)
    { m_mem.setMBit(520, 2, (bool) val); }

// ком ш2 стоп,   Bool, %M520.3   reg = M  width = Bit
    public bool get_kom_sh2_stop ()
    { return (bool) m_mem.getMBit(520, 3); }

    public void set_kom_sh2_stop (bool val)
    { m_mem.setMBit(520, 3, (bool) val); }

// ком ш3 стоп,   Bool, %M520.4   reg = M  width = Bit
    public bool get_kom_sh3_stop ()
    { return (bool) m_mem.getMBit(520, 4); }

    public void set_kom_sh3_stop (bool val)
    { m_mem.setMBit(520, 4, (bool) val); }

// ком каретка сброс,   Bool, %M520.5   reg = M  width = Bit
    public bool get_kom_karetka_sbros ()
    { return (bool) m_mem.getMBit(520, 5); }

    public void set_kom_karetka_sbros (bool val)
    { m_mem.setMBit(520, 5, (bool) val); }

// ком стол сброс,   Bool, %M520.6   reg = M  width = Bit
    public bool get_kom_stol_sbros ()
    { return (bool) m_mem.getMBit(520, 6); }

    public void set_kom_stol_sbros (bool val)
    { m_mem.setMBit(520, 6, (bool) val); }

// ком стол уст нуля,   Bool, %M521.0   reg = M  width = Bit
    public bool get_kom_stol_ust_nulya ()
    { return (bool) m_mem.getMBit(521, 0); }

    public void set_kom_stol_ust_nulya (bool val)
    { m_mem.setMBit(521, 0, (bool) val); }

// ком стол отн пуск вниз,   Bool, %M521.2   reg = M  width = Bit
    public bool get_kom_stol_otn_pusk_vniz ()
    { return (bool) m_mem.getMBit(521, 2); }

    public void set_kom_stol_otn_pusk_vniz (bool val)
    { m_mem.setMBit(521, 2, (bool) val); }

// ком стол отн пуск вверх,   Bool, %M521.3   reg = M  width = Bit
    public bool get_kom_stol_otn_pusk_vverh ()
    { return (bool) m_mem.getMBit(521, 3); }

    public void set_kom_stol_otn_pusk_vverh (bool val)
    { m_mem.setMBit(521, 3, (bool) val); }

// ком слой,   Bool, %M521.5   reg = M  width = Bit
    public bool get_kom_sloj ()
    { return (bool) m_mem.getMBit(521, 5); }

    public void set_kom_sloj (bool val)
    { m_mem.setMBit(521, 5, (bool) val); }

// ком прер,   Bool, %M521.7   reg = M  width = Bit
    public bool get_kom_prer ()
    { return (bool) m_mem.getMBit(521, 7); }

    public void set_kom_prer (bool val)
    { m_mem.setMBit(521, 7, (bool) val); }

// ком кар отн влево,   Bool, %M522.2   reg = M  width = Bit
    public bool get_kom_kar_otn_vlevo ()
    { return (bool) m_mem.getMBit(522, 2); }

    public void set_kom_kar_otn_vlevo (bool val)
    { m_mem.setMBit(522, 2, (bool) val); }

// ком кар отн вправо,   Bool, %M522.3   reg = M  width = Bit
    public bool get_kom_kar_otn_vpravo ()
    { return (bool) m_mem.getMBit(522, 3); }

    public void set_kom_kar_otn_vpravo (bool val)
    { m_mem.setMBit(522, 3, (bool) val); }

// ком кар поиск нуля,   Bool, %M522.4   reg = M  width = Bit
    public bool get_kom_kar_poisk_nulya ()
    { return (bool) m_mem.getMBit(522, 4); }

    public void set_kom_kar_poisk_nulya (bool val)
    { m_mem.setMBit(522, 4, (bool) val); }

// ком свет,   Bool, %M522.6   reg = M  width = Bit
    public bool get_kom_svet ()
    { return (bool) m_mem.getMBit(522, 6); }

    public void set_kom_svet (bool val)
    { m_mem.setMBit(522, 6, (bool) val); }

// ком обнулить линейку,   Bool, %M522.7   reg = M  width = Bit
    public bool get_kom_obnulit_linejku ()
    { return (bool) m_mem.getMBit(522, 7); }

    public void set_kom_obnulit_linejku (bool val)
    { m_mem.setMBit(522, 7, (bool) val); }

// ком ш2 реле,   Bool, %M523.0   reg = M  width = Bit
    public bool get_kom_sh2_rele ()
    { return (bool) m_mem.getMBit(523, 0); }

    public void set_kom_sh2_rele (bool val)
    { m_mem.setMBit(523, 0, (bool) val); }

// ком ш1 реле,   Bool, %M523.1   reg = M  width = Bit
    public bool get_kom_sh1_rele ()
    { return (bool) m_mem.getMBit(523, 1); }

    public void set_kom_sh1_rele (bool val)
    { m_mem.setMBit(523, 1, (bool) val); }

// ком прожиг,   Bool, %M523.2   reg = M  width = Bit
    public bool get_kom_prozhig ()
    { return (bool) m_mem.getMBit(523, 2); }

    public void set_kom_prozhig (bool val)
    { m_mem.setMBit(523, 2, (bool) val); }

// ком ТЭН стола,   Bool, %M524.2   reg = M  width = Bit
    public bool get_kom_tjen_stola ()
    { return (bool) m_mem.getMBit(524, 2); }

    public void set_kom_tjen_stola (bool val)
    { m_mem.setMBit(524, 2, (bool) val); }

// ком ТЭН(1-3),   Bool, %M524.3   reg = M  width = Bit
    public bool get_kom_tjen_1_3 ()
    { return (bool) m_mem.getMBit(524, 3); }

    public void set_kom_tjen_1_3 (bool val)
    { m_mem.setMBit(524, 3, (bool) val); }

// ком ТЭН(4-6),   Bool, %M524.4   reg = M  width = Bit
    public bool get_kom_tjen_4_6 ()
    { return (bool) m_mem.getMBit(524, 4); }

    public void set_kom_tjen_4_6 (bool val)
    { m_mem.setMBit(524, 4, (bool) val); }

// ком нул точ,   Bool, %M524.5   reg = M  width = Bit
    public bool get_kom_nul_toch ()
    { return (bool) m_mem.getMBit(524, 5); }

    public void set_kom_nul_toch (bool val)
    { m_mem.setMBit(524, 5, (bool) val); }

// ком стол поиск нуля,   Bool, %M525.7   reg = M  width = Bit
    public bool get_kom_stol_poisk_nulya ()
    { return (bool) m_mem.getMBit(525, 7); }

    public void set_kom_stol_poisk_nulya (bool val)
    { m_mem.setMBit(525, 7, (bool) val); }

// ком процесс,   Bool, %M521.4   reg = M  width = Bit
    public bool get_kom_process ()
    { return (bool) m_mem.getMBit(521, 4); }

    public void set_kom_process (bool val)
    { m_mem.setMBit(521, 4, (bool) val); }

// ком проц общ,   Bool, %M526.0   reg = M  width = Bit
    public bool get_kom_proc_obshh ()
    { return (bool) m_mem.getMBit(526, 0); }

    public void set_kom_proc_obshh (bool val)
    { m_mem.setMBit(526, 0, (bool) val); }

// ком пересчёт,   Bool, %M526.1   reg = M  width = Bit
    public bool get_kom_pereschjot ()
    { return (bool) m_mem.getMBit(526, 1); }

    public void set_kom_pereschjot (bool val)
    { m_mem.setMBit(526, 1, (bool) val); }

// ком пит скан,   Bool, %M526.2   reg = M  width = Bit
    public bool get_kom_pit_skan ()
    { return (bool) m_mem.getMBit(526, 2); }

    public void set_kom_pit_skan (bool val)
    { m_mem.setMBit(526, 2, (bool) val); }

// ком гот лазер,   Bool, %M526.3   reg = M  width = Bit
    public bool get_kom_got_lazer ()
    { return (bool) m_mem.getMBit(526, 3); }

    public void set_kom_got_lazer (bool val)
    { m_mem.setMBit(526, 3, (bool) val); }

// ком сброс гот,   Bool, %M526.4   reg = M  width = Bit
    public bool get_kom_sbros_got ()
    { return (bool) m_mem.getMBit(526, 4); }

    public void set_kom_sbros_got (bool val)
    { m_mem.setMBit(526, 4, (bool) val); }

// ком слой сброс счётчика,   Bool, %M526.5   reg = M  width = Bit
    public bool get_kom_sloj_sbros_schjotchika ()
    { return (bool) m_mem.getMBit(526, 5); }

    public void set_kom_sloj_sbros_schjotchika (bool val)
    { m_mem.setMBit(526, 5, (bool) val); }

// ком пауза,   Bool, %M526.7   reg = M  width = Bit
    public bool get_kom_pauza ()
    { return (bool) m_mem.getMBit(526, 7); }

    public void set_kom_pauza (bool val)
    { m_mem.setMBit(526, 7, (bool) val); }

// ком раб до паузы,   Bool, %M527.0   reg = M  width = Bit
    public bool get_kom_rab_do_pauzy ()
    { return (bool) m_mem.getMBit(527, 0); }

    public void set_kom_rab_do_pauzy (bool val)
    { m_mem.setMBit(527, 0, (bool) val); }

// ком дозатор автомат,   Bool, %M527.1   reg = M  width = Bit
    public bool get_kom_dozator_avtomat ()
    { return (bool) m_mem.getMBit(527, 1); }

    public void set_kom_dozator_avtomat (bool val)
    { m_mem.setMBit(527, 1, (bool) val); }

//-----------------------------------------------------------------------------
//tags/const.xml
//-----------------------------------------------------------------------------
// уст каретка скор вправо,   Real, %MD112   reg = M  width = UInt32
    public float get_ust_karetka_skor_vpravo ()
    { return (float) m_mem.getMFloat(112); }

    public void set_ust_karetka_skor_vpravo (float val)
    { m_mem.setMFloat(112, (float) val); }

// уст каретка позиция,   Real, %MD124   reg = M  width = UInt32
    public float get_ust_karetka_poziciya ()
    { return (float) m_mem.getMFloat(124); }

    public void set_ust_karetka_poziciya (float val)
    { m_mem.setMFloat(124, (float) val); }

// уст каретка расст,   Real, %MD128   reg = M  width = UInt32
    public float get_ust_karetka_rasst ()
    { return (float) m_mem.getMFloat(128); }

    public void set_ust_karetka_rasst (float val)
    { m_mem.setMFloat(128, (float) val); }

// уст стол позиция,   Real, %MD136   reg = M  width = UInt32
    public float get_ust_stol_poziciya ()
    { return (float) m_mem.getMFloat(136); }

    public void set_ust_stol_poziciya (float val)
    { m_mem.setMFloat(136, (float) val); }

// уст стол скор вверх,   Real, %MD108   reg = M  width = UInt32
    public float get_ust_stol_skor_vverh ()
    { return (float) m_mem.getMFloat(108); }

    public void set_ust_stol_skor_vverh (float val)
    { m_mem.setMFloat(108, (float) val); }

// уст каретка скор влево,   Real, %MD116   reg = M  width = UInt32
    public float get_ust_karetka_skor_vlevo ()
    { return (float) m_mem.getMFloat(116); }

    public void set_ust_karetka_skor_vlevo (float val)
    { m_mem.setMFloat(116, (float) val); }

// уст стол отн расст,   Real, %MD148   reg = M  width = UInt32
    public float get_ust_stol_otn_rasst ()
    { return (float) m_mem.getMFloat(148); }

    public void set_ust_stol_otn_rasst (float val)
    { m_mem.setMFloat(148, (float) val); }

// уст врем вращ на месте,   Real, %MD152   reg = M  width = UInt32
    public float get_ust_vrem_vrashh_na_meste ()
    { return (float) m_mem.getMFloat(152); }

    public void set_ust_vrem_vrashh_na_meste (float val)
    { m_mem.setMFloat(152, (float) val); }

// уст кар поз откл ш3,   Real, %MD208   reg = M  width = UInt32
    public float get_ust_kar_poz_otkl_sh3 ()
    { return (float) m_mem.getMFloat(208); }

    public void set_ust_kar_poz_otkl_sh3 (float val)
    { m_mem.setMFloat(208, (float) val); }

// уст врем раб ш1,   Real, %MD224   reg = M  width = UInt32
    public float get_ust_vrem_rab_sh1 ()
    { return (float) m_mem.getMFloat(224); }

    public void set_ust_vrem_rab_sh1 (float val)
    { m_mem.setMFloat(224, (float) val); }

// уст врем раб ш2,   Real, %MD228   reg = M  width = UInt32
    public float get_ust_vrem_rab_sh2 ()
    { return (float) m_mem.getMFloat(228); }

    public void set_ust_vrem_rab_sh2 (float val)
    { m_mem.setMFloat(228, (float) val); }

// уст темп стола,   Real, %MD232   reg = M  width = UInt32
    public float get_ust_temp_stola ()
    { return (float) m_mem.getMFloat(232); }

    public void set_ust_temp_stola (float val)
    { m_mem.setMFloat(232, (float) val); }

// уст темп ТЭН(1-3),   Real, %MD236   reg = M  width = UInt32
    public float get_ust_temp_tjen_1_3 ()
    { return (float) m_mem.getMFloat(236); }

    public void set_ust_temp_tjen_1_3 (float val)
    { m_mem.setMFloat(236, (float) val); }

// уст темп ТЭН(4-6),   Real, %MD240   reg = M  width = UInt32
    public float get_ust_temp_tjen_4_6 ()
    { return (float) m_mem.getMFloat(240); }

    public void set_ust_temp_tjen_4_6 (float val)
    { m_mem.setMFloat(240, (float) val); }

// уст слой кар поз слева,   Real, %MD132   reg = M  width = UInt32
    public float get_ust_sloj_kar_poz_sleva ()
    { return (float) m_mem.getMFloat(132); }

    public void set_ust_sloj_kar_poz_sleva (float val)
    { m_mem.setMFloat(132, (float) val); }

// уст слой кар поз справа,   Real, %MD144   reg = M  width = UInt32
    public float get_ust_sloj_kar_poz_sprava ()
    { return (float) m_mem.getMFloat(144); }

    public void set_ust_sloj_kar_poz_sprava (float val)
    { m_mem.setMFloat(144, (float) val); }

// уст стол поз порш от нуля,   Real, %MD168   reg = M  width = UInt32
    public float get_ust_stol_poz_porsh_ot_nulya ()
    { return (float) m_mem.getMFloat(168); }

    public void set_ust_stol_poz_porsh_ot_nulya (float val)
    { m_mem.setMFloat(168, (float) val); }

// уст стол толщ плиты,   Real, %MD172   reg = M  width = UInt32
    public float get_ust_stol_tolshh_plity ()
    { return (float) m_mem.getMFloat(172); }

    public void set_ust_stol_tolshh_plity (float val)
    { m_mem.setMFloat(172, (float) val); }

// уст стол отн внут,   Real, %MD176   reg = M  width = UInt32
    public float get_ust_stol_otn_vnut ()
    { return (float) m_mem.getMFloat(176); }

    public void set_ust_stol_otn_vnut (float val)
    { m_mem.setMFloat(176, (float) val); }

// уст толщ слоя,   Real, %MD180   reg = M  width = UInt32
    public float get_ust_tolshh_sloya ()
    { return (float) m_mem.getMFloat(180); }

    public void set_ust_tolshh_sloya (float val)
    { m_mem.setMFloat(180, (float) val); }

// ТЭН стола_Gain,   Real, %MD184   reg = M  width = UInt32
    public float get_tjen_stola_gain ()
    { return (float) m_mem.getMFloat(184); }

    public void set_tjen_stola_gain (float val)
    { m_mem.setMFloat(184, (float) val); }

// ТЭН стола_PWeighting,   Real, %MD188   reg = M  width = UInt32
    public float get_tjen_stola_pweighting ()
    { return (float) m_mem.getMFloat(188); }

    public void set_tjen_stola_pweighting (float val)
    { m_mem.setMFloat(188, (float) val); }

// ТЭН стола_Ti,   Real, %MD192   reg = M  width = UInt32
    public float get_tjen_stola_ti ()
    { return (float) m_mem.getMFloat(192); }

    public void set_tjen_stola_ti (float val)
    { m_mem.setMFloat(192, (float) val); }

// ТЭН стола_Td,   Real, %MD196   reg = M  width = UInt32
    public float get_tjen_stola_td ()
    { return (float) m_mem.getMFloat(196); }

    public void set_tjen_stola_td (float val)
    { m_mem.setMFloat(196, (float) val); }

// ТЭН стола_DWeighting,   Real, %MD200   reg = M  width = UInt32
    public float get_tjen_stola_dweighting ()
    { return (float) m_mem.getMFloat(200); }

    public void set_tjen_stola_dweighting (float val)
    { m_mem.setMFloat(200, (float) val); }

// ТЭН (1-3)_Gain,   Real, %MD212   reg = M  width = UInt32
    public float get_tjen_1_3_gain ()
    { return (float) m_mem.getMFloat(212); }

    public void set_tjen_1_3_gain (float val)
    { m_mem.setMFloat(212, (float) val); }

// ТЭН (1-3)_PWeighting,   Real, %MD220   reg = M  width = UInt32
    public float get_tjen_1_3_pweighting ()
    { return (float) m_mem.getMFloat(220); }

    public void set_tjen_1_3_pweighting (float val)
    { m_mem.setMFloat(220, (float) val); }

// ТЭН (1-3)_Ti,   Real, %MD244   reg = M  width = UInt32
    public float get_tjen_1_3_ti ()
    { return (float) m_mem.getMFloat(244); }

    public void set_tjen_1_3_ti (float val)
    { m_mem.setMFloat(244, (float) val); }

// ТЭН (1-3)_Td,   Real, %MD248   reg = M  width = UInt32
    public float get_tjen_1_3_td ()
    { return (float) m_mem.getMFloat(248); }

    public void set_tjen_1_3_td (float val)
    { m_mem.setMFloat(248, (float) val); }

// ТЭН (1-3)_DWeighting,   Real, %MD252   reg = M  width = UInt32
    public float get_tjen_1_3_dweighting ()
    { return (float) m_mem.getMFloat(252); }

    public void set_tjen_1_3_dweighting (float val)
    { m_mem.setMFloat(252, (float) val); }

// ТЭН (4-6)_Gain,   Real, %MD256   reg = M  width = UInt32
    public float get_tjen_4_6_gain ()
    { return (float) m_mem.getMFloat(256); }

    public void set_tjen_4_6_gain (float val)
    { m_mem.setMFloat(256, (float) val); }

// ТЭН (4-6)_PWeighting,   Real, %MD260   reg = M  width = UInt32
    public float get_tjen_4_6_pweighting ()
    { return (float) m_mem.getMFloat(260); }

    public void set_tjen_4_6_pweighting (float val)
    { m_mem.setMFloat(260, (float) val); }

// ТЭН (4-6)_Ti,   Real, %MD264   reg = M  width = UInt32
    public float get_tjen_4_6_ti ()
    { return (float) m_mem.getMFloat(264); }

    public void set_tjen_4_6_ti (float val)
    { m_mem.setMFloat(264, (float) val); }

// ТЭН (4-6)_Td,   Real, %MD268   reg = M  width = UInt32
    public float get_tjen_4_6_td ()
    { return (float) m_mem.getMFloat(268); }

    public void set_tjen_4_6_td (float val)
    { m_mem.setMFloat(268, (float) val); }

// ТЭН (4-6)_DWeighting,   Real, %MD272   reg = M  width = UInt32
    public float get_tjen_4_6_dweighting ()
    { return (float) m_mem.getMFloat(272); }

    public void set_tjen_4_6_dweighting (float val)
    { m_mem.setMFloat(272, (float) val); }

// уст стол отн расст авто,   Real, %MD204   reg = M  width = UInt32
    public float get_ust_stol_otn_rasst_avto ()
    { return (float) m_mem.getMFloat(204); }

    public void set_ust_stol_otn_rasst_avto (float val)
    { m_mem.setMFloat(204, (float) val); }

// уст время ТЭН стола,   DInt, %MD156   reg = M  width = UInt32
    public Int32 get_ust_vremya_tjen_stola ()
    { return (Int32) m_mem.getMUInt32(156); }

    public void set_ust_vremya_tjen_stola (Int32 val)
    { m_mem.setMUInt32(156, (UInt32) val); }

// уст время ТЭН 1-3,   DInt, %MD160   reg = M  width = UInt32
    public Int32 get_ust_vremya_tjen_1_3 ()
    { return (Int32) m_mem.getMUInt32(160); }

    public void set_ust_vremya_tjen_1_3 (Int32 val)
    { m_mem.setMUInt32(160, (UInt32) val); }

// уст время ТЭН 4-6,   DInt, %MD164   reg = M  width = UInt32
    public Int32 get_ust_vremya_tjen_4_6 ()
    { return (Int32) m_mem.getMUInt32(164); }

    public void set_ust_vremya_tjen_4_6 (Int32 val)
    { m_mem.setMUInt32(164, (UInt32) val); }

// ТЭН стола макс мощн,   Real, %MD276   reg = M  width = UInt32
    public float get_tjen_stola_max_moshhn ()
    { return (float) m_mem.getMFloat(276); }

    public void set_tjen_stola_max_moshhn (float val)
    { m_mem.setMFloat(276, (float) val); }

// ТЭН (1-3) макс мощн,   Real, %MD280   reg = M  width = UInt32
    public float get_tjen_1_3_max_moshhn ()
    { return (float) m_mem.getMFloat(280); }

    public void set_tjen_1_3_max_moshhn (float val)
    { m_mem.setMFloat(280, (float) val); }

// ТЭН (4-6) макс мощн,   Real, %MD284   reg = M  width = UInt32
    public float get_tjen_4_6_max_moshhn ()
    { return (float) m_mem.getMFloat(284); }

    public void set_tjen_4_6_max_moshhn (float val)
    { m_mem.setMFloat(284, (float) val); }

// уст врем раб ш3,   Real, %MD288   reg = M  width = UInt32
    public float get_ust_vrem_rab_sh3 ()
    { return (float) m_mem.getMFloat(288); }

    public void set_ust_vrem_rab_sh3 (float val)
    { m_mem.setMFloat(288, (float) val); }

// уст кол слоёв,   Int, %MW292   reg = M  width = UInt16
    public Int16 get_ust_kol_slojov ()
    { return (Int16) m_mem.getMUInt16(292); }

    public void set_ust_kol_slojov (Int16 val)
    { m_mem.setMUInt16(292, (UInt16) val); }

// уст кол слоёв для дозатора,   Int, %MW294   reg = M  width = UInt16
    public Int16 get_ust_kol_slojov_dlya_dozatora ()
    { return (Int16) m_mem.getMUInt16(294); }

    public void set_ust_kol_slojov_dlya_dozatora (Int16 val)
    { m_mem.setMUInt16(294, (UInt16) val); }

//-----------------------------------------------------------------------------
//tags/dm.xml
//-----------------------------------------------------------------------------
// верхн ур порошка,   Bool, %M510.1   reg = M  width = Bit
    public bool get_verhn_ur_poroshka ()
    { return (bool) m_mem.getMBit(510, 1); }

    public void set_verhn_ur_poroshka (bool val)
    { m_mem.setMBit(510, 1, (bool) val); }

// нижн ур порошка,   Bool, %M510.2   reg = M  width = Bit
    public bool get_nizhn_ur_poroshka ()
    { return (bool) m_mem.getMBit(510, 2); }

    public void set_nizhn_ur_poroshka (bool val)
    { m_mem.setMBit(510, 2, (bool) val); }

// выс темп сканатор,   Bool, %M510.3   reg = M  width = Bit
    public bool get_vys_temp_skanator ()
    { return (bool) m_mem.getMBit(510, 3); }

    public void set_vys_temp_skanator (bool val)
    { m_mem.setMBit(510, 3, (bool) val); }

// прот сканатор,   Bool, %M510.4   reg = M  width = Bit
    public bool get_prot_skanator ()
    { return (bool) m_mem.getMBit(510, 4); }

    public void set_prot_skanator (bool val)
    { m_mem.setMBit(510, 4, (bool) val); }

// выс темп гол лаз и калиматор,   Bool, %M510.5   reg = M  width = Bit
    public bool get_vys_temp_gol_laz_i_kalimator ()
    { return (bool) m_mem.getMBit(510, 5); }

    public void set_vys_temp_gol_laz_i_kalimator (bool val)
    { m_mem.setMBit(510, 5, (bool) val); }

// прот гол лаз и калиматор,   Bool, %M510.6   reg = M  width = Bit
    public bool get_prot_gol_laz_i_kalimator ()
    { return (bool) m_mem.getMBit(510, 6); }

    public void set_prot_gol_laz_i_kalimator (bool val)
    { m_mem.setMBit(510, 6, (bool) val); }

// кл 100-3 закр,   Bool, %M510.7   reg = M  width = Bit
    public bool get_kl_100_3_zakr ()
    { return (bool) m_mem.getMBit(510, 7); }

    public void set_kl_100_3_zakr (bool val)
    { m_mem.setMBit(510, 7, (bool) val); }

// кл 100-3 откр,   Bool, %M511.0   reg = M  width = Bit
    public bool get_kl_100_3_otkr ()
    { return (bool) m_mem.getMBit(511, 0); }

    public void set_kl_100_3_otkr (bool val)
    { m_mem.setMBit(511, 0, (bool) val); }

// кл 63-2 закр,   Bool, %M511.1   reg = M  width = Bit
    public bool get_kl_63_2_zakr ()
    { return (bool) m_mem.getMBit(511, 1); }

    public void set_kl_63_2_zakr (bool val)
    { m_mem.setMBit(511, 1, (bool) val); }

// кл 63-2 откр,   Bool, %M511.2   reg = M  width = Bit
    public bool get_kl_63_2_otkr ()
    { return (bool) m_mem.getMBit(511, 2); }

    public void set_kl_63_2_otkr (bool val)
    { m_mem.setMBit(511, 2, (bool) val); }

// кл 63-1 закр,   Bool, %M511.3   reg = M  width = Bit
    public bool get_kl_63_1_zakr ()
    { return (bool) m_mem.getMBit(511, 3); }

    public void set_kl_63_1_zakr (bool val)
    { m_mem.setMBit(511, 3, (bool) val); }

// кл 63-1 откр,   Bool, %M511.4   reg = M  width = Bit
    public bool get_kl_63_1_otkr ()
    { return (bool) m_mem.getMBit(511, 4); }

    public void set_kl_63_1_otkr (bool val)
    { m_mem.setMBit(511, 4, (bool) val); }

// хрень от кл63-1,   Bool, %M512.7   reg = M  width = Bit
    public bool get_hren_ot_kl63_1 ()
    { return (bool) m_mem.getMBit(512, 7); }

    public void set_hren_ot_kl63_1 (bool val)
    { m_mem.setMBit(512, 7, (bool) val); }

// хрень от кл63-2,   Bool, %M513.0   reg = M  width = Bit
    public bool get_hren_ot_kl63_2 ()
    { return (bool) m_mem.getMBit(513, 0); }

    public void set_hren_ot_kl63_2 (bool val)
    { m_mem.setMBit(513, 0, (bool) val); }

// крень от кл100-3,   Bool, %M513.1   reg = M  width = Bit
    public bool get_kren_ot_kl100_3 ()
    { return (bool) m_mem.getMBit(513, 1); }

    public void set_kren_ot_kl100_3 (bool val)
    { m_mem.setMBit(513, 1, (bool) val); }

// пит каретки,   Bool, %M513.2   reg = M  width = Bit
    public bool get_pit_karetki ()
    { return (bool) m_mem.getMBit(513, 2); }

    public void set_pit_karetki (bool val)
    { m_mem.setMBit(513, 2, (bool) val); }

// пит стол,   Bool, %M513.3   reg = M  width = Bit
    public bool get_pit_stol ()
    { return (bool) m_mem.getMBit(513, 3); }

    public void set_pit_stol (bool val)
    { m_mem.setMBit(513, 3, (bool) val); }

// пит каретки2,   Bool, %M513.4   reg = M  width = Bit
    public bool get_pit_karetki2 ()
    { return (bool) m_mem.getMBit(513, 4); }

    public void set_pit_karetki2 (bool val)
    { m_mem.setMBit(513, 4, (bool) val); }

// тэн7,   Bool, %M513.5   reg = M  width = Bit
    public bool get_tjen7 ()
    { return (bool) m_mem.getMBit(513, 5); }

    public void set_tjen7 (bool val)
    { m_mem.setMBit(513, 5, (bool) val); }

// тэн8,   Bool, %M513.6   reg = M  width = Bit
    public bool get_tjen8 ()
    { return (bool) m_mem.getMBit(513, 6); }

    public void set_tjen8 (bool val)
    { m_mem.setMBit(513, 6, (bool) val); }

// тэн9,   Bool, %M513.7   reg = M  width = Bit
    public bool get_tjen9 ()
    { return (bool) m_mem.getMBit(513, 7); }

    public void set_tjen9 (bool val)
    { m_mem.setMBit(513, 7, (bool) val); }

// ш1 раб,   Bool, %M514.4   reg = M  width = Bit
    public bool get_sh1_rab ()
    { return (bool) m_mem.getMBit(514, 4); }

    public void set_sh1_rab (bool val)
    { m_mem.setMBit(514, 4, (bool) val); }

// стол раб,   Bool, %M514.5   reg = M  width = Bit
    public bool get_stol_rab ()
    { return (bool) m_mem.getMBit(514, 5); }

    public void set_stol_rab (bool val)
    { m_mem.setMBit(514, 5, (bool) val); }

// ш3 раб,   Bool, %M514.6   reg = M  width = Bit
    public bool get_sh3_rab ()
    { return (bool) m_mem.getMBit(514, 6); }

    public void set_sh3_rab (bool val)
    { m_mem.setMBit(514, 6, (bool) val); }

// каретка ош,   Bool, %M516.0   reg = M  width = Bit
    public bool get_karetka_osh ()
    { return (bool) m_mem.getMBit(516, 0); }

    public void set_karetka_osh (bool val)
    { m_mem.setMBit(516, 0, (bool) val); }

// лазер,   Bool, %M516.1   reg = M  width = Bit
    public bool get_lazer ()
    { return (bool) m_mem.getMBit(516, 1); }

    public void set_lazer (bool val)
    { m_mem.setMBit(516, 1, (bool) val); }

// тп раб,   Bool, %M516.3   reg = M  width = Bit
    public bool get_tp_rab ()
    { return (bool) m_mem.getMBit(516, 3); }

    public void set_tp_rab (bool val)
    { m_mem.setMBit(516, 3, (bool) val); }

// тп зав,   Bool, %M516.4   reg = M  width = Bit
    public bool get_tp_zav ()
    { return (bool) m_mem.getMBit(516, 4); }

    public void set_tp_zav (bool val)
    { m_mem.setMBit(516, 4, (bool) val); }

// каретка слева,   Bool, %M516.2   reg = M  width = Bit
    public bool get_karetka_sleva ()
    { return (bool) m_mem.getMBit(516, 2); }

    public void set_karetka_sleva (bool val)
    { m_mem.setMBit(516, 2, (bool) val); }

// каретка справа,   Bool, %M516.5   reg = M  width = Bit
    public bool get_karetka_sprava ()
    { return (bool) m_mem.getMBit(516, 5); }

    public void set_karetka_sprava (bool val)
    { m_mem.setMBit(516, 5, (bool) val); }

// стол наверху,   Bool, %M516.6   reg = M  width = Bit
    public bool get_stol_naverhu ()
    { return (bool) m_mem.getMBit(516, 6); }

    public void set_stol_naverhu (bool val)
    { m_mem.setMBit(516, 6, (bool) val); }

// стол внизу,   Bool, %M516.7   reg = M  width = Bit
    public bool get_stol_vnizu ()
    { return (bool) m_mem.getMBit(516, 7); }

    public void set_stol_vnizu (bool val)
    { m_mem.setMBit(516, 7, (bool) val); }

// ш2 раб,   Bool, %M515.7   reg = M  width = Bit
    public bool get_sh2_rab ()
    { return (bool) m_mem.getMBit(515, 7); }

    public void set_sh2_rab (bool val)
    { m_mem.setMBit(515, 7, (bool) val); }

// стол ош,   Bool, %M518.3   reg = M  width = Bit
    public bool get_stol_osh ()
    { return (bool) m_mem.getMBit(518, 3); }

    public void set_stol_osh (bool val)
    { m_mem.setMBit(518, 3, (bool) val); }

// шморгалка,   Bool, %M520.7   reg = M  width = Bit
    public bool get_shmorgalka ()
    { return (bool) m_mem.getMBit(520, 7); }

    public void set_shmorgalka (bool val)
    { m_mem.setMBit(520, 7, (bool) val); }

// стол дом зав,   Bool, %M521.1   reg = M  width = Bit
    public bool get_stol_dom_zav ()
    { return (bool) m_mem.getMBit(521, 1); }

    public void set_stol_dom_zav (bool val)
    { m_mem.setMBit(521, 1, (bool) val); }

// блокировка управления,   Bool, %M521.6   reg = M  width = Bit
    public bool get_blokirovka_upravleniya ()
    { return (bool) m_mem.getMBit(521, 6); }

    public void set_blokirovka_upravleniya (bool val)
    { m_mem.setMBit(521, 6, (bool) val); }

// слой раб,   Bool, %M522.0   reg = M  width = Bit
    public bool get_sloj_rab ()
    { return (bool) m_mem.getMBit(522, 0); }

    public void set_sloj_rab (bool val)
    { m_mem.setMBit(522, 0, (bool) val); }

// кар дом гот,   Bool, %M522.1   reg = M  width = Bit
    public bool get_kar_dom_got ()
    { return (bool) m_mem.getMBit(522, 1); }

    public void set_kar_dom_got (bool val)
    { m_mem.setMBit(522, 1, (bool) val); }

// кар на поз,   Bool, %M522.5   reg = M  width = Bit
    public bool get_kar_na_poz ()
    { return (bool) m_mem.getMBit(522, 5); }

    public void set_kar_na_poz (bool val)
    { m_mem.setMBit(522, 5, (bool) val); }

// процесс,   Bool, %M518.5   reg = M  width = Bit
    public bool get_process ()
    { return (bool) m_mem.getMBit(518, 5); }

    public void set_process (bool val)
    { m_mem.setMBit(518, 5, (bool) val); }

// скан ош,   Bool, %M519.1   reg = M  width = Bit
    public bool get_skan_osh ()
    { return (bool) m_mem.getMBit(519, 1); }

    public void set_skan_osh (bool val)
    { m_mem.setMBit(519, 1, (bool) val); }

// скан раб,   Bool, %M523.3   reg = M  width = Bit
    public bool get_skan_rab ()
    { return (bool) m_mem.getMBit(523, 3); }

    public void set_skan_rab (bool val)
    { m_mem.setMBit(523, 3, (bool) val); }

// скан лазинг,   Bool, %M523.4   reg = M  width = Bit
    public bool get_skan_lazing ()
    { return (bool) m_mem.getMBit(523, 4); }

    public void set_skan_lazing (bool val)
    { m_mem.setMBit(523, 4, (bool) val); }

// скан актив,   Bool, %M523.5   reg = M  width = Bit
    public bool get_skan_aktiv ()
    { return (bool) m_mem.getMBit(523, 5); }

    public void set_skan_aktiv (bool val)
    { m_mem.setMBit(523, 5, (bool) val); }

// шморгалка1,   Bool, %M523.6   reg = M  width = Bit
    public bool get_shmorgalka1 ()
    { return (bool) m_mem.getMBit(523, 6); }

    public void set_shmorgalka1 (bool val)
    { m_mem.setMBit(523, 6, (bool) val); }

// шморгалка2,   Bool, %M523.7   reg = M  width = Bit
    public bool get_shmorgalka2 ()
    { return (bool) m_mem.getMBit(523, 7); }

    public void set_shmorgalka2 (bool val)
    { m_mem.setMBit(523, 7, (bool) val); }

// шморгалка3,   Bool, %M524.0   reg = M  width = Bit
    public bool get_shmorgalka3 ()
    { return (bool) m_mem.getMBit(524, 0); }

    public void set_shmorgalka3 (bool val)
    { m_mem.setMBit(524, 0, (bool) val); }

// шморгалка4,   Bool, %M524.1   reg = M  width = Bit
    public bool get_shmorgalka4 ()
    { return (bool) m_mem.getMBit(524, 1); }

    public void set_shmorgalka4 (bool val)
    { m_mem.setMBit(524, 1, (bool) val); }

// охл скан норм,   Bool, %M524.6   reg = M  width = Bit
    public bool get_ohl_skan_norm ()
    { return (bool) m_mem.getMBit(524, 6); }

    public void set_ohl_skan_norm (bool val)
    { m_mem.setMBit(524, 6, (bool) val); }

// модп1,   Bool, %M524.7   reg = M  width = Bit
    public bool get_modp1 ()
    { return (bool) m_mem.getMBit(524, 7); }

    public void set_modp1 (bool val)
    { m_mem.setMBit(524, 7, (bool) val); }

// модп2,   Bool, %M525.0   reg = M  width = Bit
    public bool get_modp2 ()
    { return (bool) m_mem.getMBit(525, 0); }

    public void set_modp2 (bool val)
    { m_mem.setMBit(525, 0, (bool) val); }

// модп3,   Bool, %M525.1   reg = M  width = Bit
    public bool get_modp3 ()
    { return (bool) m_mem.getMBit(525, 1); }

    public void set_modp3 (bool val)
    { m_mem.setMBit(525, 1, (bool) val); }

// модп4,   Bool, %M525.2   reg = M  width = Bit
    public bool get_modp4 ()
    { return (bool) m_mem.getMBit(525, 2); }

    public void set_modp4 (bool val)
    { m_mem.setMBit(525, 2, (bool) val); }

// модп нижний,   Bool, %M525.3   reg = M  width = Bit
    public bool get_modp_nizhnij ()
    { return (bool) m_mem.getMBit(525, 3); }

    public void set_modp_nizhnij (bool val)
    { m_mem.setMBit(525, 3, (bool) val); }

// модп закачен,   Bool, %M525.4   reg = M  width = Bit
    public bool get_modp_zakachen ()
    { return (bool) m_mem.getMBit(525, 4); }

    public void set_modp_zakachen (bool val)
    { m_mem.setMBit(525, 4, (bool) val); }

// модп выкачен,   Bool, %M525.5   reg = M  width = Bit
    public bool get_modp_vykachen ()
    { return (bool) m_mem.getMBit(525, 5); }

    public void set_modp_vykachen (bool val)
    { m_mem.setMBit(525, 5, (bool) val); }

// охл скан изб,   Bool, %M525.6   reg = M  width = Bit
    public bool get_ohl_skan_izb ()
    { return (bool) m_mem.getMBit(525, 6); }

    public void set_ohl_skan_izb (bool val)
    { m_mem.setMBit(525, 6, (bool) val); }

// стол на поз,   Bool, %M514.7   reg = M  width = Bit
    public bool get_stol_na_poz ()
    { return (bool) m_mem.getMBit(514, 7); }

    public void set_stol_na_poz (bool val)
    { m_mem.setMBit(514, 7, (bool) val); }

// стол гот,   Bool, %M515.0   reg = M  width = Bit
    public bool get_stol_got ()
    { return (bool) m_mem.getMBit(515, 0); }

    public void set_stol_got (bool val)
    { m_mem.setMBit(515, 0, (bool) val); }

// проц общ раб,   Bool, %M515.1   reg = M  width = Bit
    public bool get_proc_obshh_rab ()
    { return (bool) m_mem.getMBit(515, 1); }

    public void set_proc_obshh_rab (bool val)
    { m_mem.setMBit(515, 1, (bool) val); }

// стол отн гот,   Bool, %M515.2   reg = M  width = Bit
    public bool get_stol_otn_got ()
    { return (bool) m_mem.getMBit(515, 2); }

    public void set_stol_otn_got (bool val)
    { m_mem.setMBit(515, 2, (bool) val); }

// лазер гот,   Bool, %M515.3   reg = M  width = Bit
    public bool get_lazer_got ()
    { return (bool) m_mem.getMBit(515, 3); }

    public void set_lazer_got (bool val)
    { m_mem.setMBit(515, 3, (bool) val); }

// выс темп лазер,   Bool, %M511.6   reg = M  width = Bit
    public bool get_vys_temp_lazer ()
    { return (bool) m_mem.getMBit(511, 6); }

    public void set_vys_temp_lazer (bool val)
    { m_mem.setMBit(511, 6, (bool) val); }

// прот лазер,   Bool, %M511.5   reg = M  width = Bit
    public bool get_prot_lazer ()
    { return (bool) m_mem.getMBit(511, 5); }

    public void set_prot_lazer (bool val)
    { m_mem.setMBit(511, 5, (bool) val); }

// прожиг раб,   Bool, %M511.7   reg = M  width = Bit
    public bool get_prozhig_rab ()
    { return (bool) m_mem.getMBit(511, 7); }

    public void set_prozhig_rab (bool val)
    { m_mem.setMBit(511, 7, (bool) val); }

// слои непр раб,   Bool, %M512.0   reg = M  width = Bit
    public bool get_sloi_nepr_rab ()
    { return (bool) m_mem.getMBit(512, 0); }

    public void set_sloi_nepr_rab (bool val)
    { m_mem.setMBit(512, 0, (bool) val); }

// деталь гот,   Bool, %M512.1   reg = M  width = Bit
    public bool get_detal_got ()
    { return (bool) m_mem.getMBit(512, 1); }

    public void set_detal_got (bool val)
    { m_mem.setMBit(512, 1, (bool) val); }

// дм1,   DInt, %MD512   reg = M  width = UInt32
    public Int32 get_dm1 ()
    { return (Int32) m_mem.getMUInt32(512); }

    public void set_dm1 (Int32 val)
    { m_mem.setMUInt32(512, (UInt32) val); }

// дм2,   DInt, %MD536   reg = M  width = UInt32
    public Int32 get_dm2 ()
    { return (Int32) m_mem.getMUInt32(536); }

    public void set_dm2 (Int32 val)
    { m_mem.setMUInt32(536, (UInt32) val); }

// дм3,   DInt, %MD540   reg = M  width = UInt32
    public Int32 get_dm3 ()
    { return (Int32) m_mem.getMUInt32(540); }

    public void set_dm3 (Int32 val)
    { m_mem.setMUInt32(540, (UInt32) val); }

//-----------------------------------------------------------------------------
//tags/outD.xml
//-----------------------------------------------------------------------------
// выхд кар абс,   Bool, %M500.1   reg = M  width = Bit
    public bool get_vyhd_kar_abs ()
    { return (bool) m_mem.getMBit(500, 1); }

    public void set_vyhd_kar_abs (bool val)
    { m_mem.setMBit(500, 1, (bool) val); }

// выхд стол абс,   Bool, %M500.4   reg = M  width = Bit
    public bool get_vyhd_stol_abs ()
    { return (bool) m_mem.getMBit(500, 4); }

    public void set_vyhd_stol_abs (bool val)
    { m_mem.setMBit(500, 4, (bool) val); }

// выхд кл63-1 откр,   Bool, %M500.5   reg = M  width = Bit
    public bool get_vyhd_kl63_1_otkr ()
    { return (bool) m_mem.getMBit(500, 5); }

    public void set_vyhd_kl63_1_otkr (bool val)
    { m_mem.setMBit(500, 5, (bool) val); }

// выхд кл63-1 закр,   Bool, %M500.6   reg = M  width = Bit
    public bool get_vyhd_kl63_1_zakr ()
    { return (bool) m_mem.getMBit(500, 6); }

    public void set_vyhd_kl63_1_zakr (bool val)
    { m_mem.setMBit(500, 6, (bool) val); }

// выхд кл63-2 откр,   Bool, %M500.7   reg = M  width = Bit
    public bool get_vyhd_kl63_2_otkr ()
    { return (bool) m_mem.getMBit(500, 7); }

    public void set_vyhd_kl63_2_otkr (bool val)
    { m_mem.setMBit(500, 7, (bool) val); }

// выхд кл63-2 закр,   Bool, %M501.0   reg = M  width = Bit
    public bool get_vyhd_kl63_2_zakr ()
    { return (bool) m_mem.getMBit(501, 0); }

    public void set_vyhd_kl63_2_zakr (bool val)
    { m_mem.setMBit(501, 0, (bool) val); }

// выхд кл100-3 откр,   Bool, %M501.1   reg = M  width = Bit
    public bool get_vyhd_kl100_3_otkr ()
    { return (bool) m_mem.getMBit(501, 1); }

    public void set_vyhd_kl100_3_otkr (bool val)
    { m_mem.setMBit(501, 1, (bool) val); }

// выхд кл100-3 закр,   Bool, %M501.2   reg = M  width = Bit
    public bool get_vyhd_kl100_3_zakr ()
    { return (bool) m_mem.getMBit(501, 2); }

    public void set_vyhd_kl100_3_zakr (bool val)
    { m_mem.setMBit(501, 2, (bool) val); }

// выхд ш3 вперёд,   Bool, %M501.3   reg = M  width = Bit
    public bool get_vyhd_sh3_vperjod ()
    { return (bool) m_mem.getMBit(501, 3); }

    public void set_vyhd_sh3_vperjod (bool val)
    { m_mem.setMBit(501, 3, (bool) val); }

// выхд ш3 назад,   Bool, %M501.4   reg = M  width = Bit
    public bool get_vyhd_sh3_nazad ()
    { return (bool) m_mem.getMBit(501, 4); }

    public void set_vyhd_sh3_nazad (bool val)
    { m_mem.setMBit(501, 4, (bool) val); }

// выхд нул точ,   Bool, %M501.5   reg = M  width = Bit
    public bool get_vyhd_nul_toch ()
    { return (bool) m_mem.getMBit(501, 5); }

    public void set_vyhd_nul_toch (bool val)
    { m_mem.setMBit(501, 5, (bool) val); }

// выхд ш2 реле,   Bool, %M501.6   reg = M  width = Bit
    public bool get_vyhd_sh2_rele ()
    { return (bool) m_mem.getMBit(501, 6); }

    public void set_vyhd_sh2_rele (bool val)
    { m_mem.setMBit(501, 6, (bool) val); }

// выхд ш1 реле,   Bool, %M501.7   reg = M  width = Bit
    public bool get_vyhd_sh1_rele ()
    { return (bool) m_mem.getMBit(501, 7); }

    public void set_vyhd_sh1_rele (bool val)
    { m_mem.setMBit(501, 7, (bool) val); }

// выхд свет,   Bool, %M502.0   reg = M  width = Bit
    public bool get_vyhd_svet ()
    { return (bool) m_mem.getMBit(502, 0); }

    public void set_vyhd_svet (bool val)
    { m_mem.setMBit(502, 0, (bool) val); }

// выхд замок шериф,   Bool, %M502.1   reg = M  width = Bit
    public bool get_vyhd_zamok_sherif ()
    { return (bool) m_mem.getMBit(502, 1); }

    public void set_vyhd_zamok_sherif (bool val)
    { m_mem.setMBit(502, 1, (bool) val); }

// выхд с4 выкат,   Bool, %M502.2   reg = M  width = Bit
    public bool get_vyhd_s4_vykat ()
    { return (bool) m_mem.getMBit(502, 2); }

    public void set_vyhd_s4_vykat (bool val)
    { m_mem.setMBit(502, 2, (bool) val); }

// выхд с3 закат,   Bool, %M502.3   reg = M  width = Bit
    public bool get_vyhd_s3_zakat ()
    { return (bool) m_mem.getMBit(502, 3); }

    public void set_vyhd_s3_zakat (bool val)
    { m_mem.setMBit(502, 3, (bool) val); }

// выхд с2 опускание,   Bool, %M502.4   reg = M  width = Bit
    public bool get_vyhd_s2_opuskanie ()
    { return (bool) m_mem.getMBit(502, 4); }

    public void set_vyhd_s2_opuskanie (bool val)
    { m_mem.setMBit(502, 4, (bool) val); }

// выхд с1 подъём,   Bool, %M502.5   reg = M  width = Bit
    public bool get_vyhd_s1_pod_jom ()
    { return (bool) m_mem.getMBit(502, 5); }

    public void set_vyhd_s1_pod_jom (bool val)
    { m_mem.setMBit(502, 5, (bool) val); }

// выхд резерв км13,   Bool, %M502.6   reg = M  width = Bit
    public bool get_vyhd_rezerv_km13 ()
    { return (bool) m_mem.getMBit(502, 6); }

    public void set_vyhd_rezerv_km13 (bool val)
    { m_mem.setMBit(502, 6, (bool) val); }

// выхд резерв км12,   Bool, %M502.7   reg = M  width = Bit
    public bool get_vyhd_rezerv_km12 ()
    { return (bool) m_mem.getMBit(502, 7); }

    public void set_vyhd_rezerv_km12 (bool val)
    { m_mem.setMBit(502, 7, (bool) val); }

// выхд резерв км11,   Bool, %M503.0   reg = M  width = Bit
    public bool get_vyhd_rezerv_km11 ()
    { return (bool) m_mem.getMBit(503, 0); }

    public void set_vyhd_rezerv_km11 (bool val)
    { m_mem.setMBit(503, 0, (bool) val); }

// выхд 123,   Bool, %M503.1   reg = M  width = Bit
    public bool get_vyhd_123 ()
    { return (bool) m_mem.getMBit(503, 1); }

    public void set_vyhd_123 (bool val)
    { m_mem.setMBit(503, 1, (bool) val); }

// выхд ТЭН (1-3),   Bool, %M503.2   reg = M  width = Bit
    public bool get_vyhd_tjen_1_3 ()
    { return (bool) m_mem.getMBit(503, 2); }

    public void set_vyhd_tjen_1_3 (bool val)
    { m_mem.setMBit(503, 2, (bool) val); }

// выхд ТЭН (4-6),   Bool, %M503.3   reg = M  width = Bit
    public bool get_vyhd_tjen_4_6 ()
    { return (bool) m_mem.getMBit(503, 3); }

    public void set_vyhd_tjen_4_6 (bool val)
    { m_mem.setMBit(503, 3, (bool) val); }

// выхд ТЭН стола,   Bool, %M503.4   reg = M  width = Bit
    public bool get_vyhd_tjen_stola ()
    { return (bool) m_mem.getMBit(503, 4); }

    public void set_vyhd_tjen_stola (bool val)
    { m_mem.setMBit(503, 4, (bool) val); }

// выхд резерв,   Bool, %M503.5   reg = M  width = Bit
    public bool get_vyhd_rezerv ()
    { return (bool) m_mem.getMBit(503, 5); }

    public void set_vyhd_rezerv (bool val)
    { m_mem.setMBit(503, 5, (bool) val); }

// выхд резерв(1),   Bool, %M503.6   reg = M  width = Bit
    public bool get_vyhd_rezerv_1 ()
    { return (bool) m_mem.getMBit(503, 6); }

    public void set_vyhd_rezerv_1 (bool val)
    { m_mem.setMBit(503, 6, (bool) val); }

// выхд резерв(2),   Bool, %M503.7   reg = M  width = Bit
    public bool get_vyhd_rezerv_2 ()
    { return (bool) m_mem.getMBit(503, 7); }

    public void set_vyhd_rezerv_2 (bool val)
    { m_mem.setMBit(503, 7, (bool) val); }

// выхд резерв(3),   Bool, %M504.0   reg = M  width = Bit
    public bool get_vyhd_rezerv_3 ()
    { return (bool) m_mem.getMBit(504, 0); }

    public void set_vyhd_rezerv_3 (bool val)
    { m_mem.setMBit(504, 0, (bool) val); }

// выхд резерв(4),   Bool, %M504.1   reg = M  width = Bit
    public bool get_vyhd_rezerv_4 ()
    { return (bool) m_mem.getMBit(504, 1); }

    public void set_vyhd_rezerv_4 (bool val)
    { m_mem.setMBit(504, 1, (bool) val); }

// выхд резерв(5),   Bool, %M504.2   reg = M  width = Bit
    public bool get_vyhd_rezerv_5 ()
    { return (bool) m_mem.getMBit(504, 2); }

    public void set_vyhd_rezerv_5 (bool val)
    { m_mem.setMBit(504, 2, (bool) val); }

// выхд резерв(6),   Bool, %M504.3   reg = M  width = Bit
    public bool get_vyhd_rezerv_6 ()
    { return (bool) m_mem.getMBit(504, 3); }

    public void set_vyhd_rezerv_6 (bool val)
    { m_mem.setMBit(504, 3, (bool) val); }

// выхд резерв(7),   Bool, %M504.4   reg = M  width = Bit
    public bool get_vyhd_rezerv_7 ()
    { return (bool) m_mem.getMBit(504, 4); }

    public void set_vyhd_rezerv_7 (bool val)
    { m_mem.setMBit(504, 4, (bool) val); }

// выхд резерв(8),   Bool, %M504.5   reg = M  width = Bit
    public bool get_vyhd_rezerv_8 ()
    { return (bool) m_mem.getMBit(504, 5); }

    public void set_vyhd_rezerv_8 (bool val)
    { m_mem.setMBit(504, 5, (bool) val); }

// выхд резерв(9),   Bool, %M504.6   reg = M  width = Bit
    public bool get_vyhd_rezerv_9 ()
    { return (bool) m_mem.getMBit(504, 6); }

    public void set_vyhd_rezerv_9 (bool val)
    { m_mem.setMBit(504, 6, (bool) val); }

// выхд резерв(10),   Bool, %M504.7   reg = M  width = Bit
    public bool get_vyhd_rezerv_10 ()
    { return (bool) m_mem.getMBit(504, 7); }

    public void set_vyhd_rezerv_10 (bool val)
    { m_mem.setMBit(504, 7, (bool) val); }

// выхд резерв(11),   Bool, %M505.0   reg = M  width = Bit
    public bool get_vyhd_rezerv_11 ()
    { return (bool) m_mem.getMBit(505, 0); }

    public void set_vyhd_rezerv_11 (bool val)
    { m_mem.setMBit(505, 0, (bool) val); }

// выхд резерв(12),   Bool, %M505.1   reg = M  width = Bit
    public bool get_vyhd_rezerv_12 ()
    { return (bool) m_mem.getMBit(505, 1); }

    public void set_vyhd_rezerv_12 (bool val)
    { m_mem.setMBit(505, 1, (bool) val); }

// выхд резерв(13),   Bool, %M505.2   reg = M  width = Bit
    public bool get_vyhd_rezerv_13 ()
    { return (bool) m_mem.getMBit(505, 2); }

    public void set_vyhd_rezerv_13 (bool val)
    { m_mem.setMBit(505, 2, (bool) val); }

// выхд ш2 вперёд,   Bool, %M505.3   reg = M  width = Bit
    public bool get_vyhd_sh2_vperjod ()
    { return (bool) m_mem.getMBit(505, 3); }

    public void set_vyhd_sh2_vperjod (bool val)
    { m_mem.setMBit(505, 3, (bool) val); }

// выхд ш2 назад,   Bool, %M505.4   reg = M  width = Bit
    public bool get_vyhd_sh2_nazad ()
    { return (bool) m_mem.getMBit(505, 4); }

    public void set_vyhd_sh2_nazad (bool val)
    { m_mem.setMBit(505, 4, (bool) val); }

// выхд ш1 вперёд,   Bool, %M505.5   reg = M  width = Bit
    public bool get_vyhd_sh1_vperjod ()
    { return (bool) m_mem.getMBit(505, 5); }

    public void set_vyhd_sh1_vperjod (bool val)
    { m_mem.setMBit(505, 5, (bool) val); }

// выхд ш1 назад,   Bool, %M505.6   reg = M  width = Bit
    public bool get_vyhd_sh1_nazad ()
    { return (bool) m_mem.getMBit(505, 6); }

    public void set_vyhd_sh1_nazad (bool val)
    { m_mem.setMBit(505, 6, (bool) val); }

// выхд стол отн вниз,   Bool, %M505.7   reg = M  width = Bit
    public bool get_vyhd_stol_otn_vniz ()
    { return (bool) m_mem.getMBit(505, 7); }

    public void set_vyhd_stol_otn_vniz (bool val)
    { m_mem.setMBit(505, 7, (bool) val); }

// выхд стол отн вверх,   Bool, %M506.0   reg = M  width = Bit
    public bool get_vyhd_stol_otn_vverh ()
    { return (bool) m_mem.getMBit(506, 0); }

    public void set_vyhd_stol_otn_vverh (bool val)
    { m_mem.setMBit(506, 0, (bool) val); }

// выхд кар отн влево,   Bool, %M506.1   reg = M  width = Bit
    public bool get_vyhd_kar_otn_vlevo ()
    { return (bool) m_mem.getMBit(506, 1); }

    public void set_vyhd_kar_otn_vlevo (bool val)
    { m_mem.setMBit(506, 1, (bool) val); }

// выхд кар отн вправо,   Bool, %M506.2   reg = M  width = Bit
    public bool get_vyhd_kar_otn_vpravo ()
    { return (bool) m_mem.getMBit(506, 2); }

    public void set_vyhd_kar_otn_vpravo (bool val)
    { m_mem.setMBit(506, 2, (bool) val); }

// выхд кар дом,   Bool, %M506.3   reg = M  width = Bit
    public bool get_vyhd_kar_dom ()
    { return (bool) m_mem.getMBit(506, 3); }

    public void set_vyhd_kar_dom (bool val)
    { m_mem.setMBit(506, 3, (bool) val); }

// выхд стол поиск нуля,   Bool, %M506.4   reg = M  width = Bit
    public bool get_vyhd_stol_poisk_nulya ()
    { return (bool) m_mem.getMBit(506, 4); }

    public void set_vyhd_stol_poisk_nulya (bool val)
    { m_mem.setMBit(506, 4, (bool) val); }

// выхд пит скан,   Bool, %M506.5   reg = M  width = Bit
    public bool get_vyhd_pit_skan ()
    { return (bool) m_mem.getMBit(506, 5); }

    public void set_vyhd_pit_skan (bool val)
    { m_mem.setMBit(506, 5, (bool) val); }

// выхд пересчёт,   Bool, %M2.3   reg = M  width = Bit
    public bool get_vyhd_pereschjot ()
    { return (bool) m_mem.getMBit(2, 3); }

    public void set_vyhd_pereschjot (bool val)
    { m_mem.setMBit(2, 3, (bool) val); }

    }
 }
