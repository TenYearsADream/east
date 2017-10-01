using System;
using log4netSample.Logging;
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

// давл1,   Real, %MD616   reg = M  width = UInt32
    public float get_davl1 ()
    { return (float) m_mem.getMFloat(616); }

    public void set_davl1 (float val)
    { m_mem.setMFloat(616, (float) val); 
      Log.Write(LogLevel.Info, "set davl1 to " + val.ToString());}

    public bool sets_davl1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl1 (val);
    return true;}

    public string gets_davl1 () { 
    return get_davl1().ToString();}

    public string debug_name_davl1 () { 
    return "давл1";}

// давл2,   Real, %MD620   reg = M  width = UInt32
    public float get_davl2 ()
    { return (float) m_mem.getMFloat(620); }

    public void set_davl2 (float val)
    { m_mem.setMFloat(620, (float) val); 
      Log.Write(LogLevel.Info, "set davl2 to " + val.ToString());}

    public bool sets_davl2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl2 (val);
    return true;}

    public string gets_davl2 () { 
    return get_davl2().ToString();}

    public string debug_name_davl2 () { 
    return "давл2";}

// давл3,   Real, %MD624   reg = M  width = UInt32
    public float get_davl3 ()
    { return (float) m_mem.getMFloat(624); }

    public void set_davl3 (float val)
    { m_mem.setMFloat(624, (float) val); 
      Log.Write(LogLevel.Info, "set davl3 to " + val.ToString());}

    public bool sets_davl3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl3 (val);
    return true;}

    public string gets_davl3 () { 
    return get_davl3().ToString();}

    public string debug_name_davl3 () { 
    return "давл3";}

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

// давл4,   Real, %MD762   reg = M  width = UInt32
    public float get_davl4 ()
    { return (float) m_mem.getMFloat(762); }

    public void set_davl4 (float val)
    { m_mem.setMFloat(762, (float) val); 
      Log.Write(LogLevel.Info, "set davl4 to " + val.ToString());}

    public bool sets_davl4 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_davl4 (val);
    return true;}

    public string gets_davl4 () { 
    return get_davl4().ToString();}

    public string debug_name_davl4 () { 
    return "давл4";}

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

// прот1,   Real, %MD678   reg = M  width = UInt32
    public float get_prot1 ()
    { return (float) m_mem.getMFloat(678); }

    public void set_prot1 (float val)
    { m_mem.setMFloat(678, (float) val); 
      Log.Write(LogLevel.Info, "set prot1 to " + val.ToString());}

    public bool sets_prot1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_prot1 (val);
    return true;}

    public string gets_prot1 () { 
    return get_prot1().ToString();}

    public string debug_name_prot1 () { 
    return "прот1";}

// прот2,   Real, %MD682   reg = M  width = UInt32
    public float get_prot2 ()
    { return (float) m_mem.getMFloat(682); }

    public void set_prot2 (float val)
    { m_mem.setMFloat(682, (float) val); 
      Log.Write(LogLevel.Info, "set prot2 to " + val.ToString());}

    public bool sets_prot2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_prot2 (val);
    return true;}

    public string gets_prot2 () { 
    return get_prot2().ToString();}

    public string debug_name_prot2 () { 
    return "прот2";}

// прот3,   Real, %MD686   reg = M  width = UInt32
    public float get_prot3 ()
    { return (float) m_mem.getMFloat(686); }

    public void set_prot3 (float val)
    { m_mem.setMFloat(686, (float) val); 
      Log.Write(LogLevel.Info, "set prot3 to " + val.ToString());}

    public bool sets_prot3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_prot3 (val);
    return true;}

    public string gets_prot3 () { 
    return get_prot3().ToString();}

    public string debug_name_prot3 () { 
    return "прот3";}

// прот4,   Real, %MD690   reg = M  width = UInt32
    public float get_prot4 ()
    { return (float) m_mem.getMFloat(690); }

    public void set_prot4 (float val)
    { m_mem.setMFloat(690, (float) val); 
      Log.Write(LogLevel.Info, "set prot4 to " + val.ToString());}

    public bool sets_prot4 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_prot4 (val);
    return true;}

    public string gets_prot4 () { 
    return get_prot4().ToString();}

    public string debug_name_prot4 () { 
    return "прот4";}

// прот5,   Real, %MD694   reg = M  width = UInt32
    public float get_prot5 ()
    { return (float) m_mem.getMFloat(694); }

    public void set_prot5 (float val)
    { m_mem.setMFloat(694, (float) val); 
      Log.Write(LogLevel.Info, "set prot5 to " + val.ToString());}

    public bool sets_prot5 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_prot5 (val);
    return true;}

    public string gets_prot5 () { 
    return get_prot5().ToString();}

    public string debug_name_prot5 () { 
    return "прот5";}

// прот6,   Real, %MD698   reg = M  width = UInt32
    public float get_prot6 ()
    { return (float) m_mem.getMFloat(698); }

    public void set_prot6 (float val)
    { m_mem.setMFloat(698, (float) val); 
      Log.Write(LogLevel.Info, "set prot6 to " + val.ToString());}

    public bool sets_prot6 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_prot6 (val);
    return true;}

    public string gets_prot6 () { 
    return get_prot6().ToString();}

    public string debug_name_prot6 () { 
    return "прот6";}

public enum local_am{
termopara1,
termopara2,
termopara3,
davl1,
davl2,
davl3,
linejka,
tolshhina,
tjen1_tek_moshhn,
kar_tek_poz,
stol_tek_poz,
schjot_slojov,
ost_slojov,
ost_slojov_dlya_dozatora,
inkrement,
davl4,
tjen2_tek_moshhn,
tjen3_tek_moshhn,
temp1,
temp2,
temp3,
temp4,
temp5,
temp6,
prot1,
prot2,
prot3,
prot4,
prot5,
prot6,
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

// ком кар отн влево,   Bool, %M522.2   reg = M  width = Bit
    public bool get_kom_kar_otn_vlevo ()
    { return (bool) m_mem.getMBit(522, 2); }

    public void set_kom_kar_otn_vlevo (bool val)
    { m_mem.setMBit(522, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_otn_vlevo to " + val.ToString());}

    public bool sets_kom_kar_otn_vlevo ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_otn_vlevo (val);
    return true;}

    public string gets_kom_kar_otn_vlevo () { 
    return get_kom_kar_otn_vlevo().ToString();}

    public string debug_name_kom_kar_otn_vlevo () { 
    return "ком кар отн влево";}

// ком кар отн вправо,   Bool, %M522.3   reg = M  width = Bit
    public bool get_kom_kar_otn_vpravo ()
    { return (bool) m_mem.getMBit(522, 3); }

    public void set_kom_kar_otn_vpravo (bool val)
    { m_mem.setMBit(522, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_otn_vpravo to " + val.ToString());}

    public bool sets_kom_kar_otn_vpravo ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_otn_vpravo (val);
    return true;}

    public string gets_kom_kar_otn_vpravo () { 
    return get_kom_kar_otn_vpravo().ToString();}

    public string debug_name_kom_kar_otn_vpravo () { 
    return "ком кар отн вправо";}

// ком кар поиск нуля,   Bool, %M522.4   reg = M  width = Bit
    public bool get_kom_kar_poisk_nulya ()
    { return (bool) m_mem.getMBit(522, 4); }

    public void set_kom_kar_poisk_nulya (bool val)
    { m_mem.setMBit(522, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kar_poisk_nulya to " + val.ToString());}

    public bool sets_kom_kar_poisk_nulya ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kar_poisk_nulya (val);
    return true;}

    public string gets_kom_kar_poisk_nulya () { 
    return get_kom_kar_poisk_nulya().ToString();}

    public string debug_name_kom_kar_poisk_nulya () { 
    return "ком кар поиск нуля";}

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
kom_kar_otn_vlevo,
kom_kar_otn_vpravo,
kom_kar_poisk_nulya,
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
};

//-----------------------------------------------------------------------------
//tags/outd.xml
//-----------------------------------------------------------------------------
// выхд кар абс,   Bool, %M500.1   reg = M  width = Bit
    public bool get_vyhd_kar_abs ()
    { return (bool) m_mem.getMBit(500, 1); }

    public void set_vyhd_kar_abs (bool val)
    { m_mem.setMBit(500, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_abs to " + val.ToString());}

    public bool sets_vyhd_kar_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_abs (val);
    return true;}

    public string gets_vyhd_kar_abs () { 
    return get_vyhd_kar_abs().ToString();}

    public string debug_name_vyhd_kar_abs () { 
    return "выхд кар абс";}

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

// выхд пит ТЭН1,   Bool, %M503.2   reg = M  width = Bit
    public bool get_vyhd_pit_tjen1 ()
    { return (bool) m_mem.getMBit(503, 2); }

    public void set_vyhd_pit_tjen1 (bool val)
    { m_mem.setMBit(503, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_tjen1 to " + val.ToString());}

    public bool sets_vyhd_pit_tjen1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_tjen1 (val);
    return true;}

    public string gets_vyhd_pit_tjen1 () { 
    return get_vyhd_pit_tjen1().ToString();}

    public string debug_name_vyhd_pit_tjen1 () { 
    return "выхд пит ТЭН1";}

// выхд пит ТЭН2,   Bool, %M503.3   reg = M  width = Bit
    public bool get_vyhd_pit_tjen2 ()
    { return (bool) m_mem.getMBit(503, 3); }

    public void set_vyhd_pit_tjen2 (bool val)
    { m_mem.setMBit(503, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_tjen2 to " + val.ToString());}

    public bool sets_vyhd_pit_tjen2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_tjen2 (val);
    return true;}

    public string gets_vyhd_pit_tjen2 () { 
    return get_vyhd_pit_tjen2().ToString();}

    public string debug_name_vyhd_pit_tjen2 () { 
    return "выхд пит ТЭН2";}

// выхд пит ТЭН3,   Bool, %M503.4   reg = M  width = Bit
    public bool get_vyhd_pit_tjen3 ()
    { return (bool) m_mem.getMBit(503, 4); }

    public void set_vyhd_pit_tjen3 (bool val)
    { m_mem.setMBit(503, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_pit_tjen3 to " + val.ToString());}

    public bool sets_vyhd_pit_tjen3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_pit_tjen3 (val);
    return true;}

    public string gets_vyhd_pit_tjen3 () { 
    return get_vyhd_pit_tjen3().ToString();}

    public string debug_name_vyhd_pit_tjen3 () { 
    return "выхд пит ТЭН3";}

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

// выхд кар отн влево,   Bool, %M506.1   reg = M  width = Bit
    public bool get_vyhd_kar_otn_vlevo ()
    { return (bool) m_mem.getMBit(506, 1); }

    public void set_vyhd_kar_otn_vlevo (bool val)
    { m_mem.setMBit(506, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_otn_vlevo to " + val.ToString());}

    public bool sets_vyhd_kar_otn_vlevo ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_otn_vlevo (val);
    return true;}

    public string gets_vyhd_kar_otn_vlevo () { 
    return get_vyhd_kar_otn_vlevo().ToString();}

    public string debug_name_vyhd_kar_otn_vlevo () { 
    return "выхд кар отн влево";}

// выхд кар отн вправо,   Bool, %M506.2   reg = M  width = Bit
    public bool get_vyhd_kar_otn_vpravo ()
    { return (bool) m_mem.getMBit(506, 2); }

    public void set_vyhd_kar_otn_vpravo (bool val)
    { m_mem.setMBit(506, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_otn_vpravo to " + val.ToString());}

    public bool sets_vyhd_kar_otn_vpravo ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_otn_vpravo (val);
    return true;}

    public string gets_vyhd_kar_otn_vpravo () { 
    return get_vyhd_kar_otn_vpravo().ToString();}

    public string debug_name_vyhd_kar_otn_vpravo () { 
    return "выхд кар отн вправо";}

// выхд кар дом,   Bool, %M506.3   reg = M  width = Bit
    public bool get_vyhd_kar_dom ()
    { return (bool) m_mem.getMBit(506, 3); }

    public void set_vyhd_kar_dom (bool val)
    { m_mem.setMBit(506, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set vyhd_kar_dom to " + val.ToString());}

    public bool sets_vyhd_kar_dom ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_vyhd_kar_dom (val);
    return true;}

    public string gets_vyhd_kar_dom () { 
    return get_vyhd_kar_dom().ToString();}

    public string debug_name_vyhd_kar_dom () { 
    return "выхд кар дом";}

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

public enum local_outd{
vyhd_kar_abs,
vyhd_stol_abs,
vyhd_pit_tjen1,
vyhd_pit_tjen2,
vyhd_pit_tjen3,
vyhd_stol_otn_vniz,
vyhd_stol_otn_vverh,
vyhd_kar_otn_vlevo,
vyhd_kar_otn_vpravo,
vyhd_kar_dom,
vyhd_stol_poisk_nulya,
vyhd_pit_lazerov,
vyhd_pit_chil1,
vyhd_pit_chil2,
vyhd_kl_chil1,
vyhd_kl_chil2,
vyhd_pit_mps,
vyhd_pit_rec,
};

//-----------------------------------------------------------------------------
//tags/usta.xml
//-----------------------------------------------------------------------------
// уст каретка скор вправо,   Real, %MD112   reg = M  width = UInt32
    public float get_ust_karetka_skor_vpravo ()
    { return (float) m_mem.getMFloat(112); }

    public void set_ust_karetka_skor_vpravo (float val)
    { m_mem.setMFloat(112, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karetka_skor_vpravo to " + val.ToString());}

    public bool sets_ust_karetka_skor_vpravo ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karetka_skor_vpravo (val);
    return true;}

    public string gets_ust_karetka_skor_vpravo () { 
    return get_ust_karetka_skor_vpravo().ToString();}

    public string debug_name_ust_karetka_skor_vpravo () { 
    return "уст каретка скор вправо";}

// уст каретка позиция,   Real, %MD124   reg = M  width = UInt32
    public float get_ust_karetka_poziciya ()
    { return (float) m_mem.getMFloat(124); }

    public void set_ust_karetka_poziciya (float val)
    { m_mem.setMFloat(124, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karetka_poziciya to " + val.ToString());}

    public bool sets_ust_karetka_poziciya ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karetka_poziciya (val);
    return true;}

    public string gets_ust_karetka_poziciya () { 
    return get_ust_karetka_poziciya().ToString();}

    public string debug_name_ust_karetka_poziciya () { 
    return "уст каретка позиция";}

// уст каретка расст,   Real, %MD128   reg = M  width = UInt32
    public float get_ust_karetka_rasst ()
    { return (float) m_mem.getMFloat(128); }

    public void set_ust_karetka_rasst (float val)
    { m_mem.setMFloat(128, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karetka_rasst to " + val.ToString());}

    public bool sets_ust_karetka_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karetka_rasst (val);
    return true;}

    public string gets_ust_karetka_rasst () { 
    return get_ust_karetka_rasst().ToString();}

    public string debug_name_ust_karetka_rasst () { 
    return "уст каретка расст";}

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

// уст каретка скор влево,   Real, %MD116   reg = M  width = UInt32
    public float get_ust_karetka_skor_vlevo ()
    { return (float) m_mem.getMFloat(116); }

    public void set_ust_karetka_skor_vlevo (float val)
    { m_mem.setMFloat(116, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karetka_skor_vlevo to " + val.ToString());}

    public bool sets_ust_karetka_skor_vlevo ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karetka_skor_vlevo (val);
    return true;}

    public string gets_ust_karetka_skor_vlevo () { 
    return get_ust_karetka_skor_vlevo().ToString();}

    public string debug_name_ust_karetka_skor_vlevo () { 
    return "уст каретка скор влево";}

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

// уст врем вращ на месте,   Real, %MD152   reg = M  width = UInt32
    public float get_ust_vrem_vrashh_na_meste ()
    { return (float) m_mem.getMFloat(152); }

    public void set_ust_vrem_vrashh_na_meste (float val)
    { m_mem.setMFloat(152, (float) val); 
      Log.Write(LogLevel.Info, "set ust_vrem_vrashh_na_meste to " + val.ToString());}

    public bool sets_ust_vrem_vrashh_na_meste ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_vrem_vrashh_na_meste (val);
    return true;}

    public string gets_ust_vrem_vrashh_na_meste () { 
    return get_ust_vrem_vrashh_na_meste().ToString();}

    public string debug_name_ust_vrem_vrashh_na_meste () { 
    return "уст врем вращ на месте";}

// уст кар поз откл ш3,   Real, %MD208   reg = M  width = UInt32
    public float get_ust_kar_poz_otkl_sh3 ()
    { return (float) m_mem.getMFloat(208); }

    public void set_ust_kar_poz_otkl_sh3 (float val)
    { m_mem.setMFloat(208, (float) val); 
      Log.Write(LogLevel.Info, "set ust_kar_poz_otkl_sh3 to " + val.ToString());}

    public bool sets_ust_kar_poz_otkl_sh3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_kar_poz_otkl_sh3 (val);
    return true;}

    public string gets_ust_kar_poz_otkl_sh3 () { 
    return get_ust_kar_poz_otkl_sh3().ToString();}

    public string debug_name_ust_kar_poz_otkl_sh3 () { 
    return "уст кар поз откл ш3";}

// уст слой кар поз слева,   Real, %MD132   reg = M  width = UInt32
    public float get_ust_sloj_kar_poz_sleva ()
    { return (float) m_mem.getMFloat(132); }

    public void set_ust_sloj_kar_poz_sleva (float val)
    { m_mem.setMFloat(132, (float) val); 
      Log.Write(LogLevel.Info, "set ust_sloj_kar_poz_sleva to " + val.ToString());}

    public bool sets_ust_sloj_kar_poz_sleva ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_sloj_kar_poz_sleva (val);
    return true;}

    public string gets_ust_sloj_kar_poz_sleva () { 
    return get_ust_sloj_kar_poz_sleva().ToString();}

    public string debug_name_ust_sloj_kar_poz_sleva () { 
    return "уст слой кар поз слева";}

// уст слой кар поз справа,   Real, %MD144   reg = M  width = UInt32
    public float get_ust_sloj_kar_poz_sprava ()
    { return (float) m_mem.getMFloat(144); }

    public void set_ust_sloj_kar_poz_sprava (float val)
    { m_mem.setMFloat(144, (float) val); 
      Log.Write(LogLevel.Info, "set ust_sloj_kar_poz_sprava to " + val.ToString());}

    public bool sets_ust_sloj_kar_poz_sprava ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_sloj_kar_poz_sprava (val);
    return true;}

    public string gets_ust_sloj_kar_poz_sprava () { 
    return get_ust_sloj_kar_poz_sprava().ToString();}

    public string debug_name_ust_sloj_kar_poz_sprava () { 
    return "уст слой кар поз справа";}

// уст стол отн внут,   Real, %MD176   reg = M  width = UInt32
    public float get_ust_stol_otn_vnut ()
    { return (float) m_mem.getMFloat(176); }

    public void set_ust_stol_otn_vnut (float val)
    { m_mem.setMFloat(176, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_otn_vnut to " + val.ToString());}

    public bool sets_ust_stol_otn_vnut ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_otn_vnut (val);
    return true;}

    public string gets_ust_stol_otn_vnut () { 
    return get_ust_stol_otn_vnut().ToString();}

    public string debug_name_ust_stol_otn_vnut () { 
    return "уст стол отн внут";}

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

// уст кол слоёв,   Int, %MW292   reg = M  width = UInt16
    public Int16 get_ust_kol_slojov ()
    { return (Int16) m_mem.getMUInt16(292); }

    public void set_ust_kol_slojov (Int16 val)
    { m_mem.setMUInt16(292, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ust_kol_slojov to " + val.ToString());}

    public bool sets_ust_kol_slojov ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ust_kol_slojov (val);
    return true;}

    public string gets_ust_kol_slojov () { 
    return get_ust_kol_slojov().ToString();}

    public string debug_name_ust_kol_slojov () { 
    return "уст кол слоёв";}

// уст кол слоёв для дозатора,   Int, %MW294   reg = M  width = UInt16
    public Int16 get_ust_kol_slojov_dlya_dozatora ()
    { return (Int16) m_mem.getMUInt16(294); }

    public void set_ust_kol_slojov_dlya_dozatora (Int16 val)
    { m_mem.setMUInt16(294, (UInt16) val); 
      Log.Write(LogLevel.Info, "set ust_kol_slojov_dlya_dozatora to " + val.ToString());}

    public bool sets_ust_kol_slojov_dlya_dozatora ( string str) {
    Int16 val;
    if (!Int16.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as Int16 ");
        return false; }
    set_ust_kol_slojov_dlya_dozatora (val);
    return true;}

    public string gets_ust_kol_slojov_dlya_dozatora () { 
    return get_ust_kol_slojov_dlya_dozatora().ToString();}

    public string debug_name_ust_kol_slojov_dlya_dozatora () { 
    return "уст кол слоёв для дозатора";}

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

public enum local_usta{
ust_karetka_skor_vpravo,
ust_karetka_poziciya,
ust_karetka_rasst,
ust_stol_poziciya,
ust_stol_skor_vverh,
ust_karetka_skor_vlevo,
ust_stol_otn_rasst,
ust_vrem_vrashh_na_meste,
ust_kar_poz_otkl_sh3,
ust_sloj_kar_poz_sleva,
ust_sloj_kar_poz_sprava,
ust_stol_otn_vnut,
ust_tolshh_sloya,
ust_stol_otn_rasst_avto,
ust_tjen1_moshhn,
ust_tjen2_moshhn,
ust_tjen3_moshhn,
ust_kol_slojov,
ust_kol_slojov_dlya_dozatora,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
};

public enum gTags{
termopara1,
termopara2,
termopara3,
davl1,
davl2,
davl3,
linejka,
tolshhina,
tjen1_tek_moshhn,
kar_tek_poz,
stol_tek_poz,
schjot_slojov,
ost_slojov,
ost_slojov_dlya_dozatora,
inkrement,
davl4,
tjen2_tek_moshhn,
tjen3_tek_moshhn,
temp1,
temp2,
temp3,
temp4,
temp5,
temp6,
prot1,
prot2,
prot3,
prot4,
prot5,
prot6,
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
kom_kar_otn_vlevo,
kom_kar_otn_vpravo,
kom_kar_poisk_nulya,
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
vyhd_kar_abs,
vyhd_stol_abs,
vyhd_pit_tjen1,
vyhd_pit_tjen2,
vyhd_pit_tjen3,
vyhd_stol_otn_vniz,
vyhd_stol_otn_vverh,
vyhd_kar_otn_vlevo,
vyhd_kar_otn_vpravo,
vyhd_kar_dom,
vyhd_stol_poisk_nulya,
vyhd_pit_lazerov,
vyhd_pit_chil1,
vyhd_pit_chil2,
vyhd_kl_chil1,
vyhd_kl_chil2,
vyhd_pit_mps,
vyhd_pit_rec,
ust_karetka_skor_vpravo,
ust_karetka_poziciya,
ust_karetka_rasst,
ust_stol_poziciya,
ust_stol_skor_vverh,
ust_karetka_skor_vlevo,
ust_stol_otn_rasst,
ust_vrem_vrashh_na_meste,
ust_kar_poz_otkl_sh3,
ust_sloj_kar_poz_sleva,
ust_sloj_kar_poz_sprava,
ust_stol_otn_vnut,
ust_tolshh_sloya,
ust_stol_otn_rasst_avto,
ust_tjen1_moshhn,
ust_tjen2_moshhn,
ust_tjen3_moshhn,
ust_kol_slojov,
ust_kol_slojov_dlya_dozatora,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
};

    public string get_by_name(string str) {
    switch (str){case "termopara1":
   return gets_termopara1();
case "termopara2":
   return gets_termopara2();
case "termopara3":
   return gets_termopara3();
case "davl1":
   return gets_davl1();
case "davl2":
   return gets_davl2();
case "davl3":
   return gets_davl3();
case "linejka":
   return gets_linejka();
case "tolshhina":
   return gets_tolshhina();
case "tjen1_tek_moshhn":
   return gets_tjen1_tek_moshhn();
case "kar_tek_poz":
   return gets_kar_tek_poz();
case "stol_tek_poz":
   return gets_stol_tek_poz();
case "schjot_slojov":
   return gets_schjot_slojov();
case "ost_slojov":
   return gets_ost_slojov();
case "ost_slojov_dlya_dozatora":
   return gets_ost_slojov_dlya_dozatora();
case "inkrement":
   return gets_inkrement();
case "davl4":
   return gets_davl4();
case "tjen2_tek_moshhn":
   return gets_tjen2_tek_moshhn();
case "tjen3_tek_moshhn":
   return gets_tjen3_tek_moshhn();
case "temp1":
   return gets_temp1();
case "temp2":
   return gets_temp2();
case "temp3":
   return gets_temp3();
case "temp4":
   return gets_temp4();
case "temp5":
   return gets_temp5();
case "temp6":
   return gets_temp6();
case "prot1":
   return gets_prot1();
case "prot2":
   return gets_prot2();
case "prot3":
   return gets_prot3();
case "prot4":
   return gets_prot4();
case "prot5":
   return gets_prot5();
case "prot6":
   return gets_prot6();
case "kom_stol_abs":
   return gets_kom_stol_abs();
case "kom_tp_pusk":
   return gets_kom_tp_pusk();
case "kom_tp_prer":
   return gets_kom_tp_prer();
case "kom_kar_abs":
   return gets_kom_kar_abs();
case "kom_stol_stop":
   return gets_kom_stol_stop();
case "kom_karetka_stop":
   return gets_kom_karetka_stop();
case "kom_karetka_sbros":
   return gets_kom_karetka_sbros();
case "kom_stol_sbros":
   return gets_kom_stol_sbros();
case "kom_stol_ust_nulya":
   return gets_kom_stol_ust_nulya();
case "kom_stol_otn_pusk_vniz":
   return gets_kom_stol_otn_pusk_vniz();
case "kom_stol_otn_pusk_vverh":
   return gets_kom_stol_otn_pusk_vverh();
case "kom_sloj":
   return gets_kom_sloj();
case "kom_prer":
   return gets_kom_prer();
case "kom_kar_otn_vlevo":
   return gets_kom_kar_otn_vlevo();
case "kom_kar_otn_vpravo":
   return gets_kom_kar_otn_vpravo();
case "kom_kar_poisk_nulya":
   return gets_kom_kar_poisk_nulya();
case "kom_obnulit_linejku":
   return gets_kom_obnulit_linejku();
case "kom_pit_tjen3":
   return gets_kom_pit_tjen3();
case "kom_pit_tjen1":
   return gets_kom_pit_tjen1();
case "kom_pit_tjen2":
   return gets_kom_pit_tjen2();
case "kom_stol_poisk_nulya":
   return gets_kom_stol_poisk_nulya();
case "kom_process":
   return gets_kom_process();
case "kom_proc_obshh":
   return gets_kom_proc_obshh();
case "kom_pereschjot":
   return gets_kom_pereschjot();
case "kom_pit_laz":
   return gets_kom_pit_laz();
case "kom_got_laz":
   return gets_kom_got_laz();
case "kom_sloj_sbros_schjotchika":
   return gets_kom_sloj_sbros_schjotchika();
case "kom_pauza":
   return gets_kom_pauza();
case "kom_rab_do_pauzy":
   return gets_kom_rab_do_pauzy();
case "kom_dozator_avtomat":
   return gets_kom_dozator_avtomat();
case "kom_pit_chil1":
   return gets_kom_pit_chil1();
case "kom_pit_chil2":
   return gets_kom_pit_chil2();
case "kom_kl_chil1":
   return gets_kom_kl_chil1();
case "kom_kl_chil2":
   return gets_kom_kl_chil2();
case "kom_pit_rec":
   return gets_kom_pit_rec();
case "kom_pit_mps":
   return gets_kom_pit_mps();
case "vyhd_kar_abs":
   return gets_vyhd_kar_abs();
case "vyhd_stol_abs":
   return gets_vyhd_stol_abs();
case "vyhd_pit_tjen1":
   return gets_vyhd_pit_tjen1();
case "vyhd_pit_tjen2":
   return gets_vyhd_pit_tjen2();
case "vyhd_pit_tjen3":
   return gets_vyhd_pit_tjen3();
case "vyhd_stol_otn_vniz":
   return gets_vyhd_stol_otn_vniz();
case "vyhd_stol_otn_vverh":
   return gets_vyhd_stol_otn_vverh();
case "vyhd_kar_otn_vlevo":
   return gets_vyhd_kar_otn_vlevo();
case "vyhd_kar_otn_vpravo":
   return gets_vyhd_kar_otn_vpravo();
case "vyhd_kar_dom":
   return gets_vyhd_kar_dom();
case "vyhd_stol_poisk_nulya":
   return gets_vyhd_stol_poisk_nulya();
case "vyhd_pit_lazerov":
   return gets_vyhd_pit_lazerov();
case "vyhd_pit_chil1":
   return gets_vyhd_pit_chil1();
case "vyhd_pit_chil2":
   return gets_vyhd_pit_chil2();
case "vyhd_kl_chil1":
   return gets_vyhd_kl_chil1();
case "vyhd_kl_chil2":
   return gets_vyhd_kl_chil2();
case "vyhd_pit_mps":
   return gets_vyhd_pit_mps();
case "vyhd_pit_rec":
   return gets_vyhd_pit_rec();
case "ust_karetka_skor_vpravo":
   return gets_ust_karetka_skor_vpravo();
case "ust_karetka_poziciya":
   return gets_ust_karetka_poziciya();
case "ust_karetka_rasst":
   return gets_ust_karetka_rasst();
case "ust_stol_poziciya":
   return gets_ust_stol_poziciya();
case "ust_stol_skor_vverh":
   return gets_ust_stol_skor_vverh();
case "ust_karetka_skor_vlevo":
   return gets_ust_karetka_skor_vlevo();
case "ust_stol_otn_rasst":
   return gets_ust_stol_otn_rasst();
case "ust_vrem_vrashh_na_meste":
   return gets_ust_vrem_vrashh_na_meste();
case "ust_kar_poz_otkl_sh3":
   return gets_ust_kar_poz_otkl_sh3();
case "ust_sloj_kar_poz_sleva":
   return gets_ust_sloj_kar_poz_sleva();
case "ust_sloj_kar_poz_sprava":
   return gets_ust_sloj_kar_poz_sprava();
case "ust_stol_otn_vnut":
   return gets_ust_stol_otn_vnut();
case "ust_tolshh_sloya":
   return gets_ust_tolshh_sloya();
case "ust_stol_otn_rasst_avto":
   return gets_ust_stol_otn_rasst_avto();
case "ust_tjen1_moshhn":
   return gets_ust_tjen1_moshhn();
case "ust_tjen2_moshhn":
   return gets_ust_tjen2_moshhn();
case "ust_tjen3_moshhn":
   return gets_ust_tjen3_moshhn();
case "ust_kol_slojov":
   return gets_ust_kol_slojov();
case "ust_kol_slojov_dlya_dozatora":
   return gets_ust_kol_slojov_dlya_dozatora();
case "ust_tjen1_temp":
   return gets_ust_tjen1_temp();
case "ust_tjen2_temp":
   return gets_ust_tjen2_temp();
case "ust_tjen3_temp":
   return gets_ust_tjen3_temp();
default: 
   return "NAN";
} 
 }
    public bool set_by_name(string str, string val) {
    switch (str){case "termopara1":
   return sets_termopara1(val);
case "termopara2":
   return sets_termopara2(val);
case "termopara3":
   return sets_termopara3(val);
case "davl1":
   return sets_davl1(val);
case "davl2":
   return sets_davl2(val);
case "davl3":
   return sets_davl3(val);
case "linejka":
   return sets_linejka(val);
case "tolshhina":
   return sets_tolshhina(val);
case "tjen1_tek_moshhn":
   return sets_tjen1_tek_moshhn(val);
case "kar_tek_poz":
   return sets_kar_tek_poz(val);
case "stol_tek_poz":
   return sets_stol_tek_poz(val);
case "schjot_slojov":
   return sets_schjot_slojov(val);
case "ost_slojov":
   return sets_ost_slojov(val);
case "ost_slojov_dlya_dozatora":
   return sets_ost_slojov_dlya_dozatora(val);
case "inkrement":
   return sets_inkrement(val);
case "davl4":
   return sets_davl4(val);
case "tjen2_tek_moshhn":
   return sets_tjen2_tek_moshhn(val);
case "tjen3_tek_moshhn":
   return sets_tjen3_tek_moshhn(val);
case "temp1":
   return sets_temp1(val);
case "temp2":
   return sets_temp2(val);
case "temp3":
   return sets_temp3(val);
case "temp4":
   return sets_temp4(val);
case "temp5":
   return sets_temp5(val);
case "temp6":
   return sets_temp6(val);
case "prot1":
   return sets_prot1(val);
case "prot2":
   return sets_prot2(val);
case "prot3":
   return sets_prot3(val);
case "prot4":
   return sets_prot4(val);
case "prot5":
   return sets_prot5(val);
case "prot6":
   return sets_prot6(val);
case "kom_stol_abs":
   return sets_kom_stol_abs(val);
case "kom_tp_pusk":
   return sets_kom_tp_pusk(val);
case "kom_tp_prer":
   return sets_kom_tp_prer(val);
case "kom_kar_abs":
   return sets_kom_kar_abs(val);
case "kom_stol_stop":
   return sets_kom_stol_stop(val);
case "kom_karetka_stop":
   return sets_kom_karetka_stop(val);
case "kom_karetka_sbros":
   return sets_kom_karetka_sbros(val);
case "kom_stol_sbros":
   return sets_kom_stol_sbros(val);
case "kom_stol_ust_nulya":
   return sets_kom_stol_ust_nulya(val);
case "kom_stol_otn_pusk_vniz":
   return sets_kom_stol_otn_pusk_vniz(val);
case "kom_stol_otn_pusk_vverh":
   return sets_kom_stol_otn_pusk_vverh(val);
case "kom_sloj":
   return sets_kom_sloj(val);
case "kom_prer":
   return sets_kom_prer(val);
case "kom_kar_otn_vlevo":
   return sets_kom_kar_otn_vlevo(val);
case "kom_kar_otn_vpravo":
   return sets_kom_kar_otn_vpravo(val);
case "kom_kar_poisk_nulya":
   return sets_kom_kar_poisk_nulya(val);
case "kom_obnulit_linejku":
   return sets_kom_obnulit_linejku(val);
case "kom_pit_tjen3":
   return sets_kom_pit_tjen3(val);
case "kom_pit_tjen1":
   return sets_kom_pit_tjen1(val);
case "kom_pit_tjen2":
   return sets_kom_pit_tjen2(val);
case "kom_stol_poisk_nulya":
   return sets_kom_stol_poisk_nulya(val);
case "kom_process":
   return sets_kom_process(val);
case "kom_proc_obshh":
   return sets_kom_proc_obshh(val);
case "kom_pereschjot":
   return sets_kom_pereschjot(val);
case "kom_pit_laz":
   return sets_kom_pit_laz(val);
case "kom_got_laz":
   return sets_kom_got_laz(val);
case "kom_sloj_sbros_schjotchika":
   return sets_kom_sloj_sbros_schjotchika(val);
case "kom_pauza":
   return sets_kom_pauza(val);
case "kom_rab_do_pauzy":
   return sets_kom_rab_do_pauzy(val);
case "kom_dozator_avtomat":
   return sets_kom_dozator_avtomat(val);
case "kom_pit_chil1":
   return sets_kom_pit_chil1(val);
case "kom_pit_chil2":
   return sets_kom_pit_chil2(val);
case "kom_kl_chil1":
   return sets_kom_kl_chil1(val);
case "kom_kl_chil2":
   return sets_kom_kl_chil2(val);
case "kom_pit_rec":
   return sets_kom_pit_rec(val);
case "kom_pit_mps":
   return sets_kom_pit_mps(val);
case "vyhd_kar_abs":
   return sets_vyhd_kar_abs(val);
case "vyhd_stol_abs":
   return sets_vyhd_stol_abs(val);
case "vyhd_pit_tjen1":
   return sets_vyhd_pit_tjen1(val);
case "vyhd_pit_tjen2":
   return sets_vyhd_pit_tjen2(val);
case "vyhd_pit_tjen3":
   return sets_vyhd_pit_tjen3(val);
case "vyhd_stol_otn_vniz":
   return sets_vyhd_stol_otn_vniz(val);
case "vyhd_stol_otn_vverh":
   return sets_vyhd_stol_otn_vverh(val);
case "vyhd_kar_otn_vlevo":
   return sets_vyhd_kar_otn_vlevo(val);
case "vyhd_kar_otn_vpravo":
   return sets_vyhd_kar_otn_vpravo(val);
case "vyhd_kar_dom":
   return sets_vyhd_kar_dom(val);
case "vyhd_stol_poisk_nulya":
   return sets_vyhd_stol_poisk_nulya(val);
case "vyhd_pit_lazerov":
   return sets_vyhd_pit_lazerov(val);
case "vyhd_pit_chil1":
   return sets_vyhd_pit_chil1(val);
case "vyhd_pit_chil2":
   return sets_vyhd_pit_chil2(val);
case "vyhd_kl_chil1":
   return sets_vyhd_kl_chil1(val);
case "vyhd_kl_chil2":
   return sets_vyhd_kl_chil2(val);
case "vyhd_pit_mps":
   return sets_vyhd_pit_mps(val);
case "vyhd_pit_rec":
   return sets_vyhd_pit_rec(val);
case "ust_karetka_skor_vpravo":
   return sets_ust_karetka_skor_vpravo(val);
case "ust_karetka_poziciya":
   return sets_ust_karetka_poziciya(val);
case "ust_karetka_rasst":
   return sets_ust_karetka_rasst(val);
case "ust_stol_poziciya":
   return sets_ust_stol_poziciya(val);
case "ust_stol_skor_vverh":
   return sets_ust_stol_skor_vverh(val);
case "ust_karetka_skor_vlevo":
   return sets_ust_karetka_skor_vlevo(val);
case "ust_stol_otn_rasst":
   return sets_ust_stol_otn_rasst(val);
case "ust_vrem_vrashh_na_meste":
   return sets_ust_vrem_vrashh_na_meste(val);
case "ust_kar_poz_otkl_sh3":
   return sets_ust_kar_poz_otkl_sh3(val);
case "ust_sloj_kar_poz_sleva":
   return sets_ust_sloj_kar_poz_sleva(val);
case "ust_sloj_kar_poz_sprava":
   return sets_ust_sloj_kar_poz_sprava(val);
case "ust_stol_otn_vnut":
   return sets_ust_stol_otn_vnut(val);
case "ust_tolshh_sloya":
   return sets_ust_tolshh_sloya(val);
case "ust_stol_otn_rasst_avto":
   return sets_ust_stol_otn_rasst_avto(val);
case "ust_tjen1_moshhn":
   return sets_ust_tjen1_moshhn(val);
case "ust_tjen2_moshhn":
   return sets_ust_tjen2_moshhn(val);
case "ust_tjen3_moshhn":
   return sets_ust_tjen3_moshhn(val);
case "ust_kol_slojov":
   return sets_ust_kol_slojov(val);
case "ust_kol_slojov_dlya_dozatora":
   return sets_ust_kol_slojov_dlya_dozatora(val);
case "ust_tjen1_temp":
   return sets_ust_tjen1_temp(val);
case "ust_tjen2_temp":
   return sets_ust_tjen2_temp(val);
case "ust_tjen3_temp":
   return sets_ust_tjen3_temp(val);
default: 
   return false;
} 
 }
    public string get_debug_by_name(string str) {
    switch (str){case "termopara1":
   return debug_name_termopara1();
case "termopara2":
   return debug_name_termopara2();
case "termopara3":
   return debug_name_termopara3();
case "davl1":
   return debug_name_davl1();
case "davl2":
   return debug_name_davl2();
case "davl3":
   return debug_name_davl3();
case "linejka":
   return debug_name_linejka();
case "tolshhina":
   return debug_name_tolshhina();
case "tjen1_tek_moshhn":
   return debug_name_tjen1_tek_moshhn();
case "kar_tek_poz":
   return debug_name_kar_tek_poz();
case "stol_tek_poz":
   return debug_name_stol_tek_poz();
case "schjot_slojov":
   return debug_name_schjot_slojov();
case "ost_slojov":
   return debug_name_ost_slojov();
case "ost_slojov_dlya_dozatora":
   return debug_name_ost_slojov_dlya_dozatora();
case "inkrement":
   return debug_name_inkrement();
case "davl4":
   return debug_name_davl4();
case "tjen2_tek_moshhn":
   return debug_name_tjen2_tek_moshhn();
case "tjen3_tek_moshhn":
   return debug_name_tjen3_tek_moshhn();
case "temp1":
   return debug_name_temp1();
case "temp2":
   return debug_name_temp2();
case "temp3":
   return debug_name_temp3();
case "temp4":
   return debug_name_temp4();
case "temp5":
   return debug_name_temp5();
case "temp6":
   return debug_name_temp6();
case "prot1":
   return debug_name_prot1();
case "prot2":
   return debug_name_prot2();
case "prot3":
   return debug_name_prot3();
case "prot4":
   return debug_name_prot4();
case "prot5":
   return debug_name_prot5();
case "prot6":
   return debug_name_prot6();
case "kom_stol_abs":
   return debug_name_kom_stol_abs();
case "kom_tp_pusk":
   return debug_name_kom_tp_pusk();
case "kom_tp_prer":
   return debug_name_kom_tp_prer();
case "kom_kar_abs":
   return debug_name_kom_kar_abs();
case "kom_stol_stop":
   return debug_name_kom_stol_stop();
case "kom_karetka_stop":
   return debug_name_kom_karetka_stop();
case "kom_karetka_sbros":
   return debug_name_kom_karetka_sbros();
case "kom_stol_sbros":
   return debug_name_kom_stol_sbros();
case "kom_stol_ust_nulya":
   return debug_name_kom_stol_ust_nulya();
case "kom_stol_otn_pusk_vniz":
   return debug_name_kom_stol_otn_pusk_vniz();
case "kom_stol_otn_pusk_vverh":
   return debug_name_kom_stol_otn_pusk_vverh();
case "kom_sloj":
   return debug_name_kom_sloj();
case "kom_prer":
   return debug_name_kom_prer();
case "kom_kar_otn_vlevo":
   return debug_name_kom_kar_otn_vlevo();
case "kom_kar_otn_vpravo":
   return debug_name_kom_kar_otn_vpravo();
case "kom_kar_poisk_nulya":
   return debug_name_kom_kar_poisk_nulya();
case "kom_obnulit_linejku":
   return debug_name_kom_obnulit_linejku();
case "kom_pit_tjen3":
   return debug_name_kom_pit_tjen3();
case "kom_pit_tjen1":
   return debug_name_kom_pit_tjen1();
case "kom_pit_tjen2":
   return debug_name_kom_pit_tjen2();
case "kom_stol_poisk_nulya":
   return debug_name_kom_stol_poisk_nulya();
case "kom_process":
   return debug_name_kom_process();
case "kom_proc_obshh":
   return debug_name_kom_proc_obshh();
case "kom_pereschjot":
   return debug_name_kom_pereschjot();
case "kom_pit_laz":
   return debug_name_kom_pit_laz();
case "kom_got_laz":
   return debug_name_kom_got_laz();
case "kom_sloj_sbros_schjotchika":
   return debug_name_kom_sloj_sbros_schjotchika();
case "kom_pauza":
   return debug_name_kom_pauza();
case "kom_rab_do_pauzy":
   return debug_name_kom_rab_do_pauzy();
case "kom_dozator_avtomat":
   return debug_name_kom_dozator_avtomat();
case "kom_pit_chil1":
   return debug_name_kom_pit_chil1();
case "kom_pit_chil2":
   return debug_name_kom_pit_chil2();
case "kom_kl_chil1":
   return debug_name_kom_kl_chil1();
case "kom_kl_chil2":
   return debug_name_kom_kl_chil2();
case "kom_pit_rec":
   return debug_name_kom_pit_rec();
case "kom_pit_mps":
   return debug_name_kom_pit_mps();
case "vyhd_kar_abs":
   return debug_name_vyhd_kar_abs();
case "vyhd_stol_abs":
   return debug_name_vyhd_stol_abs();
case "vyhd_pit_tjen1":
   return debug_name_vyhd_pit_tjen1();
case "vyhd_pit_tjen2":
   return debug_name_vyhd_pit_tjen2();
case "vyhd_pit_tjen3":
   return debug_name_vyhd_pit_tjen3();
case "vyhd_stol_otn_vniz":
   return debug_name_vyhd_stol_otn_vniz();
case "vyhd_stol_otn_vverh":
   return debug_name_vyhd_stol_otn_vverh();
case "vyhd_kar_otn_vlevo":
   return debug_name_vyhd_kar_otn_vlevo();
case "vyhd_kar_otn_vpravo":
   return debug_name_vyhd_kar_otn_vpravo();
case "vyhd_kar_dom":
   return debug_name_vyhd_kar_dom();
case "vyhd_stol_poisk_nulya":
   return debug_name_vyhd_stol_poisk_nulya();
case "vyhd_pit_lazerov":
   return debug_name_vyhd_pit_lazerov();
case "vyhd_pit_chil1":
   return debug_name_vyhd_pit_chil1();
case "vyhd_pit_chil2":
   return debug_name_vyhd_pit_chil2();
case "vyhd_kl_chil1":
   return debug_name_vyhd_kl_chil1();
case "vyhd_kl_chil2":
   return debug_name_vyhd_kl_chil2();
case "vyhd_pit_mps":
   return debug_name_vyhd_pit_mps();
case "vyhd_pit_rec":
   return debug_name_vyhd_pit_rec();
case "ust_karetka_skor_vpravo":
   return debug_name_ust_karetka_skor_vpravo();
case "ust_karetka_poziciya":
   return debug_name_ust_karetka_poziciya();
case "ust_karetka_rasst":
   return debug_name_ust_karetka_rasst();
case "ust_stol_poziciya":
   return debug_name_ust_stol_poziciya();
case "ust_stol_skor_vverh":
   return debug_name_ust_stol_skor_vverh();
case "ust_karetka_skor_vlevo":
   return debug_name_ust_karetka_skor_vlevo();
case "ust_stol_otn_rasst":
   return debug_name_ust_stol_otn_rasst();
case "ust_vrem_vrashh_na_meste":
   return debug_name_ust_vrem_vrashh_na_meste();
case "ust_kar_poz_otkl_sh3":
   return debug_name_ust_kar_poz_otkl_sh3();
case "ust_sloj_kar_poz_sleva":
   return debug_name_ust_sloj_kar_poz_sleva();
case "ust_sloj_kar_poz_sprava":
   return debug_name_ust_sloj_kar_poz_sprava();
case "ust_stol_otn_vnut":
   return debug_name_ust_stol_otn_vnut();
case "ust_tolshh_sloya":
   return debug_name_ust_tolshh_sloya();
case "ust_stol_otn_rasst_avto":
   return debug_name_ust_stol_otn_rasst_avto();
case "ust_tjen1_moshhn":
   return debug_name_ust_tjen1_moshhn();
case "ust_tjen2_moshhn":
   return debug_name_ust_tjen2_moshhn();
case "ust_tjen3_moshhn":
   return debug_name_ust_tjen3_moshhn();
case "ust_kol_slojov":
   return debug_name_ust_kol_slojov();
case "ust_kol_slojov_dlya_dozatora":
   return debug_name_ust_kol_slojov_dlya_dozatora();
case "ust_tjen1_temp":
   return debug_name_ust_tjen1_temp();
case "ust_tjen2_temp":
   return debug_name_ust_tjen2_temp();
case "ust_tjen3_temp":
   return debug_name_ust_tjen3_temp();
default: 
   return "NAN";
} 
 }
    }
 }
//____________________________________________________________________________________________________
//________++++++++++++____++++++++++++++++____++++++++++++____________________++++++++________________
//____++++++++________________________________________________________________++++++++++++++++++++++++
//++++________________________________________________________________________________________________
//____________________________________________________________________________________________________
//+__+_+++__________+++++_+++++_______________________________________________________________________
//____++++++++++++++++++++++++______________++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//++________________________________++++++++______++++____++++++++++++++++++__________________________
//____________________________________________________________________________________________________
//____________________________________________________________________________________________________
