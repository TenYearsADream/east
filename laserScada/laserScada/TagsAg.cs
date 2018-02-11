using System;
using log4netSample.Logging;
using System.Collections.Generic;
 namespace laserScada {

partial class Tags {
//-----------------------------------------------------------------------------
//tags/am.xml
//-----------------------------------------------------------------------------
// термопара1,   Real, %MD604   reg = M  width = UInt32
    public float get_termopara1 ()
    { return (float) m_mem.getMFloat(604); }

    public void set_termopara1 (float val)
    { m_mem.setMFloat(604, (float) val); 
      Log.Write(LogLevel.Info, "set termopara1 to " + val.ToString());}

    public bool sets_termopara1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_termopara1 (val);
    return true;}

    public string gets_termopara1 () { 
    return get_termopara1().ToString();}

    public string debug_name_termopara1 () { 
    return "термопара1";}

// термопара2,   Real, %MD608   reg = M  width = UInt32
    public float get_termopara2 ()
    { return (float) m_mem.getMFloat(608); }

    public void set_termopara2 (float val)
    { m_mem.setMFloat(608, (float) val); 
      Log.Write(LogLevel.Info, "set termopara2 to " + val.ToString());}

    public bool sets_termopara2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_termopara2 (val);
    return true;}

    public string gets_termopara2 () { 
    return get_termopara2().ToString();}

    public string debug_name_termopara2 () { 
    return "термопара2";}

// термопара3,   Real, %MD612   reg = M  width = UInt32
    public float get_termopara3 ()
    { return (float) m_mem.getMFloat(612); }

    public void set_termopara3 (float val)
    { m_mem.setMFloat(612, (float) val); 
      Log.Write(LogLevel.Info, "set termopara3 to " + val.ToString());}

    public bool sets_termopara3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_termopara3 (val);
    return true;}

    public string gets_termopara3 () { 
    return get_termopara3().ToString();}

    public string debug_name_termopara3 () { 
    return "термопара3";}

// давл оч газа1,   Real, %MD616   reg = M  width = UInt32
    public float get_davl_och_gaza1 ()
    { return (float) m_mem.getMFloat(616); }

    public void set_davl_och_gaza1 (float val)
    { m_mem.setMFloat(616, (float) val); 
      Log.Write(LogLevel.Info, "set davl_och_gaza1 to " + val.ToString());}

    public bool sets_davl_och_gaza1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl_och_gaza1 (val);
    return true;}

    public string gets_davl_och_gaza1 () { 
    return get_davl_och_gaza1().ToString();}

    public string debug_name_davl_och_gaza1 () { 
    return "давл оч газа1";}

// давл оч газа2,   Real, %MD620   reg = M  width = UInt32
    public float get_davl_och_gaza2 ()
    { return (float) m_mem.getMFloat(620); }

    public void set_davl_och_gaza2 (float val)
    { m_mem.setMFloat(620, (float) val); 
      Log.Write(LogLevel.Info, "set davl_och_gaza2 to " + val.ToString());}

    public bool sets_davl_och_gaza2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl_och_gaza2 (val);
    return true;}

    public string gets_davl_och_gaza2 () { 
    return get_davl_och_gaza2().ToString();}

    public string debug_name_davl_och_gaza2 () { 
    return "давл оч газа2";}

// давл оч газа3,   Real, %MD624   reg = M  width = UInt32
    public float get_davl_och_gaza3 ()
    { return (float) m_mem.getMFloat(624); }

    public void set_davl_och_gaza3 (float val)
    { m_mem.setMFloat(624, (float) val); 
      Log.Write(LogLevel.Info, "set davl_och_gaza3 to " + val.ToString());}

    public bool sets_davl_och_gaza3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl_och_gaza3 (val);
    return true;}

    public string gets_davl_och_gaza3 () { 
    return get_davl_och_gaza3().ToString();}

    public string debug_name_davl_och_gaza3 () { 
    return "давл оч газа3";}

// линейка,   Real, %MD642   reg = M  width = UInt32
    public float get_linejka ()
    { return (float) m_mem.getMFloat(642); }

    public void set_linejka (float val)
    { m_mem.setMFloat(642, (float) val); 
      Log.Write(LogLevel.Info, "set linejka to " + val.ToString());}

    public bool sets_linejka ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_linejka (val);
    return true;}

    public string gets_linejka () { 
    return get_linejka().ToString();}

    public string debug_name_linejka () { 
    return "линейка";}

// толщина,   Real, %MD646   reg = M  width = UInt32
    public float get_tolshhina ()
    { return (float) m_mem.getMFloat(646); }

    public void set_tolshhina (float val)
    { m_mem.setMFloat(646, (float) val); 
      Log.Write(LogLevel.Info, "set tolshhina to " + val.ToString());}

    public bool sets_tolshhina ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_tolshhina (val);
    return true;}

    public string gets_tolshhina () { 
    return get_tolshhina().ToString();}

    public string debug_name_tolshhina () { 
    return "толщина";}

// ТЭН1 тек мощн,   Real, %MD650   reg = M  width = UInt32
    public float get_tjen1_tek_moshhn ()
    { return (float) m_mem.getMFloat(650); }

    public void set_tjen1_tek_moshhn (float val)
    { m_mem.setMFloat(650, (float) val); 
      Log.Write(LogLevel.Info, "set tjen1_tek_moshhn to " + val.ToString());}

    public bool sets_tjen1_tek_moshhn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_tjen1_tek_moshhn (val);
    return true;}

    public string gets_tjen1_tek_moshhn () { 
    return get_tjen1_tek_moshhn().ToString();}

    public string debug_name_tjen1_tek_moshhn () { 
    return "ТЭН1 тек мощн";}

// кар тек поз,   Real, %MD734   reg = M  width = UInt32
    public float get_kar_tek_poz ()
    { return (float) m_mem.getMFloat(734); }

    public void set_kar_tek_poz (float val)
    { m_mem.setMFloat(734, (float) val); 
      Log.Write(LogLevel.Info, "set kar_tek_poz to " + val.ToString());}

    public bool sets_kar_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_kar_tek_poz (val);
    return true;}

    public string gets_kar_tek_poz () { 
    return get_kar_tek_poz().ToString();}

    public string debug_name_kar_tek_poz () { 
    return "кар тек поз";}

// стол тек поз,   Real, %MD738   reg = M  width = UInt32
    public float get_stol_tek_poz ()
    { return (float) m_mem.getMFloat(738); }

    public void set_stol_tek_poz (float val)
    { m_mem.setMFloat(738, (float) val); 
      Log.Write(LogLevel.Info, "set stol_tek_poz to " + val.ToString());}

    public bool sets_stol_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_stol_tek_poz (val);
    return true;}

    public string gets_stol_tek_poz () { 
    return get_stol_tek_poz().ToString();}

    public string debug_name_stol_tek_poz () { 
    return "стол тек поз";}

// счёт слоёв,   DInt, %MD748   reg = M  width = UInt32
    public Int32 get_schjot_slojov ()
    { return (Int32) m_mem.getMUInt32(748); }

    public void set_schjot_slojov (Int32 val)
    { m_mem.setMUInt32(748, (UInt32) val); 
      Log.Write(LogLevel.Info, "set schjot_slojov to " + val.ToString());}

    public bool sets_schjot_slojov ( string str) {
    Int32 val;
    if (!Int32.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int32 ");
        return false; }
    set_schjot_slojov (val);
    return true;}

    public string gets_schjot_slojov () { 
    return get_schjot_slojov().ToString();}

    public string debug_name_schjot_slojov () { 
    return "счёт слоёв";}

// ост слоёв,   Int, %MW756   reg = M  width = UInt16
    public Int16 get_ost_slojov ()
    { return (Int16) m_mem.getMUInt16(756); }

    public void set_ost_slojov (Int16 val)
    { m_mem.setMUInt16(756, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ost_slojov to " + val.ToString());}

    public bool sets_ost_slojov ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ost_slojov (val);
    return true;}

    public string gets_ost_slojov () { 
    return get_ost_slojov().ToString();}

    public string debug_name_ost_slojov () { 
    return "ост слоёв";}

// ост слоёв для дозатора,   Int, %MW758   reg = M  width = UInt16
    public Int16 get_ost_slojov_dlya_dozatora ()
    { return (Int16) m_mem.getMUInt16(758); }

    public void set_ost_slojov_dlya_dozatora (Int16 val)
    { m_mem.setMUInt16(758, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ost_slojov_dlya_dozatora to " + val.ToString());}

    public bool sets_ost_slojov_dlya_dozatora ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ost_slojov_dlya_dozatora (val);
    return true;}

    public string gets_ost_slojov_dlya_dozatora () { 
    return get_ost_slojov_dlya_dozatora().ToString();}

    public string debug_name_ost_slojov_dlya_dozatora () { 
    return "ост слоёв для дозатора";}

// инкремент,   Int, %MW760   reg = M  width = UInt16
    public Int16 get_inkrement ()
    { return (Int16) m_mem.getMUInt16(760); }

    public void set_inkrement (Int16 val)
    { m_mem.setMUInt16(760, (UInt16) val); 
      Log.Write(LogLevel.Info, "set inkrement to " + val.ToString());}

    public bool sets_inkrement ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_inkrement (val);
    return true;}

    public string gets_inkrement () { 
    return get_inkrement().ToString();}

    public string debug_name_inkrement () { 
    return "инкремент";}

// ТЭН2 тек мощн,   Real, %MD766   reg = M  width = UInt32
    public float get_tjen2_tek_moshhn ()
    { return (float) m_mem.getMFloat(766); }

    public void set_tjen2_tek_moshhn (float val)
    { m_mem.setMFloat(766, (float) val); 
      Log.Write(LogLevel.Info, "set tjen2_tek_moshhn to " + val.ToString());}

    public bool sets_tjen2_tek_moshhn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_tjen2_tek_moshhn (val);
    return true;}

    public string gets_tjen2_tek_moshhn () { 
    return get_tjen2_tek_moshhn().ToString();}

    public string debug_name_tjen2_tek_moshhn () { 
    return "ТЭН2 тек мощн";}

// ТЭН3 тек мощн,   Real, %MD770   reg = M  width = UInt32
    public float get_tjen3_tek_moshhn ()
    { return (float) m_mem.getMFloat(770); }

    public void set_tjen3_tek_moshhn (float val)
    { m_mem.setMFloat(770, (float) val); 
      Log.Write(LogLevel.Info, "set tjen3_tek_moshhn to " + val.ToString());}

    public bool sets_tjen3_tek_moshhn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_tjen3_tek_moshhn (val);
    return true;}

    public string gets_tjen3_tek_moshhn () { 
    return get_tjen3_tek_moshhn().ToString();}

    public string debug_name_tjen3_tek_moshhn () { 
    return "ТЭН3 тек мощн";}

// темп1,   Real, %MD654   reg = M  width = UInt32
    public float get_temp1 ()
    { return (float) m_mem.getMFloat(654); }

    public void set_temp1 (float val)
    { m_mem.setMFloat(654, (float) val); 
      Log.Write(LogLevel.Info, "set temp1 to " + val.ToString());}

    public bool sets_temp1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_temp1 (val);
    return true;}

    public string gets_temp1 () { 
    return get_temp1().ToString();}

    public string debug_name_temp1 () { 
    return "темп1";}

// темп2,   Real, %MD658   reg = M  width = UInt32
    public float get_temp2 ()
    { return (float) m_mem.getMFloat(658); }

    public void set_temp2 (float val)
    { m_mem.setMFloat(658, (float) val); 
      Log.Write(LogLevel.Info, "set temp2 to " + val.ToString());}

    public bool sets_temp2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_temp2 (val);
    return true;}

    public string gets_temp2 () { 
    return get_temp2().ToString();}

    public string debug_name_temp2 () { 
    return "темп2";}

// темп3,   Real, %MD662   reg = M  width = UInt32
    public float get_temp3 ()
    { return (float) m_mem.getMFloat(662); }

    public void set_temp3 (float val)
    { m_mem.setMFloat(662, (float) val); 
      Log.Write(LogLevel.Info, "set temp3 to " + val.ToString());}

    public bool sets_temp3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_temp3 (val);
    return true;}

    public string gets_temp3 () { 
    return get_temp3().ToString();}

    public string debug_name_temp3 () { 
    return "темп3";}

// темп4,   Real, %MD666   reg = M  width = UInt32
    public float get_temp4 ()
    { return (float) m_mem.getMFloat(666); }

    public void set_temp4 (float val)
    { m_mem.setMFloat(666, (float) val); 
      Log.Write(LogLevel.Info, "set temp4 to " + val.ToString());}

    public bool sets_temp4 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_temp4 (val);
    return true;}

    public string gets_temp4 () { 
    return get_temp4().ToString();}

    public string debug_name_temp4 () { 
    return "темп4";}

// темп5,   Real, %MD670   reg = M  width = UInt32
    public float get_temp5 ()
    { return (float) m_mem.getMFloat(670); }

    public void set_temp5 (float val)
    { m_mem.setMFloat(670, (float) val); 
      Log.Write(LogLevel.Info, "set temp5 to " + val.ToString());}

    public bool sets_temp5 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_temp5 (val);
    return true;}

    public string gets_temp5 () { 
    return get_temp5().ToString();}

    public string debug_name_temp5 () { 
    return "темп5";}

// темп6,   Real, %MD674   reg = M  width = UInt32
    public float get_temp6 ()
    { return (float) m_mem.getMFloat(674); }

    public void set_temp6 (float val)
    { m_mem.setMFloat(674, (float) val); 
      Log.Write(LogLevel.Info, "set temp6 to " + val.ToString());}

    public bool sets_temp6 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_temp6 (val);
    return true;}

    public string gets_temp6 () { 
    return get_temp6().ToString();}

    public string debug_name_temp6 () { 
    return "темп6";}

// датч кисл1,   Real, %MD628   reg = M  width = UInt32
    public float get_datch_kisl1 ()
    { return (float) m_mem.getMFloat(628); }

    public void set_datch_kisl1 (float val)
    { m_mem.setMFloat(628, (float) val); 
      Log.Write(LogLevel.Info, "set datch_kisl1 to " + val.ToString());}

    public bool sets_datch_kisl1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_datch_kisl1 (val);
    return true;}

    public string gets_datch_kisl1 () { 
    return get_datch_kisl1().ToString();}

    public string debug_name_datch_kisl1 () { 
    return "датч кисл1";}

// датч кисл2,   Real, %MD632   reg = M  width = UInt32
    public float get_datch_kisl2 ()
    { return (float) m_mem.getMFloat(632); }

    public void set_datch_kisl2 (float val)
    { m_mem.setMFloat(632, (float) val); 
      Log.Write(LogLevel.Info, "set datch_kisl2 to " + val.ToString());}

    public bool sets_datch_kisl2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_datch_kisl2 (val);
    return true;}

    public string gets_datch_kisl2 () { 
    return get_datch_kisl2().ToString();}

    public string debug_name_datch_kisl2 () { 
    return "датч кисл2";}

public enum local_am{
termopara1,
termopara2,
termopara3,
davl_och_gaza1,
davl_och_gaza2,
davl_och_gaza3,
linejka,
tolshhina,
tjen1_tek_moshhn,
kar_tek_poz,
stol_tek_poz,
schjot_slojov,
ost_slojov,
ost_slojov_dlya_dozatora,
inkrement,
tjen2_tek_moshhn,
tjen3_tek_moshhn,
temp1,
temp2,
temp3,
temp4,
temp5,
temp6,
datch_kisl1,
datch_kisl2,
};

public gTags[] group_am = {
gTags.termopara1,
gTags.termopara2,
gTags.termopara3,
gTags.davl_och_gaza1,
gTags.davl_och_gaza2,
gTags.davl_och_gaza3,
gTags.linejka,
gTags.tolshhina,
gTags.tjen1_tek_moshhn,
gTags.kar_tek_poz,
gTags.stol_tek_poz,
gTags.schjot_slojov,
gTags.ost_slojov,
gTags.ost_slojov_dlya_dozatora,
gTags.inkrement,
gTags.tjen2_tek_moshhn,
gTags.tjen3_tek_moshhn,
gTags.temp1,
gTags.temp2,
gTags.temp3,
gTags.temp4,
gTags.temp5,
gTags.temp6,
gTags.datch_kisl1,
gTags.datch_kisl2,
};

//-----------------------------------------------------------------------------
//tags/outd.xml
//-----------------------------------------------------------------------------
// выхд стол абс,   Bool, %M500.4   reg = M  width = Bit
    public bool get_vyhd_stol_abs ()
    { return (bool) m_mem.getMBit(500, 4); }

    public void set_vyhd_stol_abs (bool val)
    { m_mem.setMBit(500, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_stol_abs to " + val.ToString());}

    public bool sets_vyhd_stol_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_stol_abs (val);
    return true;}

    public string gets_vyhd_stol_abs () { 
    return get_vyhd_stol_abs().ToString();}

    public string debug_name_vyhd_stol_abs () { 
    return "выхд стол абс";}

// выхд ТЭН1,   Bool, %M503.2   reg = M  width = Bit
    public bool get_vyhd_tjen1 ()
    { return (bool) m_mem.getMBit(503, 2); }

    public void set_vyhd_tjen1 (bool val)
    { m_mem.setMBit(503, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tjen1 to " + val.ToString());}

    public bool sets_vyhd_tjen1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tjen1 (val);
    return true;}

    public string gets_vyhd_tjen1 () { 
    return get_vyhd_tjen1().ToString();}

    public string debug_name_vyhd_tjen1 () { 
    return "выхд ТЭН1";}

// выхд ТЭН2,   Bool, %M503.3   reg = M  width = Bit
    public bool get_vyhd_tjen2 ()
    { return (bool) m_mem.getMBit(503, 3); }

    public void set_vyhd_tjen2 (bool val)
    { m_mem.setMBit(503, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tjen2 to " + val.ToString());}

    public bool sets_vyhd_tjen2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tjen2 (val);
    return true;}

    public string gets_vyhd_tjen2 () { 
    return get_vyhd_tjen2().ToString();}

    public string debug_name_vyhd_tjen2 () { 
    return "выхд ТЭН2";}

// выхд ТЭН3,   Bool, %M503.4   reg = M  width = Bit
    public bool get_vyhd_tjen3 ()
    { return (bool) m_mem.getMBit(503, 4); }

    public void set_vyhd_tjen3 (bool val)
    { m_mem.setMBit(503, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tjen3 to " + val.ToString());}

    public bool sets_vyhd_tjen3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tjen3 (val);
    return true;}

    public string gets_vyhd_tjen3 () { 
    return get_vyhd_tjen3().ToString();}

    public string debug_name_vyhd_tjen3 () { 
    return "выхд ТЭН3";}

// выхд стол отн вниз,   Bool, %M505.7   reg = M  width = Bit
    public bool get_vyhd_stol_otn_vniz ()
    { return (bool) m_mem.getMBit(505, 7); }

    public void set_vyhd_stol_otn_vniz (bool val)
    { m_mem.setMBit(505, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_stol_otn_vniz to " + val.ToString());}

    public bool sets_vyhd_stol_otn_vniz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_stol_otn_vniz (val);
    return true;}

    public string gets_vyhd_stol_otn_vniz () { 
    return get_vyhd_stol_otn_vniz().ToString();}

    public string debug_name_vyhd_stol_otn_vniz () { 
    return "выхд стол отн вниз";}

// выхд стол отн вверх,   Bool, %M506.0   reg = M  width = Bit
    public bool get_vyhd_stol_otn_vverh ()
    { return (bool) m_mem.getMBit(506, 0); }

    public void set_vyhd_stol_otn_vverh (bool val)
    { m_mem.setMBit(506, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_stol_otn_vverh to " + val.ToString());}

    public bool sets_vyhd_stol_otn_vverh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_stol_otn_vverh (val);
    return true;}

    public string gets_vyhd_stol_otn_vverh () { 
    return get_vyhd_stol_otn_vverh().ToString();}

    public string debug_name_vyhd_stol_otn_vverh () { 
    return "выхд стол отн вверх";}

// выхд стол поиск нуля,   Bool, %M506.4   reg = M  width = Bit
    public bool get_vyhd_stol_poisk_nulya ()
    { return (bool) m_mem.getMBit(506, 4); }

    public void set_vyhd_stol_poisk_nulya (bool val)
    { m_mem.setMBit(506, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_stol_poisk_nulya to " + val.ToString());}

    public bool sets_vyhd_stol_poisk_nulya ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_stol_poisk_nulya (val);
    return true;}

    public string gets_vyhd_stol_poisk_nulya () { 
    return get_vyhd_stol_poisk_nulya().ToString();}

    public string debug_name_vyhd_stol_poisk_nulya () { 
    return "выхд стол поиск нуля";}

// выхд пит лазеров,   Bool, %M506.5   reg = M  width = Bit
    public bool get_vyhd_pit_lazerov ()
    { return (bool) m_mem.getMBit(506, 5); }

    public void set_vyhd_pit_lazerov (bool val)
    { m_mem.setMBit(506, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_lazerov to " + val.ToString());}

    public bool sets_vyhd_pit_lazerov ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_lazerov (val);
    return true;}

    public string gets_vyhd_pit_lazerov () { 
    return get_vyhd_pit_lazerov().ToString();}

    public string debug_name_vyhd_pit_lazerov () { 
    return "выхд пит лазеров";}

// выхд пит чил1,   Bool, %M506.6   reg = M  width = Bit
    public bool get_vyhd_pit_chil1 ()
    { return (bool) m_mem.getMBit(506, 6); }

    public void set_vyhd_pit_chil1 (bool val)
    { m_mem.setMBit(506, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_chil1 to " + val.ToString());}

    public bool sets_vyhd_pit_chil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_chil1 (val);
    return true;}

    public string gets_vyhd_pit_chil1 () { 
    return get_vyhd_pit_chil1().ToString();}

    public string debug_name_vyhd_pit_chil1 () { 
    return "выхд пит чил1";}

// выхд пит чил2,   Bool, %M506.7   reg = M  width = Bit
    public bool get_vyhd_pit_chil2 ()
    { return (bool) m_mem.getMBit(506, 7); }

    public void set_vyhd_pit_chil2 (bool val)
    { m_mem.setMBit(506, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_chil2 to " + val.ToString());}

    public bool sets_vyhd_pit_chil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_chil2 (val);
    return true;}

    public string gets_vyhd_pit_chil2 () { 
    return get_vyhd_pit_chil2().ToString();}

    public string debug_name_vyhd_pit_chil2 () { 
    return "выхд пит чил2";}

// выхд кл чил1,   Bool, %M507.0   reg = M  width = Bit
    public bool get_vyhd_kl_chil1 ()
    { return (bool) m_mem.getMBit(507, 0); }

    public void set_vyhd_kl_chil1 (bool val)
    { m_mem.setMBit(507, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kl_chil1 to " + val.ToString());}

    public bool sets_vyhd_kl_chil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kl_chil1 (val);
    return true;}

    public string gets_vyhd_kl_chil1 () { 
    return get_vyhd_kl_chil1().ToString();}

    public string debug_name_vyhd_kl_chil1 () { 
    return "выхд кл чил1";}

// выхд кл чил2,   Bool, %M507.1   reg = M  width = Bit
    public bool get_vyhd_kl_chil2 ()
    { return (bool) m_mem.getMBit(507, 1); }

    public void set_vyhd_kl_chil2 (bool val)
    { m_mem.setMBit(507, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kl_chil2 to " + val.ToString());}

    public bool sets_vyhd_kl_chil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kl_chil2 (val);
    return true;}

    public string gets_vyhd_kl_chil2 () { 
    return get_vyhd_kl_chil2().ToString();}

    public string debug_name_vyhd_kl_chil2 () { 
    return "выхд кл чил2";}

// выхд пит МПС,   Bool, %M507.2   reg = M  width = Bit
    public bool get_vyhd_pit_mps ()
    { return (bool) m_mem.getMBit(507, 2); }

    public void set_vyhd_pit_mps (bool val)
    { m_mem.setMBit(507, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_mps to " + val.ToString());}

    public bool sets_vyhd_pit_mps ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_mps (val);
    return true;}

    public string gets_vyhd_pit_mps () { 
    return get_vyhd_pit_mps().ToString();}

    public string debug_name_vyhd_pit_mps () { 
    return "выхд пит МПС";}

// выхд пит рец,   Bool, %M507.3   reg = M  width = Bit
    public bool get_vyhd_pit_rec ()
    { return (bool) m_mem.getMBit(507, 3); }

    public void set_vyhd_pit_rec (bool val)
    { m_mem.setMBit(507, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_rec to " + val.ToString());}

    public bool sets_vyhd_pit_rec ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_rec (val);
    return true;}

    public string gets_vyhd_pit_rec () { 
    return get_vyhd_pit_rec().ToString();}

    public string debug_name_vyhd_pit_rec () { 
    return "выхд пит рец";}

// выхд КВ1,   Bool, %M507.4   reg = M  width = Bit
    public bool get_vyhd_kv1 ()
    { return (bool) m_mem.getMBit(507, 4); }

    public void set_vyhd_kv1 (bool val)
    { m_mem.setMBit(507, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kv1 to " + val.ToString());}

    public bool sets_vyhd_kv1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kv1 (val);
    return true;}

    public string gets_vyhd_kv1 () { 
    return get_vyhd_kv1().ToString();}

    public string debug_name_vyhd_kv1 () { 
    return "выхд КВ1";}

// выхд КВ2,   Bool, %M507.5   reg = M  width = Bit
    public bool get_vyhd_kv2 ()
    { return (bool) m_mem.getMBit(507, 5); }

    public void set_vyhd_kv2 (bool val)
    { m_mem.setMBit(507, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kv2 to " + val.ToString());}

    public bool sets_vyhd_kv2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kv2 (val);
    return true;}

    public string gets_vyhd_kv2 () { 
    return get_vyhd_kv2().ToString();}

    public string debug_name_vyhd_kv2 () { 
    return "выхд КВ2";}

// выхд КЭ9,   Bool, %M507.6   reg = M  width = Bit
    public bool get_vyhd_kje9 ()
    { return (bool) m_mem.getMBit(507, 6); }

    public void set_vyhd_kje9 (bool val)
    { m_mem.setMBit(507, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kje9 to " + val.ToString());}

    public bool sets_vyhd_kje9 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kje9 (val);
    return true;}

    public string gets_vyhd_kje9 () { 
    return get_vyhd_kje9().ToString();}

    public string debug_name_vyhd_kje9 () { 
    return "выхд КЭ9";}

// выхд КЭ10,   Bool, %M507.7   reg = M  width = Bit
    public bool get_vyhd_kje10 ()
    { return (bool) m_mem.getMBit(507, 7); }

    public void set_vyhd_kje10 (bool val)
    { m_mem.setMBit(507, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kje10 to " + val.ToString());}

    public bool sets_vyhd_kje10 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kje10 (val);
    return true;}

    public string gets_vyhd_kje10 () { 
    return get_vyhd_kje10().ToString();}

    public string debug_name_vyhd_kje10 () { 
    return "выхд КЭ10";}

// выхд кар прав абс,   Bool, %M508.0   reg = M  width = Bit
    public bool get_vyhd_kar_prav_abs ()
    { return (bool) m_mem.getMBit(508, 0); }

    public void set_vyhd_kar_prav_abs (bool val)
    { m_mem.setMBit(508, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_prav_abs to " + val.ToString());}

    public bool sets_vyhd_kar_prav_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_prav_abs (val);
    return true;}

    public string gets_vyhd_kar_prav_abs () { 
    return get_vyhd_kar_prav_abs().ToString();}

    public string debug_name_vyhd_kar_prav_abs () { 
    return "выхд кар прав абс";}

// выхд кар лев абс,   Bool, %M508.1   reg = M  width = Bit
    public bool get_vyhd_kar_lev_abs ()
    { return (bool) m_mem.getMBit(508, 1); }

    public void set_vyhd_kar_lev_abs (bool val)
    { m_mem.setMBit(508, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_lev_abs to " + val.ToString());}

    public bool sets_vyhd_kar_lev_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_lev_abs (val);
    return true;}

    public string gets_vyhd_kar_lev_abs () { 
    return get_vyhd_kar_lev_abs().ToString();}

    public string debug_name_vyhd_kar_lev_abs () { 
    return "выхд кар лев абс";}

// выхд доз прав впер,   Bool, %M508.2   reg = M  width = Bit
    public bool get_vyhd_doz_prav_vper ()
    { return (bool) m_mem.getMBit(508, 2); }

    public void set_vyhd_doz_prav_vper (bool val)
    { m_mem.setMBit(508, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_doz_prav_vper to " + val.ToString());}

    public bool sets_vyhd_doz_prav_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_doz_prav_vper (val);
    return true;}

    public string gets_vyhd_doz_prav_vper () { 
    return get_vyhd_doz_prav_vper().ToString();}

    public string debug_name_vyhd_doz_prav_vper () { 
    return "выхд доз прав впер";}

// выхд доз лев впер,   Bool, %M508.3   reg = M  width = Bit
    public bool get_vyhd_doz_lev_vper ()
    { return (bool) m_mem.getMBit(508, 3); }

    public void set_vyhd_doz_lev_vper (bool val)
    { m_mem.setMBit(508, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_doz_lev_vper to " + val.ToString());}

    public bool sets_vyhd_doz_lev_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_doz_lev_vper (val);
    return true;}

    public string gets_vyhd_doz_lev_vper () { 
    return get_vyhd_doz_lev_vper().ToString();}

    public string debug_name_vyhd_doz_lev_vper () { 
    return "выхд доз лев впер";}

// выхд доз прав назад,   Bool, %M508.4   reg = M  width = Bit
    public bool get_vyhd_doz_prav_nazad ()
    { return (bool) m_mem.getMBit(508, 4); }

    public void set_vyhd_doz_prav_nazad (bool val)
    { m_mem.setMBit(508, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_doz_prav_nazad to " + val.ToString());}

    public bool sets_vyhd_doz_prav_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_doz_prav_nazad (val);
    return true;}

    public string gets_vyhd_doz_prav_nazad () { 
    return get_vyhd_doz_prav_nazad().ToString();}

    public string debug_name_vyhd_doz_prav_nazad () { 
    return "выхд доз прав назад";}

// выхд доз лев назад,   Bool, %M508.5   reg = M  width = Bit
    public bool get_vyhd_doz_lev_nazad ()
    { return (bool) m_mem.getMBit(508, 5); }

    public void set_vyhd_doz_lev_nazad (bool val)
    { m_mem.setMBit(508, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_doz_lev_nazad to " + val.ToString());}

    public bool sets_vyhd_doz_lev_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_doz_lev_nazad (val);
    return true;}

    public string gets_vyhd_doz_lev_nazad () { 
    return get_vyhd_doz_lev_nazad().ToString();}

    public string debug_name_vyhd_doz_lev_nazad () { 
    return "выхд доз лев назад";}

// выхд пересчёт,   Bool, %M2.3   reg = M  width = Bit
    public bool get_vyhd_pereschjot ()
    { return (bool) m_mem.getMBit(2, 3); }

    public void set_vyhd_pereschjot (bool val)
    { m_mem.setMBit(2, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pereschjot to " + val.ToString());}

    public bool sets_vyhd_pereschjot ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pereschjot (val);
    return true;}

    public string gets_vyhd_pereschjot () { 
    return get_vyhd_pereschjot().ToString();}

    public string debug_name_vyhd_pereschjot () { 
    return "выхд пересчёт";}

// выхд бар лев впер,   Bool, %M508.6   reg = M  width = Bit
    public bool get_vyhd_bar_lev_vper ()
    { return (bool) m_mem.getMBit(508, 6); }

    public void set_vyhd_bar_lev_vper (bool val)
    { m_mem.setMBit(508, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_bar_lev_vper to " + val.ToString());}

    public bool sets_vyhd_bar_lev_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_bar_lev_vper (val);
    return true;}

    public string gets_vyhd_bar_lev_vper () { 
    return get_vyhd_bar_lev_vper().ToString();}

    public string debug_name_vyhd_bar_lev_vper () { 
    return "выхд бар лев впер";}

// выхд бар прав впер,   Bool, %M508.7   reg = M  width = Bit
    public bool get_vyhd_bar_prav_vper ()
    { return (bool) m_mem.getMBit(508, 7); }

    public void set_vyhd_bar_prav_vper (bool val)
    { m_mem.setMBit(508, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_bar_prav_vper to " + val.ToString());}

    public bool sets_vyhd_bar_prav_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_bar_prav_vper (val);
    return true;}

    public string gets_vyhd_bar_prav_vper () { 
    return get_vyhd_bar_prav_vper().ToString();}

    public string debug_name_vyhd_bar_prav_vper () { 
    return "выхд бар прав впер";}

// выхд бар лев назад,   Bool, %M509.0   reg = M  width = Bit
    public bool get_vyhd_bar_lev_nazad ()
    { return (bool) m_mem.getMBit(509, 0); }

    public void set_vyhd_bar_lev_nazad (bool val)
    { m_mem.setMBit(509, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_bar_lev_nazad to " + val.ToString());}

    public bool sets_vyhd_bar_lev_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_bar_lev_nazad (val);
    return true;}

    public string gets_vyhd_bar_lev_nazad () { 
    return get_vyhd_bar_lev_nazad().ToString();}

    public string debug_name_vyhd_bar_lev_nazad () { 
    return "выхд бар лев назад";}

// выхд бар прав назад,   Bool, %M509.1   reg = M  width = Bit
    public bool get_vyhd_bar_prav_nazad ()
    { return (bool) m_mem.getMBit(509, 1); }

    public void set_vyhd_bar_prav_nazad (bool val)
    { m_mem.setMBit(509, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_bar_prav_nazad to " + val.ToString());}

    public bool sets_vyhd_bar_prav_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_bar_prav_nazad (val);
    return true;}

    public string gets_vyhd_bar_prav_nazad () { 
    return get_vyhd_bar_prav_nazad().ToString();}

    public string debug_name_vyhd_bar_prav_nazad () { 
    return "выхд бар прав назад";}

// выхд толк лев впер,   Bool, %M509.2   reg = M  width = Bit
    public bool get_vyhd_tolk_lev_vper ()
    { return (bool) m_mem.getMBit(509, 2); }

    public void set_vyhd_tolk_lev_vper (bool val)
    { m_mem.setMBit(509, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tolk_lev_vper to " + val.ToString());}

    public bool sets_vyhd_tolk_lev_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tolk_lev_vper (val);
    return true;}

    public string gets_vyhd_tolk_lev_vper () { 
    return get_vyhd_tolk_lev_vper().ToString();}

    public string debug_name_vyhd_tolk_lev_vper () { 
    return "выхд толк лев впер";}

// выхд толк прав впер,   Bool, %M509.3   reg = M  width = Bit
    public bool get_vyhd_tolk_prav_vper ()
    { return (bool) m_mem.getMBit(509, 3); }

    public void set_vyhd_tolk_prav_vper (bool val)
    { m_mem.setMBit(509, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tolk_prav_vper to " + val.ToString());}

    public bool sets_vyhd_tolk_prav_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tolk_prav_vper (val);
    return true;}

    public string gets_vyhd_tolk_prav_vper () { 
    return get_vyhd_tolk_prav_vper().ToString();}

    public string debug_name_vyhd_tolk_prav_vper () { 
    return "выхд толк прав впер";}

// выхд толк лев назад,   Bool, %M509.4   reg = M  width = Bit
    public bool get_vyhd_tolk_lev_nazad ()
    { return (bool) m_mem.getMBit(509, 4); }

    public void set_vyhd_tolk_lev_nazad (bool val)
    { m_mem.setMBit(509, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tolk_lev_nazad to " + val.ToString());}

    public bool sets_vyhd_tolk_lev_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tolk_lev_nazad (val);
    return true;}

    public string gets_vyhd_tolk_lev_nazad () { 
    return get_vyhd_tolk_lev_nazad().ToString();}

    public string debug_name_vyhd_tolk_lev_nazad () { 
    return "выхд толк лев назад";}

// выхд толк прав назад,   Bool, %M509.5   reg = M  width = Bit
    public bool get_vyhd_tolk_prav_nazad ()
    { return (bool) m_mem.getMBit(509, 5); }

    public void set_vyhd_tolk_prav_nazad (bool val)
    { m_mem.setMBit(509, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_tolk_prav_nazad to " + val.ToString());}

    public bool sets_vyhd_tolk_prav_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_tolk_prav_nazad (val);
    return true;}

    public string gets_vyhd_tolk_prav_nazad () { 
    return get_vyhd_tolk_prav_nazad().ToString();}

    public string debug_name_vyhd_tolk_prav_nazad () { 
    return "выхд толк прав назад";}

// выхд кар прав отн впер,   Bool, %M509.6   reg = M  width = Bit
    public bool get_vyhd_kar_prav_otn_vper ()
    { return (bool) m_mem.getMBit(509, 6); }

    public void set_vyhd_kar_prav_otn_vper (bool val)
    { m_mem.setMBit(509, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_prav_otn_vper to " + val.ToString());}

    public bool sets_vyhd_kar_prav_otn_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_prav_otn_vper (val);
    return true;}

    public string gets_vyhd_kar_prav_otn_vper () { 
    return get_vyhd_kar_prav_otn_vper().ToString();}

    public string debug_name_vyhd_kar_prav_otn_vper () { 
    return "выхд кар прав отн впер";}

// выхд кар прав отн наз,   Bool, %M509.7   reg = M  width = Bit
    public bool get_vyhd_kar_prav_otn_naz ()
    { return (bool) m_mem.getMBit(509, 7); }

    public void set_vyhd_kar_prav_otn_naz (bool val)
    { m_mem.setMBit(509, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_prav_otn_naz to " + val.ToString());}

    public bool sets_vyhd_kar_prav_otn_naz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_prav_otn_naz (val);
    return true;}

    public string gets_vyhd_kar_prav_otn_naz () { 
    return get_vyhd_kar_prav_otn_naz().ToString();}

    public string debug_name_vyhd_kar_prav_otn_naz () { 
    return "выхд кар прав отн наз";}

// выхд кар лев отн впер,   Bool, %M510.0   reg = M  width = Bit
    public bool get_vyhd_kar_lev_otn_vper ()
    { return (bool) m_mem.getMBit(510, 0); }

    public void set_vyhd_kar_lev_otn_vper (bool val)
    { m_mem.setMBit(510, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_lev_otn_vper to " + val.ToString());}

    public bool sets_vyhd_kar_lev_otn_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_lev_otn_vper (val);
    return true;}

    public string gets_vyhd_kar_lev_otn_vper () { 
    return get_vyhd_kar_lev_otn_vper().ToString();}

    public string debug_name_vyhd_kar_lev_otn_vper () { 
    return "выхд кар лев отн впер";}

// выхд кар лев отн наз,   Bool, %M510.1   reg = M  width = Bit
    public bool get_vyhd_kar_lev_otn_naz ()
    { return (bool) m_mem.getMBit(510, 1); }

    public void set_vyhd_kar_lev_otn_naz (bool val)
    { m_mem.setMBit(510, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_lev_otn_naz to " + val.ToString());}

    public bool sets_vyhd_kar_lev_otn_naz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_lev_otn_naz (val);
    return true;}

    public string gets_vyhd_kar_lev_otn_naz () { 
    return get_vyhd_kar_lev_otn_naz().ToString();}

    public string debug_name_vyhd_kar_lev_otn_naz () { 
    return "выхд кар лев отн наз";}

// выхд кл бар лев,   Bool, %M510.2   reg = M  width = Bit
    public bool get_vyhd_kl_bar_lev ()
    { return (bool) m_mem.getMBit(510, 2); }

    public void set_vyhd_kl_bar_lev (bool val)
    { m_mem.setMBit(510, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kl_bar_lev to " + val.ToString());}

    public bool sets_vyhd_kl_bar_lev ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kl_bar_lev (val);
    return true;}

    public string gets_vyhd_kl_bar_lev () { 
    return get_vyhd_kl_bar_lev().ToString();}

    public string debug_name_vyhd_kl_bar_lev () { 
    return "выхд кл бар лев";}

// выхд кл бар прав,   Bool, %M510.3   reg = M  width = Bit
    public bool get_vyhd_kl_bar_prav ()
    { return (bool) m_mem.getMBit(510, 3); }

    public void set_vyhd_kl_bar_prav (bool val)
    { m_mem.setMBit(510, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kl_bar_prav to " + val.ToString());}

    public bool sets_vyhd_kl_bar_prav ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kl_bar_prav (val);
    return true;}

    public string gets_vyhd_kl_bar_prav () { 
    return get_vyhd_kl_bar_prav().ToString();}

    public string debug_name_vyhd_kl_bar_prav () { 
    return "выхд кл бар прав";}

// выхд нас отк газа,   Bool, %M510.4   reg = M  width = Bit
    public bool get_vyhd_nas_otk_gaza ()
    { return (bool) m_mem.getMBit(510, 4); }

    public void set_vyhd_nas_otk_gaza (bool val)
    { m_mem.setMBit(510, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_nas_otk_gaza to " + val.ToString());}

    public bool sets_vyhd_nas_otk_gaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_nas_otk_gaza (val);
    return true;}

    public string gets_vyhd_nas_otk_gaza () { 
    return get_vyhd_nas_otk_gaza().ToString();}

    public string debug_name_vyhd_nas_otk_gaza () { 
    return "выхд нас отк газа";}

public enum local_outd{
vyhd_stol_abs,
vyhd_tjen1,
vyhd_tjen2,
vyhd_tjen3,
vyhd_stol_otn_vniz,
vyhd_stol_otn_vverh,
vyhd_stol_poisk_nulya,
vyhd_pit_lazerov,
vyhd_pit_chil1,
vyhd_pit_chil2,
vyhd_kl_chil1,
vyhd_kl_chil2,
vyhd_pit_mps,
vyhd_pit_rec,
vyhd_kv1,
vyhd_kv2,
vyhd_kje9,
vyhd_kje10,
vyhd_kar_prav_abs,
vyhd_kar_lev_abs,
vyhd_doz_prav_vper,
vyhd_doz_lev_vper,
vyhd_doz_prav_nazad,
vyhd_doz_lev_nazad,
vyhd_pereschjot,
vyhd_bar_lev_vper,
vyhd_bar_prav_vper,
vyhd_bar_lev_nazad,
vyhd_bar_prav_nazad,
vyhd_tolk_lev_vper,
vyhd_tolk_prav_vper,
vyhd_tolk_lev_nazad,
vyhd_tolk_prav_nazad,
vyhd_kar_prav_otn_vper,
vyhd_kar_prav_otn_naz,
vyhd_kar_lev_otn_vper,
vyhd_kar_lev_otn_naz,
vyhd_kl_bar_lev,
vyhd_kl_bar_prav,
vyhd_nas_otk_gaza,
};

public gTags[] group_outd = {
gTags.vyhd_stol_abs,
gTags.vyhd_tjen1,
gTags.vyhd_tjen2,
gTags.vyhd_tjen3,
gTags.vyhd_stol_otn_vniz,
gTags.vyhd_stol_otn_vverh,
gTags.vyhd_stol_poisk_nulya,
gTags.vyhd_pit_lazerov,
gTags.vyhd_pit_chil1,
gTags.vyhd_pit_chil2,
gTags.vyhd_kl_chil1,
gTags.vyhd_kl_chil2,
gTags.vyhd_pit_mps,
gTags.vyhd_pit_rec,
gTags.vyhd_kv1,
gTags.vyhd_kv2,
gTags.vyhd_kje9,
gTags.vyhd_kje10,
gTags.vyhd_kar_prav_abs,
gTags.vyhd_kar_lev_abs,
gTags.vyhd_doz_prav_vper,
gTags.vyhd_doz_lev_vper,
gTags.vyhd_doz_prav_nazad,
gTags.vyhd_doz_lev_nazad,
gTags.vyhd_pereschjot,
gTags.vyhd_bar_lev_vper,
gTags.vyhd_bar_prav_vper,
gTags.vyhd_bar_lev_nazad,
gTags.vyhd_bar_prav_nazad,
gTags.vyhd_tolk_lev_vper,
gTags.vyhd_tolk_prav_vper,
gTags.vyhd_tolk_lev_nazad,
gTags.vyhd_tolk_prav_nazad,
gTags.vyhd_kar_prav_otn_vper,
gTags.vyhd_kar_prav_otn_naz,
gTags.vyhd_kar_lev_otn_vper,
gTags.vyhd_kar_lev_otn_naz,
gTags.vyhd_kl_bar_lev,
gTags.vyhd_kl_bar_prav,
gTags.vyhd_nas_otk_gaza,
};

//-----------------------------------------------------------------------------
//tags/com.xml
//-----------------------------------------------------------------------------
// ком стол абс,   Bool, %M518.4   reg = M  width = Bit
    public bool get_kom_stol_abs ()
    { return (bool) m_mem.getMBit(518, 4); }

    public void set_kom_stol_abs (bool val)
    { m_mem.setMBit(518, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_abs to " + val.ToString());}

    public bool sets_kom_stol_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_abs (val);
    return true;}

    public string gets_kom_stol_abs () { 
    return get_kom_stol_abs().ToString();}

    public string debug_name_kom_stol_abs () { 
    return "ком стол абс";}

// ком ТП пуск,   Bool, %M518.6   reg = M  width = Bit
    public bool get_kom_tp_pusk ()
    { return (bool) m_mem.getMBit(518, 6); }

    public void set_kom_tp_pusk (bool val)
    { m_mem.setMBit(518, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_pusk to " + val.ToString());}

    public bool sets_kom_tp_pusk ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_pusk (val);
    return true;}

    public string gets_kom_tp_pusk () { 
    return get_kom_tp_pusk().ToString();}

    public string debug_name_kom_tp_pusk () { 
    return "ком ТП пуск";}

// ком ТП прер,   Bool, %M518.7   reg = M  width = Bit
    public bool get_kom_tp_prer ()
    { return (bool) m_mem.getMBit(518, 7); }

    public void set_kom_tp_prer (bool val)
    { m_mem.setMBit(518, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_prer to " + val.ToString());}

    public bool sets_kom_tp_prer ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_prer (val);
    return true;}

    public string gets_kom_tp_prer () { 
    return get_kom_tp_prer().ToString();}

    public string debug_name_kom_tp_prer () { 
    return "ком ТП прер";}

// ком кар абс,   Bool, %M519.0   reg = M  width = Bit
    public bool get_kom_kar_abs ()
    { return (bool) m_mem.getMBit(519, 0); }

    public void set_kom_kar_abs (bool val)
    { m_mem.setMBit(519, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_abs to " + val.ToString());}

    public bool sets_kom_kar_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_abs (val);
    return true;}

    public string gets_kom_kar_abs () { 
    return get_kom_kar_abs().ToString();}

    public string debug_name_kom_kar_abs () { 
    return "ком кар абс";}

// ком стол стоп,   Bool, %M519.2   reg = M  width = Bit
    public bool get_kom_stol_stop ()
    { return (bool) m_mem.getMBit(519, 2); }

    public void set_kom_stol_stop (bool val)
    { m_mem.setMBit(519, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_stop to " + val.ToString());}

    public bool sets_kom_stol_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_stop (val);
    return true;}

    public string gets_kom_stol_stop () { 
    return get_kom_stol_stop().ToString();}

    public string debug_name_kom_stol_stop () { 
    return "ком стол стоп";}

// ком каретка стоп,   Bool, %M519.3   reg = M  width = Bit
    public bool get_kom_karetka_stop ()
    { return (bool) m_mem.getMBit(519, 3); }

    public void set_kom_karetka_stop (bool val)
    { m_mem.setMBit(519, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karetka_stop to " + val.ToString());}

    public bool sets_kom_karetka_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karetka_stop (val);
    return true;}

    public string gets_kom_karetka_stop () { 
    return get_kom_karetka_stop().ToString();}

    public string debug_name_kom_karetka_stop () { 
    return "ком каретка стоп";}

// ком каретка сброс,   Bool, %M520.5   reg = M  width = Bit
    public bool get_kom_karetka_sbros ()
    { return (bool) m_mem.getMBit(520, 5); }

    public void set_kom_karetka_sbros (bool val)
    { m_mem.setMBit(520, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karetka_sbros to " + val.ToString());}

    public bool sets_kom_karetka_sbros ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karetka_sbros (val);
    return true;}

    public string gets_kom_karetka_sbros () { 
    return get_kom_karetka_sbros().ToString();}

    public string debug_name_kom_karetka_sbros () { 
    return "ком каретка сброс";}

// ком стол сброс,   Bool, %M520.6   reg = M  width = Bit
    public bool get_kom_stol_sbros ()
    { return (bool) m_mem.getMBit(520, 6); }

    public void set_kom_stol_sbros (bool val)
    { m_mem.setMBit(520, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_sbros to " + val.ToString());}

    public bool sets_kom_stol_sbros ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_sbros (val);
    return true;}

    public string gets_kom_stol_sbros () { 
    return get_kom_stol_sbros().ToString();}

    public string debug_name_kom_stol_sbros () { 
    return "ком стол сброс";}

// ком стол уст нуля,   Bool, %M521.0   reg = M  width = Bit
    public bool get_kom_stol_ust_nulya ()
    { return (bool) m_mem.getMBit(521, 0); }

    public void set_kom_stol_ust_nulya (bool val)
    { m_mem.setMBit(521, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_ust_nulya to " + val.ToString());}

    public bool sets_kom_stol_ust_nulya ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_ust_nulya (val);
    return true;}

    public string gets_kom_stol_ust_nulya () { 
    return get_kom_stol_ust_nulya().ToString();}

    public string debug_name_kom_stol_ust_nulya () { 
    return "ком стол уст нуля";}

// ком стол отн пуск вниз,   Bool, %M521.2   reg = M  width = Bit
    public bool get_kom_stol_otn_pusk_vniz ()
    { return (bool) m_mem.getMBit(521, 2); }

    public void set_kom_stol_otn_pusk_vniz (bool val)
    { m_mem.setMBit(521, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_otn_pusk_vniz to " + val.ToString());}

    public bool sets_kom_stol_otn_pusk_vniz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_otn_pusk_vniz (val);
    return true;}

    public string gets_kom_stol_otn_pusk_vniz () { 
    return get_kom_stol_otn_pusk_vniz().ToString();}

    public string debug_name_kom_stol_otn_pusk_vniz () { 
    return "ком стол отн пуск вниз";}

// ком стол отн пуск вверх,   Bool, %M521.3   reg = M  width = Bit
    public bool get_kom_stol_otn_pusk_vverh ()
    { return (bool) m_mem.getMBit(521, 3); }

    public void set_kom_stol_otn_pusk_vverh (bool val)
    { m_mem.setMBit(521, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_otn_pusk_vverh to " + val.ToString());}

    public bool sets_kom_stol_otn_pusk_vverh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_otn_pusk_vverh (val);
    return true;}

    public string gets_kom_stol_otn_pusk_vverh () { 
    return get_kom_stol_otn_pusk_vverh().ToString();}

    public string debug_name_kom_stol_otn_pusk_vverh () { 
    return "ком стол отн пуск вверх";}

// ком слой,   Bool, %M521.5   reg = M  width = Bit
    public bool get_kom_sloj ()
    { return (bool) m_mem.getMBit(521, 5); }

    public void set_kom_sloj (bool val)
    { m_mem.setMBit(521, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_sloj to " + val.ToString());}

    public bool sets_kom_sloj ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_sloj (val);
    return true;}

    public string gets_kom_sloj () { 
    return get_kom_sloj().ToString();}

    public string debug_name_kom_sloj () { 
    return "ком слой";}

// ком прер,   Bool, %M521.7   reg = M  width = Bit
    public bool get_kom_prer ()
    { return (bool) m_mem.getMBit(521, 7); }

    public void set_kom_prer (bool val)
    { m_mem.setMBit(521, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_prer to " + val.ToString());}

    public bool sets_kom_prer ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_prer (val);
    return true;}

    public string gets_kom_prer () { 
    return get_kom_prer().ToString();}

    public string debug_name_kom_prer () { 
    return "ком прер";}

// ком резерв,   Bool, %M522.2   reg = M  width = Bit
    public bool get_kom_rezerv ()
    { return (bool) m_mem.getMBit(522, 2); }

    public void set_kom_rezerv (bool val)
    { m_mem.setMBit(522, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_rezerv to " + val.ToString());}

    public bool sets_kom_rezerv ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_rezerv (val);
    return true;}

    public string gets_kom_rezerv () { 
    return get_kom_rezerv().ToString();}

    public string debug_name_kom_rezerv () { 
    return "ком резерв";}

// ком резерв(1),   Bool, %M522.3   reg = M  width = Bit
    public bool get_kom_rezerv_1 ()
    { return (bool) m_mem.getMBit(522, 3); }

    public void set_kom_rezerv_1 (bool val)
    { m_mem.setMBit(522, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_rezerv_1 to " + val.ToString());}

    public bool sets_kom_rezerv_1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_rezerv_1 (val);
    return true;}

    public string gets_kom_rezerv_1 () { 
    return get_kom_rezerv_1().ToString();}

    public string debug_name_kom_rezerv_1 () { 
    return "ком резерв(1)";}

// ком резерв(2),   Bool, %M522.4   reg = M  width = Bit
    public bool get_kom_rezerv_2 ()
    { return (bool) m_mem.getMBit(522, 4); }

    public void set_kom_rezerv_2 (bool val)
    { m_mem.setMBit(522, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_rezerv_2 to " + val.ToString());}

    public bool sets_kom_rezerv_2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_rezerv_2 (val);
    return true;}

    public string gets_kom_rezerv_2 () { 
    return get_kom_rezerv_2().ToString();}

    public string debug_name_kom_rezerv_2 () { 
    return "ком резерв(2)";}

// ком обнулить линейку,   Bool, %M522.7   reg = M  width = Bit
    public bool get_kom_obnulit_linejku ()
    { return (bool) m_mem.getMBit(522, 7); }

    public void set_kom_obnulit_linejku (bool val)
    { m_mem.setMBit(522, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_obnulit_linejku to " + val.ToString());}

    public bool sets_kom_obnulit_linejku ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_obnulit_linejku (val);
    return true;}

    public string gets_kom_obnulit_linejku () { 
    return get_kom_obnulit_linejku().ToString();}

    public string debug_name_kom_obnulit_linejku () { 
    return "ком обнулить линейку";}

// ком пит ТЭН3,   Bool, %M524.2   reg = M  width = Bit
    public bool get_kom_pit_tjen3 ()
    { return (bool) m_mem.getMBit(524, 2); }

    public void set_kom_pit_tjen3 (bool val)
    { m_mem.setMBit(524, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_tjen3 to " + val.ToString());}

    public bool sets_kom_pit_tjen3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_tjen3 (val);
    return true;}

    public string gets_kom_pit_tjen3 () { 
    return get_kom_pit_tjen3().ToString();}

    public string debug_name_kom_pit_tjen3 () { 
    return "ком пит ТЭН3";}

// ком пит ТЭН1,   Bool, %M524.3   reg = M  width = Bit
    public bool get_kom_pit_tjen1 ()
    { return (bool) m_mem.getMBit(524, 3); }

    public void set_kom_pit_tjen1 (bool val)
    { m_mem.setMBit(524, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_tjen1 to " + val.ToString());}

    public bool sets_kom_pit_tjen1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_tjen1 (val);
    return true;}

    public string gets_kom_pit_tjen1 () { 
    return get_kom_pit_tjen1().ToString();}

    public string debug_name_kom_pit_tjen1 () { 
    return "ком пит ТЭН1";}

// ком пит ТЭН2,   Bool, %M524.4   reg = M  width = Bit
    public bool get_kom_pit_tjen2 ()
    { return (bool) m_mem.getMBit(524, 4); }

    public void set_kom_pit_tjen2 (bool val)
    { m_mem.setMBit(524, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_tjen2 to " + val.ToString());}

    public bool sets_kom_pit_tjen2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_tjen2 (val);
    return true;}

    public string gets_kom_pit_tjen2 () { 
    return get_kom_pit_tjen2().ToString();}

    public string debug_name_kom_pit_tjen2 () { 
    return "ком пит ТЭН2";}

// ком стол поиск нуля,   Bool, %M525.7   reg = M  width = Bit
    public bool get_kom_stol_poisk_nulya ()
    { return (bool) m_mem.getMBit(525, 7); }

    public void set_kom_stol_poisk_nulya (bool val)
    { m_mem.setMBit(525, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_poisk_nulya to " + val.ToString());}

    public bool sets_kom_stol_poisk_nulya ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_poisk_nulya (val);
    return true;}

    public string gets_kom_stol_poisk_nulya () { 
    return get_kom_stol_poisk_nulya().ToString();}

    public string debug_name_kom_stol_poisk_nulya () { 
    return "ком стол поиск нуля";}

// ком процесс,   Bool, %M521.4   reg = M  width = Bit
    public bool get_kom_process ()
    { return (bool) m_mem.getMBit(521, 4); }

    public void set_kom_process (bool val)
    { m_mem.setMBit(521, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_process to " + val.ToString());}

    public bool sets_kom_process ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_process (val);
    return true;}

    public string gets_kom_process () { 
    return get_kom_process().ToString();}

    public string debug_name_kom_process () { 
    return "ком процесс";}

// ком проц общ,   Bool, %M526.0   reg = M  width = Bit
    public bool get_kom_proc_obshh ()
    { return (bool) m_mem.getMBit(526, 0); }

    public void set_kom_proc_obshh (bool val)
    { m_mem.setMBit(526, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_proc_obshh to " + val.ToString());}

    public bool sets_kom_proc_obshh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_proc_obshh (val);
    return true;}

    public string gets_kom_proc_obshh () { 
    return get_kom_proc_obshh().ToString();}

    public string debug_name_kom_proc_obshh () { 
    return "ком проц общ";}

// ком пересчёт,   Bool, %M526.1   reg = M  width = Bit
    public bool get_kom_pereschjot ()
    { return (bool) m_mem.getMBit(526, 1); }

    public void set_kom_pereschjot (bool val)
    { m_mem.setMBit(526, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pereschjot to " + val.ToString());}

    public bool sets_kom_pereschjot ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pereschjot (val);
    return true;}

    public string gets_kom_pereschjot () { 
    return get_kom_pereschjot().ToString();}

    public string debug_name_kom_pereschjot () { 
    return "ком пересчёт";}

// ком пит лаз,   Bool, %M526.2   reg = M  width = Bit
    public bool get_kom_pit_laz ()
    { return (bool) m_mem.getMBit(526, 2); }

    public void set_kom_pit_laz (bool val)
    { m_mem.setMBit(526, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_laz to " + val.ToString());}

    public bool sets_kom_pit_laz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_laz (val);
    return true;}

    public string gets_kom_pit_laz () { 
    return get_kom_pit_laz().ToString();}

    public string debug_name_kom_pit_laz () { 
    return "ком пит лаз";}

// ком гот лаз,   Bool, %M526.3   reg = M  width = Bit
    public bool get_kom_got_laz ()
    { return (bool) m_mem.getMBit(526, 3); }

    public void set_kom_got_laz (bool val)
    { m_mem.setMBit(526, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_got_laz to " + val.ToString());}

    public bool sets_kom_got_laz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_got_laz (val);
    return true;}

    public string gets_kom_got_laz () { 
    return get_kom_got_laz().ToString();}

    public string debug_name_kom_got_laz () { 
    return "ком гот лаз";}

// ком слой сброс счётчика,   Bool, %M526.5   reg = M  width = Bit
    public bool get_kom_sloj_sbros_schjotchika ()
    { return (bool) m_mem.getMBit(526, 5); }

    public void set_kom_sloj_sbros_schjotchika (bool val)
    { m_mem.setMBit(526, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_sloj_sbros_schjotchika to " + val.ToString());}

    public bool sets_kom_sloj_sbros_schjotchika ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_sloj_sbros_schjotchika (val);
    return true;}

    public string gets_kom_sloj_sbros_schjotchika () { 
    return get_kom_sloj_sbros_schjotchika().ToString();}

    public string debug_name_kom_sloj_sbros_schjotchika () { 
    return "ком слой сброс счётчика";}

// ком пауза,   Bool, %M526.7   reg = M  width = Bit
    public bool get_kom_pauza ()
    { return (bool) m_mem.getMBit(526, 7); }

    public void set_kom_pauza (bool val)
    { m_mem.setMBit(526, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pauza to " + val.ToString());}

    public bool sets_kom_pauza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pauza (val);
    return true;}

    public string gets_kom_pauza () { 
    return get_kom_pauza().ToString();}

    public string debug_name_kom_pauza () { 
    return "ком пауза";}

// ком раб до паузы,   Bool, %M527.0   reg = M  width = Bit
    public bool get_kom_rab_do_pauzy ()
    { return (bool) m_mem.getMBit(527, 0); }

    public void set_kom_rab_do_pauzy (bool val)
    { m_mem.setMBit(527, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_rab_do_pauzy to " + val.ToString());}

    public bool sets_kom_rab_do_pauzy ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_rab_do_pauzy (val);
    return true;}

    public string gets_kom_rab_do_pauzy () { 
    return get_kom_rab_do_pauzy().ToString();}

    public string debug_name_kom_rab_do_pauzy () { 
    return "ком раб до паузы";}

// ком дозатор автомат,   Bool, %M527.1   reg = M  width = Bit
    public bool get_kom_dozator_avtomat ()
    { return (bool) m_mem.getMBit(527, 1); }

    public void set_kom_dozator_avtomat (bool val)
    { m_mem.setMBit(527, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozator_avtomat to " + val.ToString());}

    public bool sets_kom_dozator_avtomat ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozator_avtomat (val);
    return true;}

    public string gets_kom_dozator_avtomat () { 
    return get_kom_dozator_avtomat().ToString();}

    public string debug_name_kom_dozator_avtomat () { 
    return "ком дозатор автомат";}

// ком пит чил1,   Bool, %M527.7   reg = M  width = Bit
    public bool get_kom_pit_chil1 ()
    { return (bool) m_mem.getMBit(527, 7); }

    public void set_kom_pit_chil1 (bool val)
    { m_mem.setMBit(527, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_chil1 to " + val.ToString());}

    public bool sets_kom_pit_chil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_chil1 (val);
    return true;}

    public string gets_kom_pit_chil1 () { 
    return get_kom_pit_chil1().ToString();}

    public string debug_name_kom_pit_chil1 () { 
    return "ком пит чил1";}

// ком пит чил2,   Bool, %M528.0   reg = M  width = Bit
    public bool get_kom_pit_chil2 ()
    { return (bool) m_mem.getMBit(528, 0); }

    public void set_kom_pit_chil2 (bool val)
    { m_mem.setMBit(528, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_chil2 to " + val.ToString());}

    public bool sets_kom_pit_chil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_chil2 (val);
    return true;}

    public string gets_kom_pit_chil2 () { 
    return get_kom_pit_chil2().ToString();}

    public string debug_name_kom_pit_chil2 () { 
    return "ком пит чил2";}

// ком кл чил1,   Bool, %M528.1   reg = M  width = Bit
    public bool get_kom_kl_chil1 ()
    { return (bool) m_mem.getMBit(528, 1); }

    public void set_kom_kl_chil1 (bool val)
    { m_mem.setMBit(528, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kl_chil1 to " + val.ToString());}

    public bool sets_kom_kl_chil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kl_chil1 (val);
    return true;}

    public string gets_kom_kl_chil1 () { 
    return get_kom_kl_chil1().ToString();}

    public string debug_name_kom_kl_chil1 () { 
    return "ком кл чил1";}

// ком кл чил2,   Bool, %M528.2   reg = M  width = Bit
    public bool get_kom_kl_chil2 ()
    { return (bool) m_mem.getMBit(528, 2); }

    public void set_kom_kl_chil2 (bool val)
    { m_mem.setMBit(528, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kl_chil2 to " + val.ToString());}

    public bool sets_kom_kl_chil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kl_chil2 (val);
    return true;}

    public string gets_kom_kl_chil2 () { 
    return get_kom_kl_chil2().ToString();}

    public string debug_name_kom_kl_chil2 () { 
    return "ком кл чил2";}

// ком пит рец,   Bool, %M528.3   reg = M  width = Bit
    public bool get_kom_pit_rec ()
    { return (bool) m_mem.getMBit(528, 3); }

    public void set_kom_pit_rec (bool val)
    { m_mem.setMBit(528, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_rec to " + val.ToString());}

    public bool sets_kom_pit_rec ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_rec (val);
    return true;}

    public string gets_kom_pit_rec () { 
    return get_kom_pit_rec().ToString();}

    public string debug_name_kom_pit_rec () { 
    return "ком пит рец";}

// ком пит МПС,   Bool, %M528.4   reg = M  width = Bit
    public bool get_kom_pit_mps ()
    { return (bool) m_mem.getMBit(528, 4); }

    public void set_kom_pit_mps (bool val)
    { m_mem.setMBit(528, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pit_mps to " + val.ToString());}

    public bool sets_kom_pit_mps ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pit_mps (val);
    return true;}

    public string gets_kom_pit_mps () { 
    return get_kom_pit_mps().ToString();}

    public string debug_name_kom_pit_mps () { 
    return "ком пит МПС";}

// ком кар лев ш1 вперёд,   Bool, %M529.2   reg = M  width = Bit
    public bool get_kom_kar_lev_sh1_vperjod ()
    { return (bool) m_mem.getMBit(529, 2); }

    public void set_kom_kar_lev_sh1_vperjod (bool val)
    { m_mem.setMBit(529, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_lev_sh1_vperjod to " + val.ToString());}

    public bool sets_kom_kar_lev_sh1_vperjod ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_lev_sh1_vperjod (val);
    return true;}

    public string gets_kom_kar_lev_sh1_vperjod () { 
    return get_kom_kar_lev_sh1_vperjod().ToString();}

    public string debug_name_kom_kar_lev_sh1_vperjod () { 
    return "ком кар лев ш1 вперёд";}

// ком кар лев ш1 назад,   Bool, %M529.3   reg = M  width = Bit
    public bool get_kom_kar_lev_sh1_nazad ()
    { return (bool) m_mem.getMBit(529, 3); }

    public void set_kom_kar_lev_sh1_nazad (bool val)
    { m_mem.setMBit(529, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_lev_sh1_nazad to " + val.ToString());}

    public bool sets_kom_kar_lev_sh1_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_lev_sh1_nazad (val);
    return true;}

    public string gets_kom_kar_lev_sh1_nazad () { 
    return get_kom_kar_lev_sh1_nazad().ToString();}

    public string debug_name_kom_kar_lev_sh1_nazad () { 
    return "ком кар лев ш1 назад";}

// ком кар лев ш1 абс,   Bool, %M529.4   reg = M  width = Bit
    public bool get_kom_kar_lev_sh1_abs ()
    { return (bool) m_mem.getMBit(529, 4); }

    public void set_kom_kar_lev_sh1_abs (bool val)
    { m_mem.setMBit(529, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_lev_sh1_abs to " + val.ToString());}

    public bool sets_kom_kar_lev_sh1_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_lev_sh1_abs (val);
    return true;}

    public string gets_kom_kar_lev_sh1_abs () { 
    return get_kom_kar_lev_sh1_abs().ToString();}

    public string debug_name_kom_kar_lev_sh1_abs () { 
    return "ком кар лев ш1 абс";}

// ком кар лев ш1 стоп,   Bool, %M529.5   reg = M  width = Bit
    public bool get_kom_kar_lev_sh1_stop ()
    { return (bool) m_mem.getMBit(529, 5); }

    public void set_kom_kar_lev_sh1_stop (bool val)
    { m_mem.setMBit(529, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_lev_sh1_stop to " + val.ToString());}

    public bool sets_kom_kar_lev_sh1_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_lev_sh1_stop (val);
    return true;}

    public string gets_kom_kar_lev_sh1_stop () { 
    return get_kom_kar_lev_sh1_stop().ToString();}

    public string debug_name_kom_kar_lev_sh1_stop () { 
    return "ком кар лев ш1 стоп";}

// ком кар прав ш2 вперёд,   Bool, %M529.6   reg = M  width = Bit
    public bool get_kom_kar_prav_sh2_vperjod ()
    { return (bool) m_mem.getMBit(529, 6); }

    public void set_kom_kar_prav_sh2_vperjod (bool val)
    { m_mem.setMBit(529, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_prav_sh2_vperjod to " + val.ToString());}

    public bool sets_kom_kar_prav_sh2_vperjod ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_prav_sh2_vperjod (val);
    return true;}

    public string gets_kom_kar_prav_sh2_vperjod () { 
    return get_kom_kar_prav_sh2_vperjod().ToString();}

    public string debug_name_kom_kar_prav_sh2_vperjod () { 
    return "ком кар прав ш2 вперёд";}

// ком кар прав ш2 назад,   Bool, %M529.7   reg = M  width = Bit
    public bool get_kom_kar_prav_sh2_nazad ()
    { return (bool) m_mem.getMBit(529, 7); }

    public void set_kom_kar_prav_sh2_nazad (bool val)
    { m_mem.setMBit(529, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_prav_sh2_nazad to " + val.ToString());}

    public bool sets_kom_kar_prav_sh2_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_prav_sh2_nazad (val);
    return true;}

    public string gets_kom_kar_prav_sh2_nazad () { 
    return get_kom_kar_prav_sh2_nazad().ToString();}

    public string debug_name_kom_kar_prav_sh2_nazad () { 
    return "ком кар прав ш2 назад";}

// ком кар прав ш2 абс,   Bool, %M530.1   reg = M  width = Bit
    public bool get_kom_kar_prav_sh2_abs ()
    { return (bool) m_mem.getMBit(530, 1); }

    public void set_kom_kar_prav_sh2_abs (bool val)
    { m_mem.setMBit(530, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_prav_sh2_abs to " + val.ToString());}

    public bool sets_kom_kar_prav_sh2_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_prav_sh2_abs (val);
    return true;}

    public string gets_kom_kar_prav_sh2_abs () { 
    return get_kom_kar_prav_sh2_abs().ToString();}

    public string debug_name_kom_kar_prav_sh2_abs () { 
    return "ком кар прав ш2 абс";}

// ком кар прав ш2 стоп,   Bool, %M531.3   reg = M  width = Bit
    public bool get_kom_kar_prav_sh2_stop ()
    { return (bool) m_mem.getMBit(531, 3); }

    public void set_kom_kar_prav_sh2_stop (bool val)
    { m_mem.setMBit(531, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_prav_sh2_stop to " + val.ToString());}

    public bool sets_kom_kar_prav_sh2_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_prav_sh2_stop (val);
    return true;}

    public string gets_kom_kar_prav_sh2_stop () { 
    return get_kom_kar_prav_sh2_stop().ToString();}

    public string debug_name_kom_kar_prav_sh2_stop () { 
    return "ком кар прав ш2 стоп";}

// ком бар прав ш3 вперёд,   Bool, %M531.4   reg = M  width = Bit
    public bool get_kom_bar_prav_sh3_vperjod ()
    { return (bool) m_mem.getMBit(531, 4); }

    public void set_kom_bar_prav_sh3_vperjod (bool val)
    { m_mem.setMBit(531, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_prav_sh3_vperjod to " + val.ToString());}

    public bool sets_kom_bar_prav_sh3_vperjod ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_prav_sh3_vperjod (val);
    return true;}

    public string gets_kom_bar_prav_sh3_vperjod () { 
    return get_kom_bar_prav_sh3_vperjod().ToString();}

    public string debug_name_kom_bar_prav_sh3_vperjod () { 
    return "ком бар прав ш3 вперёд";}

// ком бар прав ш3 назад,   Bool, %M531.5   reg = M  width = Bit
    public bool get_kom_bar_prav_sh3_nazad ()
    { return (bool) m_mem.getMBit(531, 5); }

    public void set_kom_bar_prav_sh3_nazad (bool val)
    { m_mem.setMBit(531, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_prav_sh3_nazad to " + val.ToString());}

    public bool sets_kom_bar_prav_sh3_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_prav_sh3_nazad (val);
    return true;}

    public string gets_kom_bar_prav_sh3_nazad () { 
    return get_kom_bar_prav_sh3_nazad().ToString();}

    public string debug_name_kom_bar_prav_sh3_nazad () { 
    return "ком бар прав ш3 назад";}

// ком бар прав ш3 абс,   Bool, %M531.6   reg = M  width = Bit
    public bool get_kom_bar_prav_sh3_abs ()
    { return (bool) m_mem.getMBit(531, 6); }

    public void set_kom_bar_prav_sh3_abs (bool val)
    { m_mem.setMBit(531, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_prav_sh3_abs to " + val.ToString());}

    public bool sets_kom_bar_prav_sh3_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_prav_sh3_abs (val);
    return true;}

    public string gets_kom_bar_prav_sh3_abs () { 
    return get_kom_bar_prav_sh3_abs().ToString();}

    public string debug_name_kom_bar_prav_sh3_abs () { 
    return "ком бар прав ш3 абс";}

// ком бар прав ш3 стоп,   Bool, %M531.7   reg = M  width = Bit
    public bool get_kom_bar_prav_sh3_stop ()
    { return (bool) m_mem.getMBit(531, 7); }

    public void set_kom_bar_prav_sh3_stop (bool val)
    { m_mem.setMBit(531, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_prav_sh3_stop to " + val.ToString());}

    public bool sets_kom_bar_prav_sh3_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_prav_sh3_stop (val);
    return true;}

    public string gets_kom_bar_prav_sh3_stop () { 
    return get_kom_bar_prav_sh3_stop().ToString();}

    public string debug_name_kom_bar_prav_sh3_stop () { 
    return "ком бар прав ш3 стоп";}

// ком бар лев ш4 вперёд,   Bool, %M532.0   reg = M  width = Bit
    public bool get_kom_bar_lev_sh4_vperjod ()
    { return (bool) m_mem.getMBit(532, 0); }

    public void set_kom_bar_lev_sh4_vperjod (bool val)
    { m_mem.setMBit(532, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_lev_sh4_vperjod to " + val.ToString());}

    public bool sets_kom_bar_lev_sh4_vperjod ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_lev_sh4_vperjod (val);
    return true;}

    public string gets_kom_bar_lev_sh4_vperjod () { 
    return get_kom_bar_lev_sh4_vperjod().ToString();}

    public string debug_name_kom_bar_lev_sh4_vperjod () { 
    return "ком бар лев ш4 вперёд";}

// ком бар лев ш4 назад,   Bool, %M532.1   reg = M  width = Bit
    public bool get_kom_bar_lev_sh4_nazad ()
    { return (bool) m_mem.getMBit(532, 1); }

    public void set_kom_bar_lev_sh4_nazad (bool val)
    { m_mem.setMBit(532, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_lev_sh4_nazad to " + val.ToString());}

    public bool sets_kom_bar_lev_sh4_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_lev_sh4_nazad (val);
    return true;}

    public string gets_kom_bar_lev_sh4_nazad () { 
    return get_kom_bar_lev_sh4_nazad().ToString();}

    public string debug_name_kom_bar_lev_sh4_nazad () { 
    return "ком бар лев ш4 назад";}

// ком бар лев ш4 абс,   Bool, %M532.2   reg = M  width = Bit
    public bool get_kom_bar_lev_sh4_abs ()
    { return (bool) m_mem.getMBit(532, 2); }

    public void set_kom_bar_lev_sh4_abs (bool val)
    { m_mem.setMBit(532, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_lev_sh4_abs to " + val.ToString());}

    public bool sets_kom_bar_lev_sh4_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_lev_sh4_abs (val);
    return true;}

    public string gets_kom_bar_lev_sh4_abs () { 
    return get_kom_bar_lev_sh4_abs().ToString();}

    public string debug_name_kom_bar_lev_sh4_abs () { 
    return "ком бар лев ш4 абс";}

// ком бар лев ш4 стоп,   Bool, %M532.3   reg = M  width = Bit
    public bool get_kom_bar_lev_sh4_stop ()
    { return (bool) m_mem.getMBit(532, 3); }

    public void set_kom_bar_lev_sh4_stop (bool val)
    { m_mem.setMBit(532, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_bar_lev_sh4_stop to " + val.ToString());}

    public bool sets_kom_bar_lev_sh4_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_bar_lev_sh4_stop (val);
    return true;}

    public string gets_kom_bar_lev_sh4_stop () { 
    return get_kom_bar_lev_sh4_stop().ToString();}

    public string debug_name_kom_bar_lev_sh4_stop () { 
    return "ком бар лев ш4 стоп";}

// ком дозатор лев впер,   Bool, %M532.4   reg = M  width = Bit
    public bool get_kom_dozator_lev_vper ()
    { return (bool) m_mem.getMBit(532, 4); }

    public void set_kom_dozator_lev_vper (bool val)
    { m_mem.setMBit(532, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozator_lev_vper to " + val.ToString());}

    public bool sets_kom_dozator_lev_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozator_lev_vper (val);
    return true;}

    public string gets_kom_dozator_lev_vper () { 
    return get_kom_dozator_lev_vper().ToString();}

    public string debug_name_kom_dozator_lev_vper () { 
    return "ком дозатор лев впер";}

// ком дозатор прав впер,   Bool, %M532.7   reg = M  width = Bit
    public bool get_kom_dozator_prav_vper ()
    { return (bool) m_mem.getMBit(532, 7); }

    public void set_kom_dozator_prav_vper (bool val)
    { m_mem.setMBit(532, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozator_prav_vper to " + val.ToString());}

    public bool sets_kom_dozator_prav_vper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozator_prav_vper (val);
    return true;}

    public string gets_kom_dozator_prav_vper () { 
    return get_kom_dozator_prav_vper().ToString();}

    public string debug_name_kom_dozator_prav_vper () { 
    return "ком дозатор прав впер";}

// ком толкатель лев вперёд,   Bool, %M533.2   reg = M  width = Bit
    public bool get_kom_tolkatel_lev_vperjod ()
    { return (bool) m_mem.getMBit(533, 2); }

    public void set_kom_tolkatel_lev_vperjod (bool val)
    { m_mem.setMBit(533, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkatel_lev_vperjod to " + val.ToString());}

    public bool sets_kom_tolkatel_lev_vperjod ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkatel_lev_vperjod (val);
    return true;}

    public string gets_kom_tolkatel_lev_vperjod () { 
    return get_kom_tolkatel_lev_vperjod().ToString();}

    public string debug_name_kom_tolkatel_lev_vperjod () { 
    return "ком толкатель лев вперёд";}

// ком толкатель лев назад,   Bool, %M533.3   reg = M  width = Bit
    public bool get_kom_tolkatel_lev_nazad ()
    { return (bool) m_mem.getMBit(533, 3); }

    public void set_kom_tolkatel_lev_nazad (bool val)
    { m_mem.setMBit(533, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkatel_lev_nazad to " + val.ToString());}

    public bool sets_kom_tolkatel_lev_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkatel_lev_nazad (val);
    return true;}

    public string gets_kom_tolkatel_lev_nazad () { 
    return get_kom_tolkatel_lev_nazad().ToString();}

    public string debug_name_kom_tolkatel_lev_nazad () { 
    return "ком толкатель лев назад";}

// ком толкатель прав вперёд,   Bool, %M533.5   reg = M  width = Bit
    public bool get_kom_tolkatel_prav_vperjod ()
    { return (bool) m_mem.getMBit(533, 5); }

    public void set_kom_tolkatel_prav_vperjod (bool val)
    { m_mem.setMBit(533, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkatel_prav_vperjod to " + val.ToString());}

    public bool sets_kom_tolkatel_prav_vperjod ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkatel_prav_vperjod (val);
    return true;}

    public string gets_kom_tolkatel_prav_vperjod () { 
    return get_kom_tolkatel_prav_vperjod().ToString();}

    public string debug_name_kom_tolkatel_prav_vperjod () { 
    return "ком толкатель прав вперёд";}

// ком толкатель прав назад,   Bool, %M533.6   reg = M  width = Bit
    public bool get_kom_tolkatel_prav_nazad ()
    { return (bool) m_mem.getMBit(533, 6); }

    public void set_kom_tolkatel_prav_nazad (bool val)
    { m_mem.setMBit(533, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkatel_prav_nazad to " + val.ToString());}

    public bool sets_kom_tolkatel_prav_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkatel_prav_nazad (val);
    return true;}

    public string gets_kom_tolkatel_prav_nazad () { 
    return get_kom_tolkatel_prav_nazad().ToString();}

    public string debug_name_kom_tolkatel_prav_nazad () { 
    return "ком толкатель прав назад";}

// ком дозатор лев назад,   Bool, %M533.0   reg = M  width = Bit
    public bool get_kom_dozator_lev_nazad ()
    { return (bool) m_mem.getMBit(533, 0); }

    public void set_kom_dozator_lev_nazad (bool val)
    { m_mem.setMBit(533, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozator_lev_nazad to " + val.ToString());}

    public bool sets_kom_dozator_lev_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozator_lev_nazad (val);
    return true;}

    public string gets_kom_dozator_lev_nazad () { 
    return get_kom_dozator_lev_nazad().ToString();}

    public string debug_name_kom_dozator_lev_nazad () { 
    return "ком дозатор лев назад";}

// ком дозатор прав назад,   Bool, %M533.1   reg = M  width = Bit
    public bool get_kom_dozator_prav_nazad ()
    { return (bool) m_mem.getMBit(533, 1); }

    public void set_kom_dozator_prav_nazad (bool val)
    { m_mem.setMBit(533, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozator_prav_nazad to " + val.ToString());}

    public bool sets_kom_dozator_prav_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozator_prav_nazad (val);
    return true;}

    public string gets_kom_dozator_prav_nazad () { 
    return get_kom_dozator_prav_nazad().ToString();}

    public string debug_name_kom_dozator_prav_nazad () { 
    return "ком дозатор прав назад";}

// ком КЭ9,   Bool, %M533.4   reg = M  width = Bit
    public bool get_kom_kje9 ()
    { return (bool) m_mem.getMBit(533, 4); }

    public void set_kom_kje9 (bool val)
    { m_mem.setMBit(533, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kje9 to " + val.ToString());}

    public bool sets_kom_kje9 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kje9 (val);
    return true;}

    public string gets_kom_kje9 () { 
    return get_kom_kje9().ToString();}

    public string debug_name_kom_kje9 () { 
    return "ком КЭ9";}

// ком КЭ10,   Bool, %M533.7   reg = M  width = Bit
    public bool get_kom_kje10 ()
    { return (bool) m_mem.getMBit(533, 7); }

    public void set_kom_kje10 (bool val)
    { m_mem.setMBit(533, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kje10 to " + val.ToString());}

    public bool sets_kom_kje10 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kje10 (val);
    return true;}

    public string gets_kom_kje10 () { 
    return get_kom_kje10().ToString();}

    public string debug_name_kom_kje10 () { 
    return "ком КЭ10";}

// ком КВ1,   Bool, %M534.0   reg = M  width = Bit
    public bool get_kom_kv1 ()
    { return (bool) m_mem.getMBit(534, 0); }

    public void set_kom_kv1 (bool val)
    { m_mem.setMBit(534, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kv1 to " + val.ToString());}

    public bool sets_kom_kv1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kv1 (val);
    return true;}

    public string gets_kom_kv1 () { 
    return get_kom_kv1().ToString();}

    public string debug_name_kom_kv1 () { 
    return "ком КВ1";}

// ком КВ2,   Bool, %M534.1   reg = M  width = Bit
    public bool get_kom_kv2 ()
    { return (bool) m_mem.getMBit(534, 1); }

    public void set_kom_kv2 (bool val)
    { m_mem.setMBit(534, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kv2 to " + val.ToString());}

    public bool sets_kom_kv2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kv2 (val);
    return true;}

    public string gets_kom_kv2 () { 
    return get_kom_kv2().ToString();}

    public string debug_name_kom_kv2 () { 
    return "ком КВ2";}

// ком кл бар лев,   Bool, %M534.2   reg = M  width = Bit
    public bool get_kom_kl_bar_lev ()
    { return (bool) m_mem.getMBit(534, 2); }

    public void set_kom_kl_bar_lev (bool val)
    { m_mem.setMBit(534, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kl_bar_lev to " + val.ToString());}

    public bool sets_kom_kl_bar_lev ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kl_bar_lev (val);
    return true;}

    public string gets_kom_kl_bar_lev () { 
    return get_kom_kl_bar_lev().ToString();}

    public string debug_name_kom_kl_bar_lev () { 
    return "ком кл бар лев";}

// ком кл бар прав,   Bool, %M534.3   reg = M  width = Bit
    public bool get_kom_kl_bar_prav ()
    { return (bool) m_mem.getMBit(534, 3); }

    public void set_kom_kl_bar_prav (bool val)
    { m_mem.setMBit(534, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kl_bar_prav to " + val.ToString());}

    public bool sets_kom_kl_bar_prav ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kl_bar_prav (val);
    return true;}

    public string gets_kom_kl_bar_prav () { 
    return get_kom_kl_bar_prav().ToString();}

    public string debug_name_kom_kl_bar_prav () { 
    return "ком кл бар прав";}

// ком нас отк газа,   Bool, %M519.1   reg = M  width = Bit
    public bool get_kom_nas_otk_gaza ()
    { return (bool) m_mem.getMBit(519, 1); }

    public void set_kom_nas_otk_gaza (bool val)
    { m_mem.setMBit(519, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_nas_otk_gaza to " + val.ToString());}

    public bool sets_kom_nas_otk_gaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_nas_otk_gaza (val);
    return true;}

    public string gets_kom_nas_otk_gaza () { 
    return get_kom_nas_otk_gaza().ToString();}

    public string debug_name_kom_nas_otk_gaza () { 
    return "ком нас отк газа";}

public enum local_com{
kom_stol_abs,
kom_tp_pusk,
kom_tp_prer,
kom_kar_abs,
kom_stol_stop,
kom_karetka_stop,
kom_karetka_sbros,
kom_stol_sbros,
kom_stol_ust_nulya,
kom_stol_otn_pusk_vniz,
kom_stol_otn_pusk_vverh,
kom_sloj,
kom_prer,
kom_rezerv,
kom_rezerv_1,
kom_rezerv_2,
kom_obnulit_linejku,
kom_pit_tjen3,
kom_pit_tjen1,
kom_pit_tjen2,
kom_stol_poisk_nulya,
kom_process,
kom_proc_obshh,
kom_pereschjot,
kom_pit_laz,
kom_got_laz,
kom_sloj_sbros_schjotchika,
kom_pauza,
kom_rab_do_pauzy,
kom_dozator_avtomat,
kom_pit_chil1,
kom_pit_chil2,
kom_kl_chil1,
kom_kl_chil2,
kom_pit_rec,
kom_pit_mps,
kom_kar_lev_sh1_vperjod,
kom_kar_lev_sh1_nazad,
kom_kar_lev_sh1_abs,
kom_kar_lev_sh1_stop,
kom_kar_prav_sh2_vperjod,
kom_kar_prav_sh2_nazad,
kom_kar_prav_sh2_abs,
kom_kar_prav_sh2_stop,
kom_bar_prav_sh3_vperjod,
kom_bar_prav_sh3_nazad,
kom_bar_prav_sh3_abs,
kom_bar_prav_sh3_stop,
kom_bar_lev_sh4_vperjod,
kom_bar_lev_sh4_nazad,
kom_bar_lev_sh4_abs,
kom_bar_lev_sh4_stop,
kom_dozator_lev_vper,
kom_dozator_prav_vper,
kom_tolkatel_lev_vperjod,
kom_tolkatel_lev_nazad,
kom_tolkatel_prav_vperjod,
kom_tolkatel_prav_nazad,
kom_dozator_lev_nazad,
kom_dozator_prav_nazad,
kom_kje9,
kom_kje10,
kom_kv1,
kom_kv2,
kom_kl_bar_lev,
kom_kl_bar_prav,
kom_nas_otk_gaza,
};

public gTags[] group_com = {
gTags.kom_stol_abs,
gTags.kom_tp_pusk,
gTags.kom_tp_prer,
gTags.kom_kar_abs,
gTags.kom_stol_stop,
gTags.kom_karetka_stop,
gTags.kom_karetka_sbros,
gTags.kom_stol_sbros,
gTags.kom_stol_ust_nulya,
gTags.kom_stol_otn_pusk_vniz,
gTags.kom_stol_otn_pusk_vverh,
gTags.kom_sloj,
gTags.kom_prer,
gTags.kom_rezerv,
gTags.kom_rezerv_1,
gTags.kom_rezerv_2,
gTags.kom_obnulit_linejku,
gTags.kom_pit_tjen3,
gTags.kom_pit_tjen1,
gTags.kom_pit_tjen2,
gTags.kom_stol_poisk_nulya,
gTags.kom_process,
gTags.kom_proc_obshh,
gTags.kom_pereschjot,
gTags.kom_pit_laz,
gTags.kom_got_laz,
gTags.kom_sloj_sbros_schjotchika,
gTags.kom_pauza,
gTags.kom_rab_do_pauzy,
gTags.kom_dozator_avtomat,
gTags.kom_pit_chil1,
gTags.kom_pit_chil2,
gTags.kom_kl_chil1,
gTags.kom_kl_chil2,
gTags.kom_pit_rec,
gTags.kom_pit_mps,
gTags.kom_kar_lev_sh1_vperjod,
gTags.kom_kar_lev_sh1_nazad,
gTags.kom_kar_lev_sh1_abs,
gTags.kom_kar_lev_sh1_stop,
gTags.kom_kar_prav_sh2_vperjod,
gTags.kom_kar_prav_sh2_nazad,
gTags.kom_kar_prav_sh2_abs,
gTags.kom_kar_prav_sh2_stop,
gTags.kom_bar_prav_sh3_vperjod,
gTags.kom_bar_prav_sh3_nazad,
gTags.kom_bar_prav_sh3_abs,
gTags.kom_bar_prav_sh3_stop,
gTags.kom_bar_lev_sh4_vperjod,
gTags.kom_bar_lev_sh4_nazad,
gTags.kom_bar_lev_sh4_abs,
gTags.kom_bar_lev_sh4_stop,
gTags.kom_dozator_lev_vper,
gTags.kom_dozator_prav_vper,
gTags.kom_tolkatel_lev_vperjod,
gTags.kom_tolkatel_lev_nazad,
gTags.kom_tolkatel_prav_vperjod,
gTags.kom_tolkatel_prav_nazad,
gTags.kom_dozator_lev_nazad,
gTags.kom_dozator_prav_nazad,
gTags.kom_kje9,
gTags.kom_kje10,
gTags.kom_kv1,
gTags.kom_kv2,
gTags.kom_kl_bar_lev,
gTags.kom_kl_bar_prav,
gTags.kom_nas_otk_gaza,
};

//-----------------------------------------------------------------------------
//tags/usta.xml
//-----------------------------------------------------------------------------
// уст стол позиция,   Real, %MD136   reg = M  width = UInt32
    public float get_ust_stol_poziciya ()
    { return (float) m_mem.getMFloat(136); }

    public void set_ust_stol_poziciya (float val)
    { m_mem.setMFloat(136, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_poziciya to " + val.ToString());}

    public bool sets_ust_stol_poziciya ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_poziciya (val);
    return true;}

    public string gets_ust_stol_poziciya () { 
    return get_ust_stol_poziciya().ToString();}

    public string debug_name_ust_stol_poziciya () { 
    return "уст стол позиция";}

// уст стол скор вверх,   Real, %MD108   reg = M  width = UInt32
    public float get_ust_stol_skor_vverh ()
    { return (float) m_mem.getMFloat(108); }

    public void set_ust_stol_skor_vverh (float val)
    { m_mem.setMFloat(108, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_skor_vverh to " + val.ToString());}

    public bool sets_ust_stol_skor_vverh ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_skor_vverh (val);
    return true;}

    public string gets_ust_stol_skor_vverh () { 
    return get_ust_stol_skor_vverh().ToString();}

    public string debug_name_ust_stol_skor_vverh () { 
    return "уст стол скор вверх";}

// уст стол отн расст,   Real, %MD148   reg = M  width = UInt32
    public float get_ust_stol_otn_rasst ()
    { return (float) m_mem.getMFloat(148); }

    public void set_ust_stol_otn_rasst (float val)
    { m_mem.setMFloat(148, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_otn_rasst to " + val.ToString());}

    public bool sets_ust_stol_otn_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_otn_rasst (val);
    return true;}

    public string gets_ust_stol_otn_rasst () { 
    return get_ust_stol_otn_rasst().ToString();}

    public string debug_name_ust_stol_otn_rasst () { 
    return "уст стол отн расст";}

// уст слой кар лев начало,   Real, %MD132   reg = M  width = UInt32
    public float get_ust_sloj_kar_lev_nachalo ()
    { return (float) m_mem.getMFloat(132); }

    public void set_ust_sloj_kar_lev_nachalo (float val)
    { m_mem.setMFloat(132, (float) val); 
      Log.Write(LogLevel.Info, "set ust_sloj_kar_lev_nachalo to " + val.ToString());}

    public bool sets_ust_sloj_kar_lev_nachalo ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_sloj_kar_lev_nachalo (val);
    return true;}

    public string gets_ust_sloj_kar_lev_nachalo () { 
    return get_ust_sloj_kar_lev_nachalo().ToString();}

    public string debug_name_ust_sloj_kar_lev_nachalo () { 
    return "уст слой кар лев начало";}

// уст слой кар лев конец,   Real, %MD144   reg = M  width = UInt32
    public float get_ust_sloj_kar_lev_konec ()
    { return (float) m_mem.getMFloat(144); }

    public void set_ust_sloj_kar_lev_konec (float val)
    { m_mem.setMFloat(144, (float) val); 
      Log.Write(LogLevel.Info, "set ust_sloj_kar_lev_konec to " + val.ToString());}

    public bool sets_ust_sloj_kar_lev_konec ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_sloj_kar_lev_konec (val);
    return true;}

    public string gets_ust_sloj_kar_lev_konec () { 
    return get_ust_sloj_kar_lev_konec().ToString();}

    public string debug_name_ust_sloj_kar_lev_konec () { 
    return "уст слой кар лев конец";}

// уст толщ слоя,   Real, %MD180   reg = M  width = UInt32
    public float get_ust_tolshh_sloya ()
    { return (float) m_mem.getMFloat(180); }

    public void set_ust_tolshh_sloya (float val)
    { m_mem.setMFloat(180, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolshh_sloya to " + val.ToString());}

    public bool sets_ust_tolshh_sloya ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolshh_sloya (val);
    return true;}

    public string gets_ust_tolshh_sloya () { 
    return get_ust_tolshh_sloya().ToString();}

    public string debug_name_ust_tolshh_sloya () { 
    return "уст толщ слоя";}

// уст стол отн расст авто,   Real, %MD204   reg = M  width = UInt32
    public float get_ust_stol_otn_rasst_avto ()
    { return (float) m_mem.getMFloat(204); }

    public void set_ust_stol_otn_rasst_avto (float val)
    { m_mem.setMFloat(204, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_otn_rasst_avto to " + val.ToString());}

    public bool sets_ust_stol_otn_rasst_avto ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_otn_rasst_avto (val);
    return true;}

    public string gets_ust_stol_otn_rasst_avto () { 
    return get_ust_stol_otn_rasst_avto().ToString();}

    public string debug_name_ust_stol_otn_rasst_avto () { 
    return "уст стол отн расст авто";}

// уст ТЭН1 мощн,   Real, %MD276   reg = M  width = UInt32
    public float get_ust_tjen1_moshhn ()
    { return (float) m_mem.getMFloat(276); }

    public void set_ust_tjen1_moshhn (float val)
    { m_mem.setMFloat(276, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen1_moshhn to " + val.ToString());}

    public bool sets_ust_tjen1_moshhn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen1_moshhn (val);
    return true;}

    public string gets_ust_tjen1_moshhn () { 
    return get_ust_tjen1_moshhn().ToString();}

    public string debug_name_ust_tjen1_moshhn () { 
    return "уст ТЭН1 мощн";}

// уст ТЭН2 мощн,   Real, %MD280   reg = M  width = UInt32
    public float get_ust_tjen2_moshhn ()
    { return (float) m_mem.getMFloat(280); }

    public void set_ust_tjen2_moshhn (float val)
    { m_mem.setMFloat(280, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen2_moshhn to " + val.ToString());}

    public bool sets_ust_tjen2_moshhn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen2_moshhn (val);
    return true;}

    public string gets_ust_tjen2_moshhn () { 
    return get_ust_tjen2_moshhn().ToString();}

    public string debug_name_ust_tjen2_moshhn () { 
    return "уст ТЭН2 мощн";}

// уст ТЭН3 мощн,   Real, %MD284   reg = M  width = UInt32
    public float get_ust_tjen3_moshhn ()
    { return (float) m_mem.getMFloat(284); }

    public void set_ust_tjen3_moshhn (float val)
    { m_mem.setMFloat(284, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen3_moshhn to " + val.ToString());}

    public bool sets_ust_tjen3_moshhn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen3_moshhn (val);
    return true;}

    public string gets_ust_tjen3_moshhn () { 
    return get_ust_tjen3_moshhn().ToString();}

    public string debug_name_ust_tjen3_moshhn () { 
    return "уст ТЭН3 мощн";}

// уст кол слоёв для доз прав,   Int, %MW292   reg = M  width = UInt16
    public Int16 get_ust_kol_slojov_dlya_doz_prav ()
    { return (Int16) m_mem.getMUInt16(292); }

    public void set_ust_kol_slojov_dlya_doz_prav (Int16 val)
    { m_mem.setMUInt16(292, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ust_kol_slojov_dlya_doz_prav to " + val.ToString());}

    public bool sets_ust_kol_slojov_dlya_doz_prav ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ust_kol_slojov_dlya_doz_prav (val);
    return true;}

    public string gets_ust_kol_slojov_dlya_doz_prav () { 
    return get_ust_kol_slojov_dlya_doz_prav().ToString();}

    public string debug_name_ust_kol_slojov_dlya_doz_prav () { 
    return "уст кол слоёв для доз прав";}

// уст кол слоёв для доз лев,   Int, %MW294   reg = M  width = UInt16
    public Int16 get_ust_kol_slojov_dlya_doz_lev ()
    { return (Int16) m_mem.getMUInt16(294); }

    public void set_ust_kol_slojov_dlya_doz_lev (Int16 val)
    { m_mem.setMUInt16(294, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ust_kol_slojov_dlya_doz_lev to " + val.ToString());}

    public bool sets_ust_kol_slojov_dlya_doz_lev ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ust_kol_slojov_dlya_doz_lev (val);
    return true;}

    public string gets_ust_kol_slojov_dlya_doz_lev () { 
    return get_ust_kol_slojov_dlya_doz_lev().ToString();}

    public string debug_name_ust_kol_slojov_dlya_doz_lev () { 
    return "уст кол слоёв для доз лев";}

// уст ТЭН1 темп,   Real, %MD288   reg = M  width = UInt32
    public float get_ust_tjen1_temp ()
    { return (float) m_mem.getMFloat(288); }

    public void set_ust_tjen1_temp (float val)
    { m_mem.setMFloat(288, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen1_temp to " + val.ToString());}

    public bool sets_ust_tjen1_temp ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen1_temp (val);
    return true;}

    public string gets_ust_tjen1_temp () { 
    return get_ust_tjen1_temp().ToString();}

    public string debug_name_ust_tjen1_temp () { 
    return "уст ТЭН1 темп";}

// уст ТЭН2 темп,   Real, %MD296   reg = M  width = UInt32
    public float get_ust_tjen2_temp ()
    { return (float) m_mem.getMFloat(296); }

    public void set_ust_tjen2_temp (float val)
    { m_mem.setMFloat(296, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen2_temp to " + val.ToString());}

    public bool sets_ust_tjen2_temp ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen2_temp (val);
    return true;}

    public string gets_ust_tjen2_temp () { 
    return get_ust_tjen2_temp().ToString();}

    public string debug_name_ust_tjen2_temp () { 
    return "уст ТЭН2 темп";}

// уст ТЭН3 темп,   Real, %MD300   reg = M  width = UInt32
    public float get_ust_tjen3_temp ()
    { return (float) m_mem.getMFloat(300); }

    public void set_ust_tjen3_temp (float val)
    { m_mem.setMFloat(300, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen3_temp to " + val.ToString());}

    public bool sets_ust_tjen3_temp ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen3_temp (val);
    return true;}

    public string gets_ust_tjen3_temp () { 
    return get_ust_tjen3_temp().ToString();}

    public string debug_name_ust_tjen3_temp () { 
    return "уст ТЭН3 темп";}

// уст кар лев скор,   Real, %MD304   reg = M  width = UInt32
    public float get_ust_kar_lev_skor ()
    { return (float) m_mem.getMFloat(304); }

    public void set_ust_kar_lev_skor (float val)
    { m_mem.setMFloat(304, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_lev_skor to " + val.ToString());}

    public bool sets_ust_kar_lev_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_lev_skor (val);
    return true;}

    public string gets_ust_kar_lev_skor () { 
    return get_ust_kar_lev_skor().ToString();}

    public string debug_name_ust_kar_lev_skor () { 
    return "уст кар лев скор";}

// уст кар лев раст,   Real, %MD308   reg = M  width = UInt32
    public float get_ust_kar_lev_rast ()
    { return (float) m_mem.getMFloat(308); }

    public void set_ust_kar_lev_rast (float val)
    { m_mem.setMFloat(308, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_lev_rast to " + val.ToString());}

    public bool sets_ust_kar_lev_rast ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_lev_rast (val);
    return true;}

    public string gets_ust_kar_lev_rast () { 
    return get_ust_kar_lev_rast().ToString();}

    public string debug_name_ust_kar_lev_rast () { 
    return "уст кар лев раст";}

// уст кар лев поз,   Real, %MD312   reg = M  width = UInt32
    public float get_ust_kar_lev_poz ()
    { return (float) m_mem.getMFloat(312); }

    public void set_ust_kar_lev_poz (float val)
    { m_mem.setMFloat(312, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_lev_poz to " + val.ToString());}

    public bool sets_ust_kar_lev_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_lev_poz (val);
    return true;}

    public string gets_ust_kar_lev_poz () { 
    return get_ust_kar_lev_poz().ToString();}

    public string debug_name_ust_kar_lev_poz () { 
    return "уст кар лев поз";}

// уст кар прав скор,   Real, %MD316   reg = M  width = UInt32
    public float get_ust_kar_prav_skor ()
    { return (float) m_mem.getMFloat(316); }

    public void set_ust_kar_prav_skor (float val)
    { m_mem.setMFloat(316, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_prav_skor to " + val.ToString());}

    public bool sets_ust_kar_prav_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_prav_skor (val);
    return true;}

    public string gets_ust_kar_prav_skor () { 
    return get_ust_kar_prav_skor().ToString();}

    public string debug_name_ust_kar_prav_skor () { 
    return "уст кар прав скор";}

// уст кар прав раст,   Real, %MD320   reg = M  width = UInt32
    public float get_ust_kar_prav_rast ()
    { return (float) m_mem.getMFloat(320); }

    public void set_ust_kar_prav_rast (float val)
    { m_mem.setMFloat(320, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_prav_rast to " + val.ToString());}

    public bool sets_ust_kar_prav_rast ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_prav_rast (val);
    return true;}

    public string gets_ust_kar_prav_rast () { 
    return get_ust_kar_prav_rast().ToString();}

    public string debug_name_ust_kar_prav_rast () { 
    return "уст кар прав раст";}

// уст кар прав поз,   Real, %MD324   reg = M  width = UInt32
    public float get_ust_kar_prav_poz ()
    { return (float) m_mem.getMFloat(324); }

    public void set_ust_kar_prav_poz (float val)
    { m_mem.setMFloat(324, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_prav_poz to " + val.ToString());}

    public bool sets_ust_kar_prav_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_prav_poz (val);
    return true;}

    public string gets_ust_kar_prav_poz () { 
    return get_ust_kar_prav_poz().ToString();}

    public string debug_name_ust_kar_prav_poz () { 
    return "уст кар прав поз";}

// уст бар прав скор,   Real, %MD328   reg = M  width = UInt32
    public float get_ust_bar_prav_skor ()
    { return (float) m_mem.getMFloat(328); }

    public void set_ust_bar_prav_skor (float val)
    { m_mem.setMFloat(328, (float) val); 
      Log.Write(LogLevel.Info, "set ust_bar_prav_skor to " + val.ToString());}

    public bool sets_ust_bar_prav_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_bar_prav_skor (val);
    return true;}

    public string gets_ust_bar_prav_skor () { 
    return get_ust_bar_prav_skor().ToString();}

    public string debug_name_ust_bar_prav_skor () { 
    return "уст бар прав скор";}

// уст бар лев скор,   Real, %MD340   reg = M  width = UInt32
    public float get_ust_bar_lev_skor ()
    { return (float) m_mem.getMFloat(340); }

    public void set_ust_bar_lev_skor (float val)
    { m_mem.setMFloat(340, (float) val); 
      Log.Write(LogLevel.Info, "set ust_bar_lev_skor to " + val.ToString());}

    public bool sets_ust_bar_lev_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_bar_lev_skor (val);
    return true;}

    public string gets_ust_bar_lev_skor () { 
    return get_ust_bar_lev_skor().ToString();}

    public string debug_name_ust_bar_lev_skor () { 
    return "уст бар лев скор";}

// уст доз лев время,   Real, %MD352   reg = M  width = UInt32
    public float get_ust_doz_lev_vremya ()
    { return (float) m_mem.getMFloat(352); }

    public void set_ust_doz_lev_vremya (float val)
    { m_mem.setMFloat(352, (float) val); 
      Log.Write(LogLevel.Info, "set ust_doz_lev_vremya to " + val.ToString());}

    public bool sets_ust_doz_lev_vremya ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_doz_lev_vremya (val);
    return true;}

    public string gets_ust_doz_lev_vremya () { 
    return get_ust_doz_lev_vremya().ToString();}

    public string debug_name_ust_doz_lev_vremya () { 
    return "уст доз лев время";}

// уст доз прав время,   Real, %MD356   reg = M  width = UInt32
    public float get_ust_doz_prav_vremya ()
    { return (float) m_mem.getMFloat(356); }

    public void set_ust_doz_prav_vremya (float val)
    { m_mem.setMFloat(356, (float) val); 
      Log.Write(LogLevel.Info, "set ust_doz_prav_vremya to " + val.ToString());}

    public bool sets_ust_doz_prav_vremya ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_doz_prav_vremya (val);
    return true;}

    public string gets_ust_doz_prav_vremya () { 
    return get_ust_doz_prav_vremya().ToString();}

    public string debug_name_ust_doz_prav_vremya () { 
    return "уст доз прав время";}

// уст толк лев расст,   Real, %MD360   reg = M  width = UInt32
    public float get_ust_tolk_lev_rasst ()
    { return (float) m_mem.getMFloat(360); }

    public void set_ust_tolk_lev_rasst (float val)
    { m_mem.setMFloat(360, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolk_lev_rasst to " + val.ToString());}

    public bool sets_ust_tolk_lev_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolk_lev_rasst (val);
    return true;}

    public string gets_ust_tolk_lev_rasst () { 
    return get_ust_tolk_lev_rasst().ToString();}

    public string debug_name_ust_tolk_lev_rasst () { 
    return "уст толк лев расст";}

// уст толк прав расст,   Real, %MD364   reg = M  width = UInt32
    public float get_ust_tolk_prav_rasst ()
    { return (float) m_mem.getMFloat(364); }

    public void set_ust_tolk_prav_rasst (float val)
    { m_mem.setMFloat(364, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolk_prav_rasst to " + val.ToString());}

    public bool sets_ust_tolk_prav_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolk_prav_rasst (val);
    return true;}

    public string gets_ust_tolk_prav_rasst () { 
    return get_ust_tolk_prav_rasst().ToString();}

    public string debug_name_ust_tolk_prav_rasst () { 
    return "уст толк прав расст";}

// уст доз прав скор,   Real, %MD368   reg = M  width = UInt32
    public float get_ust_doz_prav_skor ()
    { return (float) m_mem.getMFloat(368); }

    public void set_ust_doz_prav_skor (float val)
    { m_mem.setMFloat(368, (float) val); 
      Log.Write(LogLevel.Info, "set ust_doz_prav_skor to " + val.ToString());}

    public bool sets_ust_doz_prav_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_doz_prav_skor (val);
    return true;}

    public string gets_ust_doz_prav_skor () { 
    return get_ust_doz_prav_skor().ToString();}

    public string debug_name_ust_doz_prav_skor () { 
    return "уст доз прав скор";}

// уст доз лев скор,   Real, %MD372   reg = M  width = UInt32
    public float get_ust_doz_lev_skor ()
    { return (float) m_mem.getMFloat(372); }

    public void set_ust_doz_lev_skor (float val)
    { m_mem.setMFloat(372, (float) val); 
      Log.Write(LogLevel.Info, "set ust_doz_lev_skor to " + val.ToString());}

    public bool sets_ust_doz_lev_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_doz_lev_skor (val);
    return true;}

    public string gets_ust_doz_lev_skor () { 
    return get_ust_doz_lev_skor().ToString();}

    public string debug_name_ust_doz_lev_skor () { 
    return "уст доз лев скор";}

// уст толк лев скор,   Real, %MD376   reg = M  width = UInt32
    public float get_ust_tolk_lev_skor ()
    { return (float) m_mem.getMFloat(376); }

    public void set_ust_tolk_lev_skor (float val)
    { m_mem.setMFloat(376, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolk_lev_skor to " + val.ToString());}

    public bool sets_ust_tolk_lev_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolk_lev_skor (val);
    return true;}

    public string gets_ust_tolk_lev_skor () { 
    return get_ust_tolk_lev_skor().ToString();}

    public string debug_name_ust_tolk_lev_skor () { 
    return "уст толк лев скор";}

// уст толк прав скор,   Real, %MD380   reg = M  width = UInt32
    public float get_ust_tolk_prav_skor ()
    { return (float) m_mem.getMFloat(380); }

    public void set_ust_tolk_prav_skor (float val)
    { m_mem.setMFloat(380, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolk_prav_skor to " + val.ToString());}

    public bool sets_ust_tolk_prav_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolk_prav_skor (val);
    return true;}

    public string gets_ust_tolk_prav_skor () { 
    return get_ust_tolk_prav_skor().ToString();}

    public string debug_name_ust_tolk_prav_skor () { 
    return "уст толк прав скор";}

// уст слой кар прав начало,   Real, %MD152   reg = M  width = UInt32
    public float get_ust_sloj_kar_prav_nachalo ()
    { return (float) m_mem.getMFloat(152); }

    public void set_ust_sloj_kar_prav_nachalo (float val)
    { m_mem.setMFloat(152, (float) val); 
      Log.Write(LogLevel.Info, "set ust_sloj_kar_prav_nachalo to " + val.ToString());}

    public bool sets_ust_sloj_kar_prav_nachalo ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_sloj_kar_prav_nachalo (val);
    return true;}

    public string gets_ust_sloj_kar_prav_nachalo () { 
    return get_ust_sloj_kar_prav_nachalo().ToString();}

    public string debug_name_ust_sloj_kar_prav_nachalo () { 
    return "уст слой кар прав начало";}

// уст слой кар прав конец,   Real, %MD156   reg = M  width = UInt32
    public float get_ust_sloj_kar_prav_konec ()
    { return (float) m_mem.getMFloat(156); }

    public void set_ust_sloj_kar_prav_konec (float val)
    { m_mem.setMFloat(156, (float) val); 
      Log.Write(LogLevel.Info, "set ust_sloj_kar_prav_konec to " + val.ToString());}

    public bool sets_ust_sloj_kar_prav_konec ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_sloj_kar_prav_konec (val);
    return true;}

    public string gets_ust_sloj_kar_prav_konec () { 
    return get_ust_sloj_kar_prav_konec().ToString();}

    public string debug_name_ust_sloj_kar_prav_konec () { 
    return "уст слой кар прав конец";}

public enum local_usta{
ust_stol_poziciya,
ust_stol_skor_vverh,
ust_stol_otn_rasst,
ust_sloj_kar_lev_nachalo,
ust_sloj_kar_lev_konec,
ust_tolshh_sloya,
ust_stol_otn_rasst_avto,
ust_tjen1_moshhn,
ust_tjen2_moshhn,
ust_tjen3_moshhn,
ust_kol_slojov_dlya_doz_prav,
ust_kol_slojov_dlya_doz_lev,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
ust_kar_lev_skor,
ust_kar_lev_rast,
ust_kar_lev_poz,
ust_kar_prav_skor,
ust_kar_prav_rast,
ust_kar_prav_poz,
ust_bar_prav_skor,
ust_bar_lev_skor,
ust_doz_lev_vremya,
ust_doz_prav_vremya,
ust_tolk_lev_rasst,
ust_tolk_prav_rasst,
ust_doz_prav_skor,
ust_doz_lev_skor,
ust_tolk_lev_skor,
ust_tolk_prav_skor,
ust_sloj_kar_prav_nachalo,
ust_sloj_kar_prav_konec,
};

public gTags[] group_usta = {
gTags.ust_stol_poziciya,
gTags.ust_stol_skor_vverh,
gTags.ust_stol_otn_rasst,
gTags.ust_sloj_kar_lev_nachalo,
gTags.ust_sloj_kar_lev_konec,
gTags.ust_tolshh_sloya,
gTags.ust_stol_otn_rasst_avto,
gTags.ust_tjen1_moshhn,
gTags.ust_tjen2_moshhn,
gTags.ust_tjen3_moshhn,
gTags.ust_kol_slojov_dlya_doz_prav,
gTags.ust_kol_slojov_dlya_doz_lev,
gTags.ust_tjen1_temp,
gTags.ust_tjen2_temp,
gTags.ust_tjen3_temp,
gTags.ust_kar_lev_skor,
gTags.ust_kar_lev_rast,
gTags.ust_kar_lev_poz,
gTags.ust_kar_prav_skor,
gTags.ust_kar_prav_rast,
gTags.ust_kar_prav_poz,
gTags.ust_bar_prav_skor,
gTags.ust_bar_lev_skor,
gTags.ust_doz_lev_vremya,
gTags.ust_doz_prav_vremya,
gTags.ust_tolk_lev_rasst,
gTags.ust_tolk_prav_rasst,
gTags.ust_doz_prav_skor,
gTags.ust_doz_lev_skor,
gTags.ust_tolk_lev_skor,
gTags.ust_tolk_prav_skor,
gTags.ust_sloj_kar_prav_nachalo,
gTags.ust_sloj_kar_prav_konec,
};

//-----------------------------------------------------------------------------
//tags/dm.xml
//-----------------------------------------------------------------------------
// стол раб,   Bool, %M514.5   reg = M  width = Bit
    public bool get_stol_rab ()
    { return (bool) m_mem.getMBit(514, 5); }

    public void set_stol_rab (bool val)
    { m_mem.setMBit(514, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_rab to " + val.ToString());}

    public bool sets_stol_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_rab (val);
    return true;}

    public string gets_stol_rab () { 
    return get_stol_rab().ToString();}

    public string debug_name_stol_rab () { 
    return "стол раб";}

// тп раб,   Bool, %M516.3   reg = M  width = Bit
    public bool get_tp_rab ()
    { return (bool) m_mem.getMBit(516, 3); }

    public void set_tp_rab (bool val)
    { m_mem.setMBit(516, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set tp_rab to " + val.ToString());}

    public bool sets_tp_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_tp_rab (val);
    return true;}

    public string gets_tp_rab () { 
    return get_tp_rab().ToString();}

    public string debug_name_tp_rab () { 
    return "тп раб";}

// тп зав,   Bool, %M516.4   reg = M  width = Bit
    public bool get_tp_zav ()
    { return (bool) m_mem.getMBit(516, 4); }

    public void set_tp_zav (bool val)
    { m_mem.setMBit(516, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set tp_zav to " + val.ToString());}

    public bool sets_tp_zav ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_tp_zav (val);
    return true;}

    public string gets_tp_zav () { 
    return get_tp_zav().ToString();}

    public string debug_name_tp_zav () { 
    return "тп зав";}

// стол наверху,   Bool, %M516.6   reg = M  width = Bit
    public bool get_stol_naverhu ()
    { return (bool) m_mem.getMBit(516, 6); }

    public void set_stol_naverhu (bool val)
    { m_mem.setMBit(516, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_naverhu to " + val.ToString());}

    public bool sets_stol_naverhu ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_naverhu (val);
    return true;}

    public string gets_stol_naverhu () { 
    return get_stol_naverhu().ToString();}

    public string debug_name_stol_naverhu () { 
    return "стол наверху";}

// стол внизу,   Bool, %M516.7   reg = M  width = Bit
    public bool get_stol_vnizu ()
    { return (bool) m_mem.getMBit(516, 7); }

    public void set_stol_vnizu (bool val)
    { m_mem.setMBit(516, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_vnizu to " + val.ToString());}

    public bool sets_stol_vnizu ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_vnizu (val);
    return true;}

    public string gets_stol_vnizu () { 
    return get_stol_vnizu().ToString();}

    public string debug_name_stol_vnizu () { 
    return "стол внизу";}

// стол дом зав,   Bool, %M521.1   reg = M  width = Bit
    public bool get_stol_dom_zav ()
    { return (bool) m_mem.getMBit(521, 1); }

    public void set_stol_dom_zav (bool val)
    { m_mem.setMBit(521, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_dom_zav to " + val.ToString());}

    public bool sets_stol_dom_zav ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_dom_zav (val);
    return true;}

    public string gets_stol_dom_zav () { 
    return get_stol_dom_zav().ToString();}

    public string debug_name_stol_dom_zav () { 
    return "стол дом зав";}

// слой раб,   Bool, %M522.0   reg = M  width = Bit
    public bool get_sloj_rab ()
    { return (bool) m_mem.getMBit(522, 0); }

    public void set_sloj_rab (bool val)
    { m_mem.setMBit(522, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set sloj_rab to " + val.ToString());}

    public bool sets_sloj_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_sloj_rab (val);
    return true;}

    public string gets_sloj_rab () { 
    return get_sloj_rab().ToString();}

    public string debug_name_sloj_rab () { 
    return "слой раб";}

// кар дом гот,   Bool, %M522.1   reg = M  width = Bit
    public bool get_kar_dom_got ()
    { return (bool) m_mem.getMBit(522, 1); }

    public void set_kar_dom_got (bool val)
    { m_mem.setMBit(522, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kar_dom_got to " + val.ToString());}

    public bool sets_kar_dom_got ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kar_dom_got (val);
    return true;}

    public string gets_kar_dom_got () { 
    return get_kar_dom_got().ToString();}

    public string debug_name_kar_dom_got () { 
    return "кар дом гот";}

// кар на поз,   Bool, %M522.5   reg = M  width = Bit
    public bool get_kar_na_poz ()
    { return (bool) m_mem.getMBit(522, 5); }

    public void set_kar_na_poz (bool val)
    { m_mem.setMBit(522, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kar_na_poz to " + val.ToString());}

    public bool sets_kar_na_poz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kar_na_poz (val);
    return true;}

    public string gets_kar_na_poz () { 
    return get_kar_na_poz().ToString();}

    public string debug_name_kar_na_poz () { 
    return "кар на поз";}

// процесс,   Bool, %M518.5   reg = M  width = Bit
    public bool get_process ()
    { return (bool) m_mem.getMBit(518, 5); }

    public void set_process (bool val)
    { m_mem.setMBit(518, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set process to " + val.ToString());}

    public bool sets_process ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_process (val);
    return true;}

    public string gets_process () { 
    return get_process().ToString();}

    public string debug_name_process () { 
    return "процесс";}

// стол на поз,   Bool, %M514.7   reg = M  width = Bit
    public bool get_stol_na_poz ()
    { return (bool) m_mem.getMBit(514, 7); }

    public void set_stol_na_poz (bool val)
    { m_mem.setMBit(514, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_na_poz to " + val.ToString());}

    public bool sets_stol_na_poz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_na_poz (val);
    return true;}

    public string gets_stol_na_poz () { 
    return get_stol_na_poz().ToString();}

    public string debug_name_stol_na_poz () { 
    return "стол на поз";}

// стол гот,   Bool, %M515.0   reg = M  width = Bit
    public bool get_stol_got ()
    { return (bool) m_mem.getMBit(515, 0); }

    public void set_stol_got (bool val)
    { m_mem.setMBit(515, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_got to " + val.ToString());}

    public bool sets_stol_got ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_got (val);
    return true;}

    public string gets_stol_got () { 
    return get_stol_got().ToString();}

    public string debug_name_stol_got () { 
    return "стол гот";}

// проц общ раб,   Bool, %M515.1   reg = M  width = Bit
    public bool get_proc_obshh_rab ()
    { return (bool) m_mem.getMBit(515, 1); }

    public void set_proc_obshh_rab (bool val)
    { m_mem.setMBit(515, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set proc_obshh_rab to " + val.ToString());}

    public bool sets_proc_obshh_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_proc_obshh_rab (val);
    return true;}

    public string gets_proc_obshh_rab () { 
    return get_proc_obshh_rab().ToString();}

    public string debug_name_proc_obshh_rab () { 
    return "проц общ раб";}

// стол отн гот,   Bool, %M515.2   reg = M  width = Bit
    public bool get_stol_otn_got ()
    { return (bool) m_mem.getMBit(515, 2); }

    public void set_stol_otn_got (bool val)
    { m_mem.setMBit(515, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_otn_got to " + val.ToString());}

    public bool sets_stol_otn_got ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_otn_got (val);
    return true;}

    public string gets_stol_otn_got () { 
    return get_stol_otn_got().ToString();}

    public string debug_name_stol_otn_got () { 
    return "стол отн гот";}

// прожиг раб,   Bool, %M511.7   reg = M  width = Bit
    public bool get_prozhig_rab ()
    { return (bool) m_mem.getMBit(511, 7); }

    public void set_prozhig_rab (bool val)
    { m_mem.setMBit(511, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set prozhig_rab to " + val.ToString());}

    public bool sets_prozhig_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prozhig_rab (val);
    return true;}

    public string gets_prozhig_rab () { 
    return get_prozhig_rab().ToString();}

    public string debug_name_prozhig_rab () { 
    return "прожиг раб";}

// слои непр раб,   Bool, %M512.0   reg = M  width = Bit
    public bool get_sloi_nepr_rab ()
    { return (bool) m_mem.getMBit(512, 0); }

    public void set_sloi_nepr_rab (bool val)
    { m_mem.setMBit(512, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set sloi_nepr_rab to " + val.ToString());}

    public bool sets_sloi_nepr_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_sloi_nepr_rab (val);
    return true;}

    public string gets_sloi_nepr_rab () { 
    return get_sloi_nepr_rab().ToString();}

    public string debug_name_sloi_nepr_rab () { 
    return "слои непр раб";}

// стол отн раб,   Bool, %M526.6   reg = M  width = Bit
    public bool get_stol_otn_rab ()
    { return (bool) m_mem.getMBit(526, 6); }

    public void set_stol_otn_rab (bool val)
    { m_mem.setMBit(526, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set stol_otn_rab to " + val.ToString());}

    public bool sets_stol_otn_rab ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_stol_otn_rab (val);
    return true;}

    public string gets_stol_otn_rab () { 
    return get_stol_otn_rab().ToString();}

    public string debug_name_stol_otn_rab () { 
    return "стол отн раб";}

// Расход1-1,   Bool, %M528.6   reg = M  width = Bit
    public bool get_rashod1_1 ()
    { return (bool) m_mem.getMBit(528, 6); }

    public void set_rashod1_1 (bool val)
    { m_mem.setMBit(528, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set rashod1_1 to " + val.ToString());}

    public bool sets_rashod1_1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_rashod1_1 (val);
    return true;}

    public string gets_rashod1_1 () { 
    return get_rashod1_1().ToString();}

    public string debug_name_rashod1_1 () { 
    return "Расход1-1";}

// Расход1-2,   Bool, %M528.7   reg = M  width = Bit
    public bool get_rashod1_2 ()
    { return (bool) m_mem.getMBit(528, 7); }

    public void set_rashod1_2 (bool val)
    { m_mem.setMBit(528, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set rashod1_2 to " + val.ToString());}

    public bool sets_rashod1_2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_rashod1_2 (val);
    return true;}

    public string gets_rashod1_2 () { 
    return get_rashod1_2().ToString();}

    public string debug_name_rashod1_2 () { 
    return "Расход1-2";}

// Расход2-1,   Bool, %M529.0   reg = M  width = Bit
    public bool get_rashod2_1 ()
    { return (bool) m_mem.getMBit(529, 0); }

    public void set_rashod2_1 (bool val)
    { m_mem.setMBit(529, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set rashod2_1 to " + val.ToString());}

    public bool sets_rashod2_1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_rashod2_1 (val);
    return true;}

    public string gets_rashod2_1 () { 
    return get_rashod2_1().ToString();}

    public string debug_name_rashod2_1 () { 
    return "Расход2-1";}

// Расход2-2,   Bool, %M529.1   reg = M  width = Bit
    public bool get_rashod2_2 ()
    { return (bool) m_mem.getMBit(529, 1); }

    public void set_rashod2_2 (bool val)
    { m_mem.setMBit(529, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set rashod2_2 to " + val.ToString());}

    public bool sets_rashod2_2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_rashod2_2 (val);
    return true;}

    public string gets_rashod2_2 () { 
    return get_rashod2_2().ToString();}

    public string debug_name_rashod2_2 () { 
    return "Расход2-2";}

// прот1,   Bool, %M532.5   reg = M  width = Bit
    public bool get_prot1 ()
    { return (bool) m_mem.getMBit(532, 5); }

    public void set_prot1 (bool val)
    { m_mem.setMBit(532, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set prot1 to " + val.ToString());}

    public bool sets_prot1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prot1 (val);
    return true;}

    public string gets_prot1 () { 
    return get_prot1().ToString();}

    public string debug_name_prot1 () { 
    return "прот1";}

// прот2,   Bool, %M532.6   reg = M  width = Bit
    public bool get_prot2 ()
    { return (bool) m_mem.getMBit(532, 6); }

    public void set_prot2 (bool val)
    { m_mem.setMBit(532, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set prot2 to " + val.ToString());}

    public bool sets_prot2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prot2 (val);
    return true;}

    public string gets_prot2 () { 
    return get_prot2().ToString();}

    public string debug_name_prot2 () { 
    return "прот2";}

// прот3,   Bool, %M534.4   reg = M  width = Bit
    public bool get_prot3 ()
    { return (bool) m_mem.getMBit(534, 4); }

    public void set_prot3 (bool val)
    { m_mem.setMBit(534, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set prot3 to " + val.ToString());}

    public bool sets_prot3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prot3 (val);
    return true;}

    public string gets_prot3 () { 
    return get_prot3().ToString();}

    public string debug_name_prot3 () { 
    return "прот3";}

// прот4,   Bool, %M534.5   reg = M  width = Bit
    public bool get_prot4 ()
    { return (bool) m_mem.getMBit(534, 5); }

    public void set_prot4 (bool val)
    { m_mem.setMBit(534, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set prot4 to " + val.ToString());}

    public bool sets_prot4 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prot4 (val);
    return true;}

    public string gets_prot4 () { 
    return get_prot4().ToString();}

    public string debug_name_prot4 () { 
    return "прот4";}

// прот5,   Bool, %M534.6   reg = M  width = Bit
    public bool get_prot5 ()
    { return (bool) m_mem.getMBit(534, 6); }

    public void set_prot5 (bool val)
    { m_mem.setMBit(534, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set prot5 to " + val.ToString());}

    public bool sets_prot5 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prot5 (val);
    return true;}

    public string gets_prot5 () { 
    return get_prot5().ToString();}

    public string debug_name_prot5 () { 
    return "прот5";}

// прот6,   Bool, %M534.7   reg = M  width = Bit
    public bool get_prot6 ()
    { return (bool) m_mem.getMBit(534, 7); }

    public void set_prot6 (bool val)
    { m_mem.setMBit(534, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set prot6 to " + val.ToString());}

    public bool sets_prot6 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_prot6 (val);
    return true;}

    public string gets_prot6 () { 
    return get_prot6().ToString();}

    public string debug_name_prot6 () { 
    return "прот6";}

public enum local_dm{
stol_rab,
tp_rab,
tp_zav,
stol_naverhu,
stol_vnizu,
stol_dom_zav,
sloj_rab,
kar_dom_got,
kar_na_poz,
process,
stol_na_poz,
stol_got,
proc_obshh_rab,
stol_otn_got,
prozhig_rab,
sloi_nepr_rab,
stol_otn_rab,
rashod1_1,
rashod1_2,
rashod2_1,
rashod2_2,
prot1,
prot2,
prot3,
prot4,
prot5,
prot6,
};

public gTags[] group_dm = {
gTags.stol_rab,
gTags.tp_rab,
gTags.tp_zav,
gTags.stol_naverhu,
gTags.stol_vnizu,
gTags.stol_dom_zav,
gTags.sloj_rab,
gTags.kar_dom_got,
gTags.kar_na_poz,
gTags.process,
gTags.stol_na_poz,
gTags.stol_got,
gTags.proc_obshh_rab,
gTags.stol_otn_got,
gTags.prozhig_rab,
gTags.sloi_nepr_rab,
gTags.stol_otn_rab,
gTags.rashod1_1,
gTags.rashod1_2,
gTags.rashod2_1,
gTags.rashod2_2,
gTags.prot1,
gTags.prot2,
gTags.prot3,
gTags.prot4,
gTags.prot5,
gTags.prot6,
};

public enum gTags{
termopara1,
termopara2,
termopara3,
davl_och_gaza1,
davl_och_gaza2,
davl_och_gaza3,
linejka,
tolshhina,
tjen1_tek_moshhn,
kar_tek_poz,
stol_tek_poz,
schjot_slojov,
ost_slojov,
ost_slojov_dlya_dozatora,
inkrement,
tjen2_tek_moshhn,
tjen3_tek_moshhn,
temp1,
temp2,
temp3,
temp4,
temp5,
temp6,
datch_kisl1,
datch_kisl2,
vyhd_stol_abs,
vyhd_tjen1,
vyhd_tjen2,
vyhd_tjen3,
vyhd_stol_otn_vniz,
vyhd_stol_otn_vverh,
vyhd_stol_poisk_nulya,
vyhd_pit_lazerov,
vyhd_pit_chil1,
vyhd_pit_chil2,
vyhd_kl_chil1,
vyhd_kl_chil2,
vyhd_pit_mps,
vyhd_pit_rec,
vyhd_kv1,
vyhd_kv2,
vyhd_kje9,
vyhd_kje10,
vyhd_kar_prav_abs,
vyhd_kar_lev_abs,
vyhd_doz_prav_vper,
vyhd_doz_lev_vper,
vyhd_doz_prav_nazad,
vyhd_doz_lev_nazad,
vyhd_pereschjot,
vyhd_bar_lev_vper,
vyhd_bar_prav_vper,
vyhd_bar_lev_nazad,
vyhd_bar_prav_nazad,
vyhd_tolk_lev_vper,
vyhd_tolk_prav_vper,
vyhd_tolk_lev_nazad,
vyhd_tolk_prav_nazad,
vyhd_kar_prav_otn_vper,
vyhd_kar_prav_otn_naz,
vyhd_kar_lev_otn_vper,
vyhd_kar_lev_otn_naz,
vyhd_kl_bar_lev,
vyhd_kl_bar_prav,
vyhd_nas_otk_gaza,
kom_stol_abs,
kom_tp_pusk,
kom_tp_prer,
kom_kar_abs,
kom_stol_stop,
kom_karetka_stop,
kom_karetka_sbros,
kom_stol_sbros,
kom_stol_ust_nulya,
kom_stol_otn_pusk_vniz,
kom_stol_otn_pusk_vverh,
kom_sloj,
kom_prer,
kom_rezerv,
kom_rezerv_1,
kom_rezerv_2,
kom_obnulit_linejku,
kom_pit_tjen3,
kom_pit_tjen1,
kom_pit_tjen2,
kom_stol_poisk_nulya,
kom_process,
kom_proc_obshh,
kom_pereschjot,
kom_pit_laz,
kom_got_laz,
kom_sloj_sbros_schjotchika,
kom_pauza,
kom_rab_do_pauzy,
kom_dozator_avtomat,
kom_pit_chil1,
kom_pit_chil2,
kom_kl_chil1,
kom_kl_chil2,
kom_pit_rec,
kom_pit_mps,
kom_kar_lev_sh1_vperjod,
kom_kar_lev_sh1_nazad,
kom_kar_lev_sh1_abs,
kom_kar_lev_sh1_stop,
kom_kar_prav_sh2_vperjod,
kom_kar_prav_sh2_nazad,
kom_kar_prav_sh2_abs,
kom_kar_prav_sh2_stop,
kom_bar_prav_sh3_vperjod,
kom_bar_prav_sh3_nazad,
kom_bar_prav_sh3_abs,
kom_bar_prav_sh3_stop,
kom_bar_lev_sh4_vperjod,
kom_bar_lev_sh4_nazad,
kom_bar_lev_sh4_abs,
kom_bar_lev_sh4_stop,
kom_dozator_lev_vper,
kom_dozator_prav_vper,
kom_tolkatel_lev_vperjod,
kom_tolkatel_lev_nazad,
kom_tolkatel_prav_vperjod,
kom_tolkatel_prav_nazad,
kom_dozator_lev_nazad,
kom_dozator_prav_nazad,
kom_kje9,
kom_kje10,
kom_kv1,
kom_kv2,
kom_kl_bar_lev,
kom_kl_bar_prav,
kom_nas_otk_gaza,
ust_stol_poziciya,
ust_stol_skor_vverh,
ust_stol_otn_rasst,
ust_sloj_kar_lev_nachalo,
ust_sloj_kar_lev_konec,
ust_tolshh_sloya,
ust_stol_otn_rasst_avto,
ust_tjen1_moshhn,
ust_tjen2_moshhn,
ust_tjen3_moshhn,
ust_kol_slojov_dlya_doz_prav,
ust_kol_slojov_dlya_doz_lev,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
ust_kar_lev_skor,
ust_kar_lev_rast,
ust_kar_lev_poz,
ust_kar_prav_skor,
ust_kar_prav_rast,
ust_kar_prav_poz,
ust_bar_prav_skor,
ust_bar_lev_skor,
ust_doz_lev_vremya,
ust_doz_prav_vremya,
ust_tolk_lev_rasst,
ust_tolk_prav_rasst,
ust_doz_prav_skor,
ust_doz_lev_skor,
ust_tolk_lev_skor,
ust_tolk_prav_skor,
ust_sloj_kar_prav_nachalo,
ust_sloj_kar_prav_konec,
stol_rab,
tp_rab,
tp_zav,
stol_naverhu,
stol_vnizu,
stol_dom_zav,
sloj_rab,
kar_dom_got,
kar_na_poz,
process,
stol_na_poz,
stol_got,
proc_obshh_rab,
stol_otn_got,
prozhig_rab,
sloi_nepr_rab,
stol_otn_rab,
rashod1_1,
rashod1_2,
rashod2_1,
rashod2_2,
prot1,
prot2,
prot3,
prot4,
prot5,
prot6,
lastGTag,
};

public string [] debugNames = {
"термопара1",
"термопара2",
"термопара3",
"давл оч газа1",
"давл оч газа2",
"давл оч газа3",
"линейка",
"толщина",
"ТЭН1 тек мощн",
"кар тек поз",
"стол тек поз",
"счёт слоёв",
"ост слоёв",
"ост слоёв для дозатора",
"инкремент",
"ТЭН2 тек мощн",
"ТЭН3 тек мощн",
"темп1",
"темп2",
"темп3",
"темп4",
"темп5",
"темп6",
"датч кисл1",
"датч кисл2",
"выхд стол абс",
"выхд ТЭН1",
"выхд ТЭН2",
"выхд ТЭН3",
"выхд стол отн вниз",
"выхд стол отн вверх",
"выхд стол поиск нуля",
"выхд пит лазеров",
"выхд пит чил1",
"выхд пит чил2",
"выхд кл чил1",
"выхд кл чил2",
"выхд пит МПС",
"выхд пит рец",
"выхд КВ1",
"выхд КВ2",
"выхд КЭ9",
"выхд КЭ10",
"выхд кар прав абс",
"выхд кар лев абс",
"выхд доз прав впер",
"выхд доз лев впер",
"выхд доз прав назад",
"выхд доз лев назад",
"выхд пересчёт",
"выхд бар лев впер",
"выхд бар прав впер",
"выхд бар лев назад",
"выхд бар прав назад",
"выхд толк лев впер",
"выхд толк прав впер",
"выхд толк лев назад",
"выхд толк прав назад",
"выхд кар прав отн впер",
"выхд кар прав отн наз",
"выхд кар лев отн впер",
"выхд кар лев отн наз",
"выхд кл бар лев",
"выхд кл бар прав",
"выхд нас отк газа",
"ком стол абс",
"ком ТП пуск",
"ком ТП прер",
"ком кар абс",
"ком стол стоп",
"ком каретка стоп",
"ком каретка сброс",
"ком стол сброс",
"ком стол уст нуля",
"ком стол отн пуск вниз",
"ком стол отн пуск вверх",
"ком слой",
"ком прер",
"ком резерв",
"ком резерв(1)",
"ком резерв(2)",
"ком обнулить линейку",
"ком пит ТЭН3",
"ком пит ТЭН1",
"ком пит ТЭН2",
"ком стол поиск нуля",
"ком процесс",
"ком проц общ",
"ком пересчёт",
"ком пит лаз",
"ком гот лаз",
"ком слой сброс счётчика",
"ком пауза",
"ком раб до паузы",
"ком дозатор автомат",
"ком пит чил1",
"ком пит чил2",
"ком кл чил1",
"ком кл чил2",
"ком пит рец",
"ком пит МПС",
"ком кар лев ш1 вперёд",
"ком кар лев ш1 назад",
"ком кар лев ш1 абс",
"ком кар лев ш1 стоп",
"ком кар прав ш2 вперёд",
"ком кар прав ш2 назад",
"ком кар прав ш2 абс",
"ком кар прав ш2 стоп",
"ком бар прав ш3 вперёд",
"ком бар прав ш3 назад",
"ком бар прав ш3 абс",
"ком бар прав ш3 стоп",
"ком бар лев ш4 вперёд",
"ком бар лев ш4 назад",
"ком бар лев ш4 абс",
"ком бар лев ш4 стоп",
"ком дозатор лев впер",
"ком дозатор прав впер",
"ком толкатель лев вперёд",
"ком толкатель лев назад",
"ком толкатель прав вперёд",
"ком толкатель прав назад",
"ком дозатор лев назад",
"ком дозатор прав назад",
"ком КЭ9",
"ком КЭ10",
"ком КВ1",
"ком КВ2",
"ком кл бар лев",
"ком кл бар прав",
"ком нас отк газа",
"уст стол позиция",
"уст стол скор вверх",
"уст стол отн расст",
"уст слой кар лев начало",
"уст слой кар лев конец",
"уст толщ слоя",
"уст стол отн расст авто",
"уст ТЭН1 мощн",
"уст ТЭН2 мощн",
"уст ТЭН3 мощн",
"уст кол слоёв для доз прав",
"уст кол слоёв для доз лев",
"уст ТЭН1 темп",
"уст ТЭН2 темп",
"уст ТЭН3 темп",
"уст кар лев скор",
"уст кар лев раст",
"уст кар лев поз",
"уст кар прав скор",
"уст кар прав раст",
"уст кар прав поз",
"уст бар прав скор",
"уст бар лев скор",
"уст доз лев время",
"уст доз прав время",
"уст толк лев расст",
"уст толк прав расст",
"уст доз прав скор",
"уст доз лев скор",
"уст толк лев скор",
"уст толк прав скор",
"уст слой кар прав начало",
"уст слой кар прав конец",
"стол раб",
"тп раб",
"тп зав",
"стол наверху",
"стол внизу",
"стол дом зав",
"слой раб",
"кар дом гот",
"кар на поз",
"процесс",
"стол на поз",
"стол гот",
"проц общ раб",
"стол отн гот",
"прожиг раб",
"слои непр раб",
"стол отн раб",
"Расход1-1",
"Расход1-2",
"Расход2-1",
"Расход2-2",
"прот1",
"прот2",
"прот3",
"прот4",
"прот5",
"прот6",
};

public string getDebugName(gTags tag) {return debugNames[(int)tag];}

 Func<string>[] sGetters  = new Func<string>[(int)gTags.lastGTag];
public string getSValue(gTags tag) { return sGetters[(int)tag]();}
public void init_sGetters () {
sGetters[(int)gTags.termopara1] =  gets_termopara1;
sGetters[(int)gTags.termopara2] =  gets_termopara2;
sGetters[(int)gTags.termopara3] =  gets_termopara3;
sGetters[(int)gTags.davl_och_gaza1] =  gets_davl_och_gaza1;
sGetters[(int)gTags.davl_och_gaza2] =  gets_davl_och_gaza2;
sGetters[(int)gTags.davl_och_gaza3] =  gets_davl_och_gaza3;
sGetters[(int)gTags.linejka] =  gets_linejka;
sGetters[(int)gTags.tolshhina] =  gets_tolshhina;
sGetters[(int)gTags.tjen1_tek_moshhn] =  gets_tjen1_tek_moshhn;
sGetters[(int)gTags.kar_tek_poz] =  gets_kar_tek_poz;
sGetters[(int)gTags.stol_tek_poz] =  gets_stol_tek_poz;
sGetters[(int)gTags.schjot_slojov] =  gets_schjot_slojov;
sGetters[(int)gTags.ost_slojov] =  gets_ost_slojov;
sGetters[(int)gTags.ost_slojov_dlya_dozatora] =  gets_ost_slojov_dlya_dozatora;
sGetters[(int)gTags.inkrement] =  gets_inkrement;
sGetters[(int)gTags.tjen2_tek_moshhn] =  gets_tjen2_tek_moshhn;
sGetters[(int)gTags.tjen3_tek_moshhn] =  gets_tjen3_tek_moshhn;
sGetters[(int)gTags.temp1] =  gets_temp1;
sGetters[(int)gTags.temp2] =  gets_temp2;
sGetters[(int)gTags.temp3] =  gets_temp3;
sGetters[(int)gTags.temp4] =  gets_temp4;
sGetters[(int)gTags.temp5] =  gets_temp5;
sGetters[(int)gTags.temp6] =  gets_temp6;
sGetters[(int)gTags.datch_kisl1] =  gets_datch_kisl1;
sGetters[(int)gTags.datch_kisl2] =  gets_datch_kisl2;
sGetters[(int)gTags.vyhd_stol_abs] =  gets_vyhd_stol_abs;
sGetters[(int)gTags.vyhd_tjen1] =  gets_vyhd_tjen1;
sGetters[(int)gTags.vyhd_tjen2] =  gets_vyhd_tjen2;
sGetters[(int)gTags.vyhd_tjen3] =  gets_vyhd_tjen3;
sGetters[(int)gTags.vyhd_stol_otn_vniz] =  gets_vyhd_stol_otn_vniz;
sGetters[(int)gTags.vyhd_stol_otn_vverh] =  gets_vyhd_stol_otn_vverh;
sGetters[(int)gTags.vyhd_stol_poisk_nulya] =  gets_vyhd_stol_poisk_nulya;
sGetters[(int)gTags.vyhd_pit_lazerov] =  gets_vyhd_pit_lazerov;
sGetters[(int)gTags.vyhd_pit_chil1] =  gets_vyhd_pit_chil1;
sGetters[(int)gTags.vyhd_pit_chil2] =  gets_vyhd_pit_chil2;
sGetters[(int)gTags.vyhd_kl_chil1] =  gets_vyhd_kl_chil1;
sGetters[(int)gTags.vyhd_kl_chil2] =  gets_vyhd_kl_chil2;
sGetters[(int)gTags.vyhd_pit_mps] =  gets_vyhd_pit_mps;
sGetters[(int)gTags.vyhd_pit_rec] =  gets_vyhd_pit_rec;
sGetters[(int)gTags.vyhd_kv1] =  gets_vyhd_kv1;
sGetters[(int)gTags.vyhd_kv2] =  gets_vyhd_kv2;
sGetters[(int)gTags.vyhd_kje9] =  gets_vyhd_kje9;
sGetters[(int)gTags.vyhd_kje10] =  gets_vyhd_kje10;
sGetters[(int)gTags.vyhd_kar_prav_abs] =  gets_vyhd_kar_prav_abs;
sGetters[(int)gTags.vyhd_kar_lev_abs] =  gets_vyhd_kar_lev_abs;
sGetters[(int)gTags.vyhd_doz_prav_vper] =  gets_vyhd_doz_prav_vper;
sGetters[(int)gTags.vyhd_doz_lev_vper] =  gets_vyhd_doz_lev_vper;
sGetters[(int)gTags.vyhd_doz_prav_nazad] =  gets_vyhd_doz_prav_nazad;
sGetters[(int)gTags.vyhd_doz_lev_nazad] =  gets_vyhd_doz_lev_nazad;
sGetters[(int)gTags.vyhd_pereschjot] =  gets_vyhd_pereschjot;
sGetters[(int)gTags.vyhd_bar_lev_vper] =  gets_vyhd_bar_lev_vper;
sGetters[(int)gTags.vyhd_bar_prav_vper] =  gets_vyhd_bar_prav_vper;
sGetters[(int)gTags.vyhd_bar_lev_nazad] =  gets_vyhd_bar_lev_nazad;
sGetters[(int)gTags.vyhd_bar_prav_nazad] =  gets_vyhd_bar_prav_nazad;
sGetters[(int)gTags.vyhd_tolk_lev_vper] =  gets_vyhd_tolk_lev_vper;
sGetters[(int)gTags.vyhd_tolk_prav_vper] =  gets_vyhd_tolk_prav_vper;
sGetters[(int)gTags.vyhd_tolk_lev_nazad] =  gets_vyhd_tolk_lev_nazad;
sGetters[(int)gTags.vyhd_tolk_prav_nazad] =  gets_vyhd_tolk_prav_nazad;
sGetters[(int)gTags.vyhd_kar_prav_otn_vper] =  gets_vyhd_kar_prav_otn_vper;
sGetters[(int)gTags.vyhd_kar_prav_otn_naz] =  gets_vyhd_kar_prav_otn_naz;
sGetters[(int)gTags.vyhd_kar_lev_otn_vper] =  gets_vyhd_kar_lev_otn_vper;
sGetters[(int)gTags.vyhd_kar_lev_otn_naz] =  gets_vyhd_kar_lev_otn_naz;
sGetters[(int)gTags.vyhd_kl_bar_lev] =  gets_vyhd_kl_bar_lev;
sGetters[(int)gTags.vyhd_kl_bar_prav] =  gets_vyhd_kl_bar_prav;
sGetters[(int)gTags.vyhd_nas_otk_gaza] =  gets_vyhd_nas_otk_gaza;
sGetters[(int)gTags.kom_stol_abs] =  gets_kom_stol_abs;
sGetters[(int)gTags.kom_tp_pusk] =  gets_kom_tp_pusk;
sGetters[(int)gTags.kom_tp_prer] =  gets_kom_tp_prer;
sGetters[(int)gTags.kom_kar_abs] =  gets_kom_kar_abs;
sGetters[(int)gTags.kom_stol_stop] =  gets_kom_stol_stop;
sGetters[(int)gTags.kom_karetka_stop] =  gets_kom_karetka_stop;
sGetters[(int)gTags.kom_karetka_sbros] =  gets_kom_karetka_sbros;
sGetters[(int)gTags.kom_stol_sbros] =  gets_kom_stol_sbros;
sGetters[(int)gTags.kom_stol_ust_nulya] =  gets_kom_stol_ust_nulya;
sGetters[(int)gTags.kom_stol_otn_pusk_vniz] =  gets_kom_stol_otn_pusk_vniz;
sGetters[(int)gTags.kom_stol_otn_pusk_vverh] =  gets_kom_stol_otn_pusk_vverh;
sGetters[(int)gTags.kom_sloj] =  gets_kom_sloj;
sGetters[(int)gTags.kom_prer] =  gets_kom_prer;
sGetters[(int)gTags.kom_rezerv] =  gets_kom_rezerv;
sGetters[(int)gTags.kom_rezerv_1] =  gets_kom_rezerv_1;
sGetters[(int)gTags.kom_rezerv_2] =  gets_kom_rezerv_2;
sGetters[(int)gTags.kom_obnulit_linejku] =  gets_kom_obnulit_linejku;
sGetters[(int)gTags.kom_pit_tjen3] =  gets_kom_pit_tjen3;
sGetters[(int)gTags.kom_pit_tjen1] =  gets_kom_pit_tjen1;
sGetters[(int)gTags.kom_pit_tjen2] =  gets_kom_pit_tjen2;
sGetters[(int)gTags.kom_stol_poisk_nulya] =  gets_kom_stol_poisk_nulya;
sGetters[(int)gTags.kom_process] =  gets_kom_process;
sGetters[(int)gTags.kom_proc_obshh] =  gets_kom_proc_obshh;
sGetters[(int)gTags.kom_pereschjot] =  gets_kom_pereschjot;
sGetters[(int)gTags.kom_pit_laz] =  gets_kom_pit_laz;
sGetters[(int)gTags.kom_got_laz] =  gets_kom_got_laz;
sGetters[(int)gTags.kom_sloj_sbros_schjotchika] =  gets_kom_sloj_sbros_schjotchika;
sGetters[(int)gTags.kom_pauza] =  gets_kom_pauza;
sGetters[(int)gTags.kom_rab_do_pauzy] =  gets_kom_rab_do_pauzy;
sGetters[(int)gTags.kom_dozator_avtomat] =  gets_kom_dozator_avtomat;
sGetters[(int)gTags.kom_pit_chil1] =  gets_kom_pit_chil1;
sGetters[(int)gTags.kom_pit_chil2] =  gets_kom_pit_chil2;
sGetters[(int)gTags.kom_kl_chil1] =  gets_kom_kl_chil1;
sGetters[(int)gTags.kom_kl_chil2] =  gets_kom_kl_chil2;
sGetters[(int)gTags.kom_pit_rec] =  gets_kom_pit_rec;
sGetters[(int)gTags.kom_pit_mps] =  gets_kom_pit_mps;
sGetters[(int)gTags.kom_kar_lev_sh1_vperjod] =  gets_kom_kar_lev_sh1_vperjod;
sGetters[(int)gTags.kom_kar_lev_sh1_nazad] =  gets_kom_kar_lev_sh1_nazad;
sGetters[(int)gTags.kom_kar_lev_sh1_abs] =  gets_kom_kar_lev_sh1_abs;
sGetters[(int)gTags.kom_kar_lev_sh1_stop] =  gets_kom_kar_lev_sh1_stop;
sGetters[(int)gTags.kom_kar_prav_sh2_vperjod] =  gets_kom_kar_prav_sh2_vperjod;
sGetters[(int)gTags.kom_kar_prav_sh2_nazad] =  gets_kom_kar_prav_sh2_nazad;
sGetters[(int)gTags.kom_kar_prav_sh2_abs] =  gets_kom_kar_prav_sh2_abs;
sGetters[(int)gTags.kom_kar_prav_sh2_stop] =  gets_kom_kar_prav_sh2_stop;
sGetters[(int)gTags.kom_bar_prav_sh3_vperjod] =  gets_kom_bar_prav_sh3_vperjod;
sGetters[(int)gTags.kom_bar_prav_sh3_nazad] =  gets_kom_bar_prav_sh3_nazad;
sGetters[(int)gTags.kom_bar_prav_sh3_abs] =  gets_kom_bar_prav_sh3_abs;
sGetters[(int)gTags.kom_bar_prav_sh3_stop] =  gets_kom_bar_prav_sh3_stop;
sGetters[(int)gTags.kom_bar_lev_sh4_vperjod] =  gets_kom_bar_lev_sh4_vperjod;
sGetters[(int)gTags.kom_bar_lev_sh4_nazad] =  gets_kom_bar_lev_sh4_nazad;
sGetters[(int)gTags.kom_bar_lev_sh4_abs] =  gets_kom_bar_lev_sh4_abs;
sGetters[(int)gTags.kom_bar_lev_sh4_stop] =  gets_kom_bar_lev_sh4_stop;
sGetters[(int)gTags.kom_dozator_lev_vper] =  gets_kom_dozator_lev_vper;
sGetters[(int)gTags.kom_dozator_prav_vper] =  gets_kom_dozator_prav_vper;
sGetters[(int)gTags.kom_tolkatel_lev_vperjod] =  gets_kom_tolkatel_lev_vperjod;
sGetters[(int)gTags.kom_tolkatel_lev_nazad] =  gets_kom_tolkatel_lev_nazad;
sGetters[(int)gTags.kom_tolkatel_prav_vperjod] =  gets_kom_tolkatel_prav_vperjod;
sGetters[(int)gTags.kom_tolkatel_prav_nazad] =  gets_kom_tolkatel_prav_nazad;
sGetters[(int)gTags.kom_dozator_lev_nazad] =  gets_kom_dozator_lev_nazad;
sGetters[(int)gTags.kom_dozator_prav_nazad] =  gets_kom_dozator_prav_nazad;
sGetters[(int)gTags.kom_kje9] =  gets_kom_kje9;
sGetters[(int)gTags.kom_kje10] =  gets_kom_kje10;
sGetters[(int)gTags.kom_kv1] =  gets_kom_kv1;
sGetters[(int)gTags.kom_kv2] =  gets_kom_kv2;
sGetters[(int)gTags.kom_kl_bar_lev] =  gets_kom_kl_bar_lev;
sGetters[(int)gTags.kom_kl_bar_prav] =  gets_kom_kl_bar_prav;
sGetters[(int)gTags.kom_nas_otk_gaza] =  gets_kom_nas_otk_gaza;
sGetters[(int)gTags.ust_stol_poziciya] =  gets_ust_stol_poziciya;
sGetters[(int)gTags.ust_stol_skor_vverh] =  gets_ust_stol_skor_vverh;
sGetters[(int)gTags.ust_stol_otn_rasst] =  gets_ust_stol_otn_rasst;
sGetters[(int)gTags.ust_sloj_kar_lev_nachalo] =  gets_ust_sloj_kar_lev_nachalo;
sGetters[(int)gTags.ust_sloj_kar_lev_konec] =  gets_ust_sloj_kar_lev_konec;
sGetters[(int)gTags.ust_tolshh_sloya] =  gets_ust_tolshh_sloya;
sGetters[(int)gTags.ust_stol_otn_rasst_avto] =  gets_ust_stol_otn_rasst_avto;
sGetters[(int)gTags.ust_tjen1_moshhn] =  gets_ust_tjen1_moshhn;
sGetters[(int)gTags.ust_tjen2_moshhn] =  gets_ust_tjen2_moshhn;
sGetters[(int)gTags.ust_tjen3_moshhn] =  gets_ust_tjen3_moshhn;
sGetters[(int)gTags.ust_kol_slojov_dlya_doz_prav] =  gets_ust_kol_slojov_dlya_doz_prav;
sGetters[(int)gTags.ust_kol_slojov_dlya_doz_lev] =  gets_ust_kol_slojov_dlya_doz_lev;
sGetters[(int)gTags.ust_tjen1_temp] =  gets_ust_tjen1_temp;
sGetters[(int)gTags.ust_tjen2_temp] =  gets_ust_tjen2_temp;
sGetters[(int)gTags.ust_tjen3_temp] =  gets_ust_tjen3_temp;
sGetters[(int)gTags.ust_kar_lev_skor] =  gets_ust_kar_lev_skor;
sGetters[(int)gTags.ust_kar_lev_rast] =  gets_ust_kar_lev_rast;
sGetters[(int)gTags.ust_kar_lev_poz] =  gets_ust_kar_lev_poz;
sGetters[(int)gTags.ust_kar_prav_skor] =  gets_ust_kar_prav_skor;
sGetters[(int)gTags.ust_kar_prav_rast] =  gets_ust_kar_prav_rast;
sGetters[(int)gTags.ust_kar_prav_poz] =  gets_ust_kar_prav_poz;
sGetters[(int)gTags.ust_bar_prav_skor] =  gets_ust_bar_prav_skor;
sGetters[(int)gTags.ust_bar_lev_skor] =  gets_ust_bar_lev_skor;
sGetters[(int)gTags.ust_doz_lev_vremya] =  gets_ust_doz_lev_vremya;
sGetters[(int)gTags.ust_doz_prav_vremya] =  gets_ust_doz_prav_vremya;
sGetters[(int)gTags.ust_tolk_lev_rasst] =  gets_ust_tolk_lev_rasst;
sGetters[(int)gTags.ust_tolk_prav_rasst] =  gets_ust_tolk_prav_rasst;
sGetters[(int)gTags.ust_doz_prav_skor] =  gets_ust_doz_prav_skor;
sGetters[(int)gTags.ust_doz_lev_skor] =  gets_ust_doz_lev_skor;
sGetters[(int)gTags.ust_tolk_lev_skor] =  gets_ust_tolk_lev_skor;
sGetters[(int)gTags.ust_tolk_prav_skor] =  gets_ust_tolk_prav_skor;
sGetters[(int)gTags.ust_sloj_kar_prav_nachalo] =  gets_ust_sloj_kar_prav_nachalo;
sGetters[(int)gTags.ust_sloj_kar_prav_konec] =  gets_ust_sloj_kar_prav_konec;
sGetters[(int)gTags.stol_rab] =  gets_stol_rab;
sGetters[(int)gTags.tp_rab] =  gets_tp_rab;
sGetters[(int)gTags.tp_zav] =  gets_tp_zav;
sGetters[(int)gTags.stol_naverhu] =  gets_stol_naverhu;
sGetters[(int)gTags.stol_vnizu] =  gets_stol_vnizu;
sGetters[(int)gTags.stol_dom_zav] =  gets_stol_dom_zav;
sGetters[(int)gTags.sloj_rab] =  gets_sloj_rab;
sGetters[(int)gTags.kar_dom_got] =  gets_kar_dom_got;
sGetters[(int)gTags.kar_na_poz] =  gets_kar_na_poz;
sGetters[(int)gTags.process] =  gets_process;
sGetters[(int)gTags.stol_na_poz] =  gets_stol_na_poz;
sGetters[(int)gTags.stol_got] =  gets_stol_got;
sGetters[(int)gTags.proc_obshh_rab] =  gets_proc_obshh_rab;
sGetters[(int)gTags.stol_otn_got] =  gets_stol_otn_got;
sGetters[(int)gTags.prozhig_rab] =  gets_prozhig_rab;
sGetters[(int)gTags.sloi_nepr_rab] =  gets_sloi_nepr_rab;
sGetters[(int)gTags.stol_otn_rab] =  gets_stol_otn_rab;
sGetters[(int)gTags.rashod1_1] =  gets_rashod1_1;
sGetters[(int)gTags.rashod1_2] =  gets_rashod1_2;
sGetters[(int)gTags.rashod2_1] =  gets_rashod2_1;
sGetters[(int)gTags.rashod2_2] =  gets_rashod2_2;
sGetters[(int)gTags.prot1] =  gets_prot1;
sGetters[(int)gTags.prot2] =  gets_prot2;
sGetters[(int)gTags.prot3] =  gets_prot3;
sGetters[(int)gTags.prot4] =  gets_prot4;
sGetters[(int)gTags.prot5] =  gets_prot5;
sGetters[(int)gTags.prot6] =  gets_prot6;
}

Func<string, bool>[] sSetters = new Func<string, bool>[(int)gTags.lastGTag];
public bool setSValue(gTags tag, string val) { return sSetters[(int)tag](val); }
public void init_sSetters () {
sSetters[(int)gTags.termopara1] =  sets_termopara1;
sSetters[(int)gTags.termopara2] =  sets_termopara2;
sSetters[(int)gTags.termopara3] =  sets_termopara3;
sSetters[(int)gTags.davl_och_gaza1] =  sets_davl_och_gaza1;
sSetters[(int)gTags.davl_och_gaza2] =  sets_davl_och_gaza2;
sSetters[(int)gTags.davl_och_gaza3] =  sets_davl_och_gaza3;
sSetters[(int)gTags.linejka] =  sets_linejka;
sSetters[(int)gTags.tolshhina] =  sets_tolshhina;
sSetters[(int)gTags.tjen1_tek_moshhn] =  sets_tjen1_tek_moshhn;
sSetters[(int)gTags.kar_tek_poz] =  sets_kar_tek_poz;
sSetters[(int)gTags.stol_tek_poz] =  sets_stol_tek_poz;
sSetters[(int)gTags.schjot_slojov] =  sets_schjot_slojov;
sSetters[(int)gTags.ost_slojov] =  sets_ost_slojov;
sSetters[(int)gTags.ost_slojov_dlya_dozatora] =  sets_ost_slojov_dlya_dozatora;
sSetters[(int)gTags.inkrement] =  sets_inkrement;
sSetters[(int)gTags.tjen2_tek_moshhn] =  sets_tjen2_tek_moshhn;
sSetters[(int)gTags.tjen3_tek_moshhn] =  sets_tjen3_tek_moshhn;
sSetters[(int)gTags.temp1] =  sets_temp1;
sSetters[(int)gTags.temp2] =  sets_temp2;
sSetters[(int)gTags.temp3] =  sets_temp3;
sSetters[(int)gTags.temp4] =  sets_temp4;
sSetters[(int)gTags.temp5] =  sets_temp5;
sSetters[(int)gTags.temp6] =  sets_temp6;
sSetters[(int)gTags.datch_kisl1] =  sets_datch_kisl1;
sSetters[(int)gTags.datch_kisl2] =  sets_datch_kisl2;
sSetters[(int)gTags.vyhd_stol_abs] =  sets_vyhd_stol_abs;
sSetters[(int)gTags.vyhd_tjen1] =  sets_vyhd_tjen1;
sSetters[(int)gTags.vyhd_tjen2] =  sets_vyhd_tjen2;
sSetters[(int)gTags.vyhd_tjen3] =  sets_vyhd_tjen3;
sSetters[(int)gTags.vyhd_stol_otn_vniz] =  sets_vyhd_stol_otn_vniz;
sSetters[(int)gTags.vyhd_stol_otn_vverh] =  sets_vyhd_stol_otn_vverh;
sSetters[(int)gTags.vyhd_stol_poisk_nulya] =  sets_vyhd_stol_poisk_nulya;
sSetters[(int)gTags.vyhd_pit_lazerov] =  sets_vyhd_pit_lazerov;
sSetters[(int)gTags.vyhd_pit_chil1] =  sets_vyhd_pit_chil1;
sSetters[(int)gTags.vyhd_pit_chil2] =  sets_vyhd_pit_chil2;
sSetters[(int)gTags.vyhd_kl_chil1] =  sets_vyhd_kl_chil1;
sSetters[(int)gTags.vyhd_kl_chil2] =  sets_vyhd_kl_chil2;
sSetters[(int)gTags.vyhd_pit_mps] =  sets_vyhd_pit_mps;
sSetters[(int)gTags.vyhd_pit_rec] =  sets_vyhd_pit_rec;
sSetters[(int)gTags.vyhd_kv1] =  sets_vyhd_kv1;
sSetters[(int)gTags.vyhd_kv2] =  sets_vyhd_kv2;
sSetters[(int)gTags.vyhd_kje9] =  sets_vyhd_kje9;
sSetters[(int)gTags.vyhd_kje10] =  sets_vyhd_kje10;
sSetters[(int)gTags.vyhd_kar_prav_abs] =  sets_vyhd_kar_prav_abs;
sSetters[(int)gTags.vyhd_kar_lev_abs] =  sets_vyhd_kar_lev_abs;
sSetters[(int)gTags.vyhd_doz_prav_vper] =  sets_vyhd_doz_prav_vper;
sSetters[(int)gTags.vyhd_doz_lev_vper] =  sets_vyhd_doz_lev_vper;
sSetters[(int)gTags.vyhd_doz_prav_nazad] =  sets_vyhd_doz_prav_nazad;
sSetters[(int)gTags.vyhd_doz_lev_nazad] =  sets_vyhd_doz_lev_nazad;
sSetters[(int)gTags.vyhd_pereschjot] =  sets_vyhd_pereschjot;
sSetters[(int)gTags.vyhd_bar_lev_vper] =  sets_vyhd_bar_lev_vper;
sSetters[(int)gTags.vyhd_bar_prav_vper] =  sets_vyhd_bar_prav_vper;
sSetters[(int)gTags.vyhd_bar_lev_nazad] =  sets_vyhd_bar_lev_nazad;
sSetters[(int)gTags.vyhd_bar_prav_nazad] =  sets_vyhd_bar_prav_nazad;
sSetters[(int)gTags.vyhd_tolk_lev_vper] =  sets_vyhd_tolk_lev_vper;
sSetters[(int)gTags.vyhd_tolk_prav_vper] =  sets_vyhd_tolk_prav_vper;
sSetters[(int)gTags.vyhd_tolk_lev_nazad] =  sets_vyhd_tolk_lev_nazad;
sSetters[(int)gTags.vyhd_tolk_prav_nazad] =  sets_vyhd_tolk_prav_nazad;
sSetters[(int)gTags.vyhd_kar_prav_otn_vper] =  sets_vyhd_kar_prav_otn_vper;
sSetters[(int)gTags.vyhd_kar_prav_otn_naz] =  sets_vyhd_kar_prav_otn_naz;
sSetters[(int)gTags.vyhd_kar_lev_otn_vper] =  sets_vyhd_kar_lev_otn_vper;
sSetters[(int)gTags.vyhd_kar_lev_otn_naz] =  sets_vyhd_kar_lev_otn_naz;
sSetters[(int)gTags.vyhd_kl_bar_lev] =  sets_vyhd_kl_bar_lev;
sSetters[(int)gTags.vyhd_kl_bar_prav] =  sets_vyhd_kl_bar_prav;
sSetters[(int)gTags.vyhd_nas_otk_gaza] =  sets_vyhd_nas_otk_gaza;
sSetters[(int)gTags.kom_stol_abs] =  sets_kom_stol_abs;
sSetters[(int)gTags.kom_tp_pusk] =  sets_kom_tp_pusk;
sSetters[(int)gTags.kom_tp_prer] =  sets_kom_tp_prer;
sSetters[(int)gTags.kom_kar_abs] =  sets_kom_kar_abs;
sSetters[(int)gTags.kom_stol_stop] =  sets_kom_stol_stop;
sSetters[(int)gTags.kom_karetka_stop] =  sets_kom_karetka_stop;
sSetters[(int)gTags.kom_karetka_sbros] =  sets_kom_karetka_sbros;
sSetters[(int)gTags.kom_stol_sbros] =  sets_kom_stol_sbros;
sSetters[(int)gTags.kom_stol_ust_nulya] =  sets_kom_stol_ust_nulya;
sSetters[(int)gTags.kom_stol_otn_pusk_vniz] =  sets_kom_stol_otn_pusk_vniz;
sSetters[(int)gTags.kom_stol_otn_pusk_vverh] =  sets_kom_stol_otn_pusk_vverh;
sSetters[(int)gTags.kom_sloj] =  sets_kom_sloj;
sSetters[(int)gTags.kom_prer] =  sets_kom_prer;
sSetters[(int)gTags.kom_rezerv] =  sets_kom_rezerv;
sSetters[(int)gTags.kom_rezerv_1] =  sets_kom_rezerv_1;
sSetters[(int)gTags.kom_rezerv_2] =  sets_kom_rezerv_2;
sSetters[(int)gTags.kom_obnulit_linejku] =  sets_kom_obnulit_linejku;
sSetters[(int)gTags.kom_pit_tjen3] =  sets_kom_pit_tjen3;
sSetters[(int)gTags.kom_pit_tjen1] =  sets_kom_pit_tjen1;
sSetters[(int)gTags.kom_pit_tjen2] =  sets_kom_pit_tjen2;
sSetters[(int)gTags.kom_stol_poisk_nulya] =  sets_kom_stol_poisk_nulya;
sSetters[(int)gTags.kom_process] =  sets_kom_process;
sSetters[(int)gTags.kom_proc_obshh] =  sets_kom_proc_obshh;
sSetters[(int)gTags.kom_pereschjot] =  sets_kom_pereschjot;
sSetters[(int)gTags.kom_pit_laz] =  sets_kom_pit_laz;
sSetters[(int)gTags.kom_got_laz] =  sets_kom_got_laz;
sSetters[(int)gTags.kom_sloj_sbros_schjotchika] =  sets_kom_sloj_sbros_schjotchika;
sSetters[(int)gTags.kom_pauza] =  sets_kom_pauza;
sSetters[(int)gTags.kom_rab_do_pauzy] =  sets_kom_rab_do_pauzy;
sSetters[(int)gTags.kom_dozator_avtomat] =  sets_kom_dozator_avtomat;
sSetters[(int)gTags.kom_pit_chil1] =  sets_kom_pit_chil1;
sSetters[(int)gTags.kom_pit_chil2] =  sets_kom_pit_chil2;
sSetters[(int)gTags.kom_kl_chil1] =  sets_kom_kl_chil1;
sSetters[(int)gTags.kom_kl_chil2] =  sets_kom_kl_chil2;
sSetters[(int)gTags.kom_pit_rec] =  sets_kom_pit_rec;
sSetters[(int)gTags.kom_pit_mps] =  sets_kom_pit_mps;
sSetters[(int)gTags.kom_kar_lev_sh1_vperjod] =  sets_kom_kar_lev_sh1_vperjod;
sSetters[(int)gTags.kom_kar_lev_sh1_nazad] =  sets_kom_kar_lev_sh1_nazad;
sSetters[(int)gTags.kom_kar_lev_sh1_abs] =  sets_kom_kar_lev_sh1_abs;
sSetters[(int)gTags.kom_kar_lev_sh1_stop] =  sets_kom_kar_lev_sh1_stop;
sSetters[(int)gTags.kom_kar_prav_sh2_vperjod] =  sets_kom_kar_prav_sh2_vperjod;
sSetters[(int)gTags.kom_kar_prav_sh2_nazad] =  sets_kom_kar_prav_sh2_nazad;
sSetters[(int)gTags.kom_kar_prav_sh2_abs] =  sets_kom_kar_prav_sh2_abs;
sSetters[(int)gTags.kom_kar_prav_sh2_stop] =  sets_kom_kar_prav_sh2_stop;
sSetters[(int)gTags.kom_bar_prav_sh3_vperjod] =  sets_kom_bar_prav_sh3_vperjod;
sSetters[(int)gTags.kom_bar_prav_sh3_nazad] =  sets_kom_bar_prav_sh3_nazad;
sSetters[(int)gTags.kom_bar_prav_sh3_abs] =  sets_kom_bar_prav_sh3_abs;
sSetters[(int)gTags.kom_bar_prav_sh3_stop] =  sets_kom_bar_prav_sh3_stop;
sSetters[(int)gTags.kom_bar_lev_sh4_vperjod] =  sets_kom_bar_lev_sh4_vperjod;
sSetters[(int)gTags.kom_bar_lev_sh4_nazad] =  sets_kom_bar_lev_sh4_nazad;
sSetters[(int)gTags.kom_bar_lev_sh4_abs] =  sets_kom_bar_lev_sh4_abs;
sSetters[(int)gTags.kom_bar_lev_sh4_stop] =  sets_kom_bar_lev_sh4_stop;
sSetters[(int)gTags.kom_dozator_lev_vper] =  sets_kom_dozator_lev_vper;
sSetters[(int)gTags.kom_dozator_prav_vper] =  sets_kom_dozator_prav_vper;
sSetters[(int)gTags.kom_tolkatel_lev_vperjod] =  sets_kom_tolkatel_lev_vperjod;
sSetters[(int)gTags.kom_tolkatel_lev_nazad] =  sets_kom_tolkatel_lev_nazad;
sSetters[(int)gTags.kom_tolkatel_prav_vperjod] =  sets_kom_tolkatel_prav_vperjod;
sSetters[(int)gTags.kom_tolkatel_prav_nazad] =  sets_kom_tolkatel_prav_nazad;
sSetters[(int)gTags.kom_dozator_lev_nazad] =  sets_kom_dozator_lev_nazad;
sSetters[(int)gTags.kom_dozator_prav_nazad] =  sets_kom_dozator_prav_nazad;
sSetters[(int)gTags.kom_kje9] =  sets_kom_kje9;
sSetters[(int)gTags.kom_kje10] =  sets_kom_kje10;
sSetters[(int)gTags.kom_kv1] =  sets_kom_kv1;
sSetters[(int)gTags.kom_kv2] =  sets_kom_kv2;
sSetters[(int)gTags.kom_kl_bar_lev] =  sets_kom_kl_bar_lev;
sSetters[(int)gTags.kom_kl_bar_prav] =  sets_kom_kl_bar_prav;
sSetters[(int)gTags.kom_nas_otk_gaza] =  sets_kom_nas_otk_gaza;
sSetters[(int)gTags.ust_stol_poziciya] =  sets_ust_stol_poziciya;
sSetters[(int)gTags.ust_stol_skor_vverh] =  sets_ust_stol_skor_vverh;
sSetters[(int)gTags.ust_stol_otn_rasst] =  sets_ust_stol_otn_rasst;
sSetters[(int)gTags.ust_sloj_kar_lev_nachalo] =  sets_ust_sloj_kar_lev_nachalo;
sSetters[(int)gTags.ust_sloj_kar_lev_konec] =  sets_ust_sloj_kar_lev_konec;
sSetters[(int)gTags.ust_tolshh_sloya] =  sets_ust_tolshh_sloya;
sSetters[(int)gTags.ust_stol_otn_rasst_avto] =  sets_ust_stol_otn_rasst_avto;
sSetters[(int)gTags.ust_tjen1_moshhn] =  sets_ust_tjen1_moshhn;
sSetters[(int)gTags.ust_tjen2_moshhn] =  sets_ust_tjen2_moshhn;
sSetters[(int)gTags.ust_tjen3_moshhn] =  sets_ust_tjen3_moshhn;
sSetters[(int)gTags.ust_kol_slojov_dlya_doz_prav] =  sets_ust_kol_slojov_dlya_doz_prav;
sSetters[(int)gTags.ust_kol_slojov_dlya_doz_lev] =  sets_ust_kol_slojov_dlya_doz_lev;
sSetters[(int)gTags.ust_tjen1_temp] =  sets_ust_tjen1_temp;
sSetters[(int)gTags.ust_tjen2_temp] =  sets_ust_tjen2_temp;
sSetters[(int)gTags.ust_tjen3_temp] =  sets_ust_tjen3_temp;
sSetters[(int)gTags.ust_kar_lev_skor] =  sets_ust_kar_lev_skor;
sSetters[(int)gTags.ust_kar_lev_rast] =  sets_ust_kar_lev_rast;
sSetters[(int)gTags.ust_kar_lev_poz] =  sets_ust_kar_lev_poz;
sSetters[(int)gTags.ust_kar_prav_skor] =  sets_ust_kar_prav_skor;
sSetters[(int)gTags.ust_kar_prav_rast] =  sets_ust_kar_prav_rast;
sSetters[(int)gTags.ust_kar_prav_poz] =  sets_ust_kar_prav_poz;
sSetters[(int)gTags.ust_bar_prav_skor] =  sets_ust_bar_prav_skor;
sSetters[(int)gTags.ust_bar_lev_skor] =  sets_ust_bar_lev_skor;
sSetters[(int)gTags.ust_doz_lev_vremya] =  sets_ust_doz_lev_vremya;
sSetters[(int)gTags.ust_doz_prav_vremya] =  sets_ust_doz_prav_vremya;
sSetters[(int)gTags.ust_tolk_lev_rasst] =  sets_ust_tolk_lev_rasst;
sSetters[(int)gTags.ust_tolk_prav_rasst] =  sets_ust_tolk_prav_rasst;
sSetters[(int)gTags.ust_doz_prav_skor] =  sets_ust_doz_prav_skor;
sSetters[(int)gTags.ust_doz_lev_skor] =  sets_ust_doz_lev_skor;
sSetters[(int)gTags.ust_tolk_lev_skor] =  sets_ust_tolk_lev_skor;
sSetters[(int)gTags.ust_tolk_prav_skor] =  sets_ust_tolk_prav_skor;
sSetters[(int)gTags.ust_sloj_kar_prav_nachalo] =  sets_ust_sloj_kar_prav_nachalo;
sSetters[(int)gTags.ust_sloj_kar_prav_konec] =  sets_ust_sloj_kar_prav_konec;
sSetters[(int)gTags.stol_rab] =  sets_stol_rab;
sSetters[(int)gTags.tp_rab] =  sets_tp_rab;
sSetters[(int)gTags.tp_zav] =  sets_tp_zav;
sSetters[(int)gTags.stol_naverhu] =  sets_stol_naverhu;
sSetters[(int)gTags.stol_vnizu] =  sets_stol_vnizu;
sSetters[(int)gTags.stol_dom_zav] =  sets_stol_dom_zav;
sSetters[(int)gTags.sloj_rab] =  sets_sloj_rab;
sSetters[(int)gTags.kar_dom_got] =  sets_kar_dom_got;
sSetters[(int)gTags.kar_na_poz] =  sets_kar_na_poz;
sSetters[(int)gTags.process] =  sets_process;
sSetters[(int)gTags.stol_na_poz] =  sets_stol_na_poz;
sSetters[(int)gTags.stol_got] =  sets_stol_got;
sSetters[(int)gTags.proc_obshh_rab] =  sets_proc_obshh_rab;
sSetters[(int)gTags.stol_otn_got] =  sets_stol_otn_got;
sSetters[(int)gTags.prozhig_rab] =  sets_prozhig_rab;
sSetters[(int)gTags.sloi_nepr_rab] =  sets_sloi_nepr_rab;
sSetters[(int)gTags.stol_otn_rab] =  sets_stol_otn_rab;
sSetters[(int)gTags.rashod1_1] =  sets_rashod1_1;
sSetters[(int)gTags.rashod1_2] =  sets_rashod1_2;
sSetters[(int)gTags.rashod2_1] =  sets_rashod2_1;
sSetters[(int)gTags.rashod2_2] =  sets_rashod2_2;
sSetters[(int)gTags.prot1] =  sets_prot1;
sSetters[(int)gTags.prot2] =  sets_prot2;
sSetters[(int)gTags.prot3] =  sets_prot3;
sSetters[(int)gTags.prot4] =  sets_prot4;
sSetters[(int)gTags.prot5] =  sets_prot5;
sSetters[(int)gTags.prot6] =  sets_prot6;
}

public Dictionary<string, gTags[]> groupingDict = new Dictionary<string, gTags[]> {
{ "group1" ,new gTags [] {gTags.prot1,
gTags.prot2,
gTags.prot3,
gTags.prot4,
gTags.prot5,
gTags.prot6,
gTags.kom_pit_chil1,
gTags.kom_pit_chil2,
gTags.kom_kl_chil1,
gTags.kom_kl_chil2,
gTags.vyhd_pit_chil1,
gTags.vyhd_pit_chil2,
gTags.vyhd_kl_chil1,
gTags.vyhd_kl_chil2,
gTags.temp1,
gTags.temp2,
gTags.temp3,
gTags.temp4,
gTags.temp5,
gTags.temp6,
}},
{ "group2" ,new gTags [] {gTags.kom_stol_abs,
gTags.kom_stol_stop,
gTags.kom_stol_sbros,
gTags.kom_stol_ust_nulya,
gTags.kom_stol_otn_pusk_vniz,
gTags.kom_stol_otn_pusk_vverh,
gTags.kom_stol_poisk_nulya,
gTags.kom_obnulit_linejku,
gTags.kom_pereschjot,
gTags.vyhd_stol_abs,
gTags.vyhd_stol_otn_vniz,
gTags.vyhd_stol_otn_vverh,
gTags.vyhd_stol_poisk_nulya,
gTags.vyhd_pereschjot,
gTags.linejka,
gTags.tolshhina,
gTags.stol_tek_poz,
gTags.ust_stol_poziciya,
gTags.ust_stol_skor_vverh,
gTags.ust_stol_otn_rasst,
}},
{ "group3" ,new gTags [] {gTags.kom_kar_lev_sh1_vperjod,
gTags.kom_kar_lev_sh1_nazad,
gTags.kom_kar_lev_sh1_abs,
gTags.kom_kar_lev_sh1_stop,
gTags.kom_kar_prav_sh2_vperjod,
gTags.kom_kar_prav_sh2_nazad,
gTags.kom_kar_prav_sh2_abs,
gTags.kom_kar_prav_sh2_stop,
gTags.vyhd_kar_lev_otn_vper,
gTags.vyhd_kar_lev_otn_naz,
gTags.vyhd_kar_lev_abs,
gTags.vyhd_kar_prav_otn_vper,
gTags.vyhd_kar_prav_otn_naz,
gTags.vyhd_kar_prav_abs,
gTags.ust_kar_lev_skor,
gTags.ust_kar_lev_rast,
gTags.ust_kar_lev_poz,
gTags.ust_kar_prav_skor,
gTags.ust_kar_prav_rast,
gTags.ust_kar_prav_poz,
}},
{ "group4" ,new gTags [] {gTags.kom_bar_prav_sh3_vperjod,
gTags.kom_bar_prav_sh3_nazad,
gTags.kom_bar_prav_sh3_stop,
gTags.kom_bar_lev_sh4_vperjod,
gTags.kom_bar_lev_sh4_nazad,
gTags.kom_bar_lev_sh4_stop,
gTags.kom_kl_bar_lev,
gTags.kom_kl_bar_prav,
gTags.kom_nas_otk_gaza,
gTags.vyhd_bar_prav_vper,
gTags.vyhd_bar_prav_nazad,
gTags.vyhd_bar_lev_vper,
gTags.vyhd_bar_lev_nazad,
gTags.vyhd_kl_bar_lev,
gTags.vyhd_kl_bar_prav,
gTags.vyhd_nas_otk_gaza,
gTags.ust_bar_lev_skor,
gTags.ust_bar_prav_skor,
}},
{ "group5" ,new gTags [] {gTags.rashod1_1,
gTags.rashod1_2,
gTags.rashod2_1,
gTags.rashod2_2,
gTags.kom_pit_rec,
gTags.kom_kje9,
gTags.kom_kje10,
gTags.kom_kv1,
gTags.kom_kv2,
gTags.vyhd_pit_rec,
gTags.vyhd_kje9,
gTags.vyhd_kje10,
gTags.vyhd_kv1,
gTags.vyhd_kv2,
gTags.datch_kisl1,
gTags.datch_kisl2,
gTags.davl_och_gaza1,
gTags.davl_och_gaza2,
gTags.davl_och_gaza3,
}},
{ "group6" ,new gTags [] {gTags.kom_dozator_lev_vper,
gTags.kom_dozator_lev_nazad,
gTags.kom_dozator_prav_vper,
gTags.kom_dozator_prav_nazad,
gTags.vyhd_doz_lev_vper,
gTags.vyhd_doz_lev_nazad,
gTags.vyhd_doz_prav_vper,
gTags.vyhd_doz_prav_nazad,
gTags.ust_doz_lev_vremya,
gTags.ust_doz_lev_skor,
gTags.ust_doz_prav_vremya,
gTags.ust_doz_prav_skor,
}},
{ "group7" ,new gTags [] {gTags.kom_pit_tjen1,
gTags.kom_pit_tjen2,
gTags.kom_pit_tjen3,
gTags.vyhd_tjen1,
gTags.vyhd_tjen2,
gTags.vyhd_tjen3,
gTags.tjen1_tek_moshhn,
gTags.termopara1,
gTags.tjen2_tek_moshhn,
gTags.termopara2,
gTags.tjen3_tek_moshhn,
gTags.termopara3,
gTags.ust_tjen1_moshhn,
gTags.ust_tjen1_temp,
gTags.ust_tjen2_moshhn,
gTags.ust_tjen2_temp,
gTags.ust_tjen3_moshhn,
gTags.ust_tjen3_temp,
}},
{ "group8" ,new gTags [] {gTags.ust_sloj_kar_lev_nachalo,
gTags.ust_sloj_kar_lev_konec,
gTags.ust_tolshh_sloya,
gTags.ust_stol_otn_rasst_avto,
gTags.ust_kol_slojov_dlya_doz_prav,
gTags.ust_kol_slojov_dlya_doz_lev,
gTags.ust_sloj_kar_prav_nachalo,
gTags.ust_sloj_kar_prav_konec,
gTags.kom_tp_pusk,
gTags.kom_tp_prer,
gTags.kom_kar_abs,
gTags.kom_karetka_stop,
gTags.kom_karetka_sbros,
gTags.kom_sloj,
gTags.kom_prer,
gTags.kom_rezerv,
gTags.kom_rezerv_1,
gTags.kom_rezerv_2,
gTags.kom_process,
gTags.kom_proc_obshh,
gTags.kom_sloj_sbros_schjotchika,
gTags.kom_pauza,
gTags.kom_rab_do_pauzy,
gTags.kom_dozator_avtomat,
gTags.kom_bar_prav_sh3_abs,
gTags.kom_bar_lev_sh4_abs,
gTags.kar_tek_poz,
gTags.schjot_slojov,
gTags.ost_slojov,
gTags.ost_slojov_dlya_dozatora,
gTags.inkrement,
}},
};
   

    }
 }
//__+_________________________________________________________________________________________________
//________++++____________________++++++++____++++++++++++++++____________________++++________________
//____++++____________________________________________________________________++++++++++++++++++++++++
//++++++++++++++++++++++++++++++++________++++________++++++++++++++++++++++++++++++++________________
//____________________________________________________________________________________________________
//+__+_++++++++_+++_+++++_+++++++++++_________________________________________________________________
//____++++++++++++++++++++++++++++++++______++++++++++++++++++++++++++++++++++++______________________
//__________________________________++++++++______++++____++++++____++++++++__________________________
//____________________________________________________________________________________________________
//____________________________________________________________________________________________________
