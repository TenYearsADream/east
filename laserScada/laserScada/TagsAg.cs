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

// “ЁЌ1†тек†мощн,   Real, %MD650   reg = M  width = UInt32
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
    return "“ЁЌ1†тек†мощн";}

// кар†тек†поз,   Real, %MD734   reg = M  width = UInt32
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
    return "кар†тек†поз";}

// стол†тек†поз,   Real, %MD738   reg = M  width = UInt32
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
    return "стол†тек†поз";}

// счЄт†слоЄв,   DInt, %MD748   reg = M  width = UInt32
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
    return "счЄт†слоЄв";}

// ост†слоЄв,   Int, %MW756   reg = M  width = UInt16
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
    return "ост†слоЄв";}

// ост†слоЄв†дл€†дозатора,   Int, %MW758   reg = M  width = UInt16
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
    return "ост†слоЄв†дл€†дозатора";}

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

// “ЁЌ2†тек†мощн,   Real, %MD766   reg = M  width = UInt32
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
    return "“ЁЌ2†тек†мощн";}

// “ЁЌ3†тек†мощн,   Real, %MD770   reg = M  width = UInt32
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
    return "“ЁЌ3†тек†мощн";}

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
// ком†стол†абс,   Bool, %M518.4   reg = M  width = Bit
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
    return "ком†стол†абс";}

// ком†“ѕ†пуск,   Bool, %M518.6   reg = M  width = Bit
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
    return "ком†“ѕ†пуск";}

// ком†“ѕ†прер,   Bool, %M518.7   reg = M  width = Bit
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
    return "ком†“ѕ†прер";}

// ком†кар†абс,   Bool, %M519.0   reg = M  width = Bit
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
    return "ком†кар†абс";}

// ком†стол†стоп,   Bool, %M519.2   reg = M  width = Bit
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
    return "ком†стол†стоп";}

// ком†каретка†стоп,   Bool, %M519.3   reg = M  width = Bit
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
    return "ком†каретка†стоп";}

// ком†каретка†сброс,   Bool, %M520.5   reg = M  width = Bit
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
    return "ком†каретка†сброс";}

// ком†стол†сброс,   Bool, %M520.6   reg = M  width = Bit
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
    return "ком†стол†сброс";}

// ком†стол†уст†нул€,   Bool, %M521.0   reg = M  width = Bit
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
    return "ком†стол†уст†нул€";}

// ком†стол†отн†пуск†вниз,   Bool, %M521.2   reg = M  width = Bit
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
    return "ком†стол†отн†пуск†вниз";}

// ком†стол†отн†пуск†вверх,   Bool, %M521.3   reg = M  width = Bit
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
    return "ком†стол†отн†пуск†вверх";}

// ком†слой,   Bool, %M521.5   reg = M  width = Bit
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
    return "ком†слой";}

// ком†прер,   Bool, %M521.7   reg = M  width = Bit
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
    return "ком†прер";}

// ком†резерв,   Bool, %M522.2   reg = M  width = Bit
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
    return "ком†резерв";}

// ком†резерв(1),   Bool, %M522.3   reg = M  width = Bit
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
    return "ком†резерв(1)";}

// ком†резерв(2),   Bool, %M522.4   reg = M  width = Bit
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
    return "ком†резерв(2)";}

// ком†обнулить†линейку,   Bool, %M522.7   reg = M  width = Bit
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
    return "ком†обнулить†линейку";}

// ком†пит†“ЁЌ3,   Bool, %M524.2   reg = M  width = Bit
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
    return "ком†пит†“ЁЌ3";}

// ком†пит†“ЁЌ1,   Bool, %M524.3   reg = M  width = Bit
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
    return "ком†пит†“ЁЌ1";}

// ком†пит†“ЁЌ2,   Bool, %M524.4   reg = M  width = Bit
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
    return "ком†пит†“ЁЌ2";}

// ком†стол†поиск†нул€,   Bool, %M525.7   reg = M  width = Bit
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
    return "ком†стол†поиск†нул€";}

// ком†процесс,   Bool, %M521.4   reg = M  width = Bit
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
    return "ком†процесс";}

// ком†проц†общ,   Bool, %M526.0   reg = M  width = Bit
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
    return "ком†проц†общ";}

// ком†пересчЄт,   Bool, %M526.1   reg = M  width = Bit
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
    return "ком†пересчЄт";}

// ком†пит†лаз,   Bool, %M526.2   reg = M  width = Bit
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
    return "ком†пит†лаз";}

// ком†гот†лаз,   Bool, %M526.3   reg = M  width = Bit
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
    return "ком†гот†лаз";}

// ком†слой†сброс†счЄтчика,   Bool, %M526.5   reg = M  width = Bit
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
    return "ком†слой†сброс†счЄтчика";}

// ком†пауза,   Bool, %M526.7   reg = M  width = Bit
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
    return "ком†пауза";}

// ком†раб†до†паузы,   Bool, %M527.0   reg = M  width = Bit
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
    return "ком†раб†до†паузы";}

// ком†дозатор†автомат,   Bool, %M527.1   reg = M  width = Bit
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
    return "ком†дозатор†автомат";}

// ком†пит†чил1,   Bool, %M527.7   reg = M  width = Bit
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
    return "ком†пит†чил1";}

// ком†пит†чил2,   Bool, %M528.0   reg = M  width = Bit
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
    return "ком†пит†чил2";}

// ком†кл†чил1,   Bool, %M528.1   reg = M  width = Bit
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
    return "ком†кл†чил1";}

// ком†кл†чил2,   Bool, %M528.2   reg = M  width = Bit
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
    return "ком†кл†чил2";}

// ком†пит†рец,   Bool, %M528.3   reg = M  width = Bit
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
    return "ком†пит†рец";}

// ком†пит†ћѕ—,   Bool, %M528.4   reg = M  width = Bit
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
    return "ком†пит†ћѕ—";}

// ком†кар†лев†ш1†вперЄд,   Bool, %M529.2   reg = M  width = Bit
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
    return "ком†кар†лев†ш1†вперЄд";}

// ком†кар†лев†ш1†назад,   Bool, %M529.3   reg = M  width = Bit
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
    return "ком†кар†лев†ш1†назад";}

// ком†кар†лев†ш1†абс,   Bool, %M529.4   reg = M  width = Bit
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
    return "ком†кар†лев†ш1†абс";}

// ком†кар†лев†ш1†стоп,   Bool, %M529.5   reg = M  width = Bit
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
    return "ком†кар†лев†ш1†стоп";}

// ком†кар†прав†ш2†вперЄд,   Bool, %M529.6   reg = M  width = Bit
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
    return "ком†кар†прав†ш2†вперЄд";}

// ком†кар†прав†ш2†назад,   Bool, %M529.7   reg = M  width = Bit
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
    return "ком†кар†прав†ш2†назад";}

// ком†кар†прав†ш2†абс,   Bool, %M530.1   reg = M  width = Bit
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
    return "ком†кар†прав†ш2†абс";}

// ком†кар†прав†ш2†стоп,   Bool, %M531.3   reg = M  width = Bit
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
    return "ком†кар†прав†ш2†стоп";}

// ком†бар†прав†ш3†вперЄд,   Bool, %M531.4   reg = M  width = Bit
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
    return "ком†бар†прав†ш3†вперЄд";}

// ком†бар†прав†ш3†назад,   Bool, %M531.5   reg = M  width = Bit
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
    return "ком†бар†прав†ш3†назад";}

// ком†бар†прав†ш3†абс,   Bool, %M531.6   reg = M  width = Bit
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
    return "ком†бар†прав†ш3†абс";}

// ком†бар†прав†ш3†стоп,   Bool, %M531.7   reg = M  width = Bit
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
    return "ком†бар†прав†ш3†стоп";}

// ком†бар†лев†ш4†вперЄд,   Bool, %M532.0   reg = M  width = Bit
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
    return "ком†бар†лев†ш4†вперЄд";}

// ком†бар†лев†ш4†назад,   Bool, %M532.1   reg = M  width = Bit
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
    return "ком†бар†лев†ш4†назад";}

// ком†бар†лев†ш4†абс,   Bool, %M532.2   reg = M  width = Bit
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
    return "ком†бар†лев†ш4†абс";}

// ком†бар†лев†ш4†стоп,   Bool, %M532.3   reg = M  width = Bit
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
    return "ком†бар†лев†ш4†стоп";}

// ком†дозатор†лев†впер,   Bool, %M532.4   reg = M  width = Bit
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
    return "ком†дозатор†лев†впер";}

// ком†дозатор†прав†впер,   Bool, %M532.7   reg = M  width = Bit
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
    return "ком†дозатор†прав†впер";}

// ком†толкатель†лев†вперЄд,   Bool, %M533.2   reg = M  width = Bit
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
    return "ком†толкатель†лев†вперЄд";}

// ком†толкатель†лев†назад,   Bool, %M533.3   reg = M  width = Bit
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
    return "ком†толкатель†лев†назад";}

// ком†толкатель†прав†вперЄд,   Bool, %M533.5   reg = M  width = Bit
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
    return "ком†толкатель†прав†вперЄд";}

// ком†толкатель†прав†назад,   Bool, %M533.6   reg = M  width = Bit
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
    return "ком†толкатель†прав†назад";}

// ком†дозатор†лев†назад,   Bool, %M533.0   reg = M  width = Bit
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
    return "ком†дозатор†лев†назад";}

// ком†дозатор†прав†назад,   Bool, %M533.1   reg = M  width = Bit
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
    return "ком†дозатор†прав†назад";}

// ком† Ё9,   Bool, %M533.4   reg = M  width = Bit
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
    return "ком† Ё9";}

// ком† Ё10,   Bool, %M533.7   reg = M  width = Bit
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
    return "ком† Ё10";}

// ком† ¬1,   Bool, %M534.0   reg = M  width = Bit
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
    return "ком† ¬1";}

// ком† ¬2,   Bool, %M534.1   reg = M  width = Bit
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
    return "ком† ¬2";}

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
};

//-----------------------------------------------------------------------------
//tags/usta.xml
//-----------------------------------------------------------------------------
// уст†стол†позици€,   Real, %MD136   reg = M  width = UInt32
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
    return "уст†стол†позици€";}

// уст†стол†скор†вверх,   Real, %MD108   reg = M  width = UInt32
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
    return "уст†стол†скор†вверх";}

// уст†стол†отн†расст,   Real, %MD148   reg = M  width = UInt32
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
    return "уст†стол†отн†расст";}

// уст†слой†кар†лев†начало,   Real, %MD132   reg = M  width = UInt32
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
    return "уст†слой†кар†лев†начало";}

// уст†слой†кар†лев†конец,   Real, %MD144   reg = M  width = UInt32
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
    return "уст†слой†кар†лев†конец";}

// уст†толщ†сло€,   Real, %MD180   reg = M  width = UInt32
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
    return "уст†толщ†сло€";}

// уст†стол†отн†расст†авто,   Real, %MD204   reg = M  width = UInt32
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
    return "уст†стол†отн†расст†авто";}

// уст†“ЁЌ1†мощн,   Real, %MD276   reg = M  width = UInt32
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
    return "уст†“ЁЌ1†мощн";}

// уст†“ЁЌ2†мощн,   Real, %MD280   reg = M  width = UInt32
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
    return "уст†“ЁЌ2†мощн";}

// уст†“ЁЌ3†мощн,   Real, %MD284   reg = M  width = UInt32
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
    return "уст†“ЁЌ3†мощн";}

// уст†кол†слоЄв†дл€†доз†прав,   Int, %MW292   reg = M  width = UInt16
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
    return "уст†кол†слоЄв†дл€†доз†прав";}

// уст†кол†слоЄв†дл€†доз†лев,   Int, %MW294   reg = M  width = UInt16
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
    return "уст†кол†слоЄв†дл€†доз†лев";}

// уст†“ЁЌ1†темп,   Real, %MD288   reg = M  width = UInt32
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
    return "уст†“ЁЌ1†темп";}

// уст†“ЁЌ2†темп,   Real, %MD296   reg = M  width = UInt32
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
    return "уст†“ЁЌ2†темп";}

// уст†“ЁЌ3†темп,   Real, %MD300   reg = M  width = UInt32
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
    return "уст†“ЁЌ3†темп";}

// уст†кар†лев†скор,   Real, %MD304   reg = M  width = UInt32
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
    return "уст†кар†лев†скор";}

// уст†кар†лев†раст,   Real, %MD308   reg = M  width = UInt32
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
    return "уст†кар†лев†раст";}

// уст†кар†лев†поз,   Real, %MD312   reg = M  width = UInt32
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
    return "уст†кар†лев†поз";}

// уст†кар†прав†скор,   Real, %MD316   reg = M  width = UInt32
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
    return "уст†кар†прав†скор";}

// уст†кар†прав†раст,   Real, %MD320   reg = M  width = UInt32
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
    return "уст†кар†прав†раст";}

// уст†кар†прав†поз,   Real, %MD324   reg = M  width = UInt32
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
    return "уст†кар†прав†поз";}

// уст†бар†прав†скор,   Real, %MD328   reg = M  width = UInt32
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
    return "уст†бар†прав†скор";}

// уст†бар†лев†скор,   Real, %MD340   reg = M  width = UInt32
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
    return "уст†бар†лев†скор";}

// уст†доз†лев†врем€,   Real, %MD352   reg = M  width = UInt32
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
    return "уст†доз†лев†врем€";}

// уст†доз†прав†врем€,   Real, %MD356   reg = M  width = UInt32
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
    return "уст†доз†прав†врем€";}

// уст†толк†лев†расст,   Real, %MD360   reg = M  width = UInt32
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
    return "уст†толк†лев†расст";}

// уст†толк†прав†расст,   Real, %MD364   reg = M  width = UInt32
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
    return "уст†толк†прав†расст";}

// уст†доз†прав†скор,   Real, %MD368   reg = M  width = UInt32
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
    return "уст†доз†прав†скор";}

// уст†доз†лев†скор,   Real, %MD372   reg = M  width = UInt32
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
    return "уст†доз†лев†скор";}

// уст†толк†лев†скор,   Real, %MD376   reg = M  width = UInt32
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
    return "уст†толк†лев†скор";}

// уст†толк†прав†скор,   Real, %MD380   reg = M  width = UInt32
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
    return "уст†толк†прав†скор";}

// уст†слой†кар†прав†начало,   Real, %MD152   reg = M  width = UInt32
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
    return "уст†слой†кар†прав†начало";}

// уст†слой†кар†прав†конец,   Real, %MD156   reg = M  width = UInt32
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
    return "уст†слой†кар†прав†конец";}

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

//-----------------------------------------------------------------------------
//tags/outd.xml
//-----------------------------------------------------------------------------
// выхд†стол†абс,   Bool, %M500.4   reg = M  width = Bit
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
    return "выхд†стол†абс";}

// выхд†“ЁЌ1,   Bool, %M503.2   reg = M  width = Bit
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
    return "выхд†“ЁЌ1";}

// выхд†“ЁЌ2,   Bool, %M503.3   reg = M  width = Bit
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
    return "выхд†“ЁЌ2";}

// выхд†“ЁЌ3,   Bool, %M503.4   reg = M  width = Bit
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
    return "выхд†“ЁЌ3";}

// выхд†стол†отн†вниз,   Bool, %M505.7   reg = M  width = Bit
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
    return "выхд†стол†отн†вниз";}

// выхд†стол†отн†вверх,   Bool, %M506.0   reg = M  width = Bit
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
    return "выхд†стол†отн†вверх";}

// выхд†стол†поиск†нул€,   Bool, %M506.4   reg = M  width = Bit
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
    return "выхд†стол†поиск†нул€";}

// выхд†пит†лазеров,   Bool, %M506.5   reg = M  width = Bit
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
    return "выхд†пит†лазеров";}

// выхд†пит†чил1,   Bool, %M506.6   reg = M  width = Bit
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
    return "выхд†пит†чил1";}

// выхд†пит†чил2,   Bool, %M506.7   reg = M  width = Bit
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
    return "выхд†пит†чил2";}

// выхд†кл†чил1,   Bool, %M507.0   reg = M  width = Bit
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
    return "выхд†кл†чил1";}

// выхд†кл†чил2,   Bool, %M507.1   reg = M  width = Bit
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
    return "выхд†кл†чил2";}

// выхд†пит†ћѕ—,   Bool, %M507.2   reg = M  width = Bit
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
    return "выхд†пит†ћѕ—";}

// выхд†пит†рец,   Bool, %M507.3   reg = M  width = Bit
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
    return "выхд†пит†рец";}

// выхд† ¬1,   Bool, %M507.4   reg = M  width = Bit
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
    return "выхд† ¬1";}

// выхд† ¬2,   Bool, %M507.5   reg = M  width = Bit
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
    return "выхд† ¬2";}

// выхд† Ё9,   Bool, %M507.6   reg = M  width = Bit
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
    return "выхд† Ё9";}

// выхд† Ё10,   Bool, %M507.7   reg = M  width = Bit
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
    return "выхд† Ё10";}

// выхд†кар†прав†абс,   Bool, %M508.0   reg = M  width = Bit
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
    return "выхд†кар†прав†абс";}

// выхд†кар†лев†абс,   Bool, %M508.1   reg = M  width = Bit
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
    return "выхд†кар†лев†абс";}

// выхд†доз†прав†впер,   Bool, %M508.2   reg = M  width = Bit
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
    return "выхд†доз†прав†впер";}

// выхд†доз†лев†впер,   Bool, %M508.3   reg = M  width = Bit
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
    return "выхд†доз†лев†впер";}

// выхд†доз†прав†назад,   Bool, %M508.4   reg = M  width = Bit
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
    return "выхд†доз†прав†назад";}

// выхд†доз†лев†назад,   Bool, %M508.5   reg = M  width = Bit
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
    return "выхд†доз†лев†назад";}

// выхд†пересчЄт,   Bool, %M2.3   reg = M  width = Bit
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
    return "выхд†пересчЄт";}

// выхд†бар†лев†впер,   Bool, %M508.6   reg = M  width = Bit
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
    return "выхд†бар†лев†впер";}

// выхд†бар†прав†впер,   Bool, %M508.7   reg = M  width = Bit
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
    return "выхд†бар†прав†впер";}

// выхд†бар†лев†назад,   Bool, %M509.0   reg = M  width = Bit
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
    return "выхд†бар†лев†назад";}

// выхд†бар†прав†назад,   Bool, %M509.1   reg = M  width = Bit
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
    return "выхд†бар†прав†назад";}

// выхд†толк†лев†впер,   Bool, %M509.2   reg = M  width = Bit
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
    return "выхд†толк†лев†впер";}

// выхд†толк†прав†впер,   Bool, %M509.3   reg = M  width = Bit
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
    return "выхд†толк†прав†впер";}

// выхд†толк†лев†назад,   Bool, %M509.4   reg = M  width = Bit
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
    return "выхд†толк†лев†назад";}

// выхд†толк†прав†назад,   Bool, %M509.5   reg = M  width = Bit
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
    return "выхд†толк†прав†назад";}

// выхд†кар†прав†отн†впер,   Bool, %M509.6   reg = M  width = Bit
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
    return "выхд†кар†прав†отн†впер";}

// выхд†кар†прав†отн†наз,   Bool, %M509.7   reg = M  width = Bit
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
    return "выхд†кар†прав†отн†наз";}

// выхд†кар†лев†отн†впер,   Bool, %M510.0   reg = M  width = Bit
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
    return "выхд†кар†лев†отн†впер";}

// выхд†кар†лев†отн†наз,   Bool, %M510.1   reg = M  width = Bit
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
    return "выхд†кар†лев†отн†наз";}

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
case "kom_rezerv":
   return gets_kom_rezerv();
case "kom_rezerv_1":
   return gets_kom_rezerv_1();
case "kom_rezerv_2":
   return gets_kom_rezerv_2();
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
case "kom_kar_lev_sh1_vperjod":
   return gets_kom_kar_lev_sh1_vperjod();
case "kom_kar_lev_sh1_nazad":
   return gets_kom_kar_lev_sh1_nazad();
case "kom_kar_lev_sh1_abs":
   return gets_kom_kar_lev_sh1_abs();
case "kom_kar_lev_sh1_stop":
   return gets_kom_kar_lev_sh1_stop();
case "kom_kar_prav_sh2_vperjod":
   return gets_kom_kar_prav_sh2_vperjod();
case "kom_kar_prav_sh2_nazad":
   return gets_kom_kar_prav_sh2_nazad();
case "kom_kar_prav_sh2_abs":
   return gets_kom_kar_prav_sh2_abs();
case "kom_kar_prav_sh2_stop":
   return gets_kom_kar_prav_sh2_stop();
case "kom_bar_prav_sh3_vperjod":
   return gets_kom_bar_prav_sh3_vperjod();
case "kom_bar_prav_sh3_nazad":
   return gets_kom_bar_prav_sh3_nazad();
case "kom_bar_prav_sh3_abs":
   return gets_kom_bar_prav_sh3_abs();
case "kom_bar_prav_sh3_stop":
   return gets_kom_bar_prav_sh3_stop();
case "kom_bar_lev_sh4_vperjod":
   return gets_kom_bar_lev_sh4_vperjod();
case "kom_bar_lev_sh4_nazad":
   return gets_kom_bar_lev_sh4_nazad();
case "kom_bar_lev_sh4_abs":
   return gets_kom_bar_lev_sh4_abs();
case "kom_bar_lev_sh4_stop":
   return gets_kom_bar_lev_sh4_stop();
case "kom_dozator_lev_vper":
   return gets_kom_dozator_lev_vper();
case "kom_dozator_prav_vper":
   return gets_kom_dozator_prav_vper();
case "kom_tolkatel_lev_vperjod":
   return gets_kom_tolkatel_lev_vperjod();
case "kom_tolkatel_lev_nazad":
   return gets_kom_tolkatel_lev_nazad();
case "kom_tolkatel_prav_vperjod":
   return gets_kom_tolkatel_prav_vperjod();
case "kom_tolkatel_prav_nazad":
   return gets_kom_tolkatel_prav_nazad();
case "kom_dozator_lev_nazad":
   return gets_kom_dozator_lev_nazad();
case "kom_dozator_prav_nazad":
   return gets_kom_dozator_prav_nazad();
case "kom_kje9":
   return gets_kom_kje9();
case "kom_kje10":
   return gets_kom_kje10();
case "kom_kv1":
   return gets_kom_kv1();
case "kom_kv2":
   return gets_kom_kv2();
case "ust_stol_poziciya":
   return gets_ust_stol_poziciya();
case "ust_stol_skor_vverh":
   return gets_ust_stol_skor_vverh();
case "ust_stol_otn_rasst":
   return gets_ust_stol_otn_rasst();
case "ust_sloj_kar_lev_nachalo":
   return gets_ust_sloj_kar_lev_nachalo();
case "ust_sloj_kar_lev_konec":
   return gets_ust_sloj_kar_lev_konec();
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
case "ust_kol_slojov_dlya_doz_prav":
   return gets_ust_kol_slojov_dlya_doz_prav();
case "ust_kol_slojov_dlya_doz_lev":
   return gets_ust_kol_slojov_dlya_doz_lev();
case "ust_tjen1_temp":
   return gets_ust_tjen1_temp();
case "ust_tjen2_temp":
   return gets_ust_tjen2_temp();
case "ust_tjen3_temp":
   return gets_ust_tjen3_temp();
case "ust_kar_lev_skor":
   return gets_ust_kar_lev_skor();
case "ust_kar_lev_rast":
   return gets_ust_kar_lev_rast();
case "ust_kar_lev_poz":
   return gets_ust_kar_lev_poz();
case "ust_kar_prav_skor":
   return gets_ust_kar_prav_skor();
case "ust_kar_prav_rast":
   return gets_ust_kar_prav_rast();
case "ust_kar_prav_poz":
   return gets_ust_kar_prav_poz();
case "ust_bar_prav_skor":
   return gets_ust_bar_prav_skor();
case "ust_bar_lev_skor":
   return gets_ust_bar_lev_skor();
case "ust_doz_lev_vremya":
   return gets_ust_doz_lev_vremya();
case "ust_doz_prav_vremya":
   return gets_ust_doz_prav_vremya();
case "ust_tolk_lev_rasst":
   return gets_ust_tolk_lev_rasst();
case "ust_tolk_prav_rasst":
   return gets_ust_tolk_prav_rasst();
case "ust_doz_prav_skor":
   return gets_ust_doz_prav_skor();
case "ust_doz_lev_skor":
   return gets_ust_doz_lev_skor();
case "ust_tolk_lev_skor":
   return gets_ust_tolk_lev_skor();
case "ust_tolk_prav_skor":
   return gets_ust_tolk_prav_skor();
case "ust_sloj_kar_prav_nachalo":
   return gets_ust_sloj_kar_prav_nachalo();
case "ust_sloj_kar_prav_konec":
   return gets_ust_sloj_kar_prav_konec();
case "vyhd_stol_abs":
   return gets_vyhd_stol_abs();
case "vyhd_tjen1":
   return gets_vyhd_tjen1();
case "vyhd_tjen2":
   return gets_vyhd_tjen2();
case "vyhd_tjen3":
   return gets_vyhd_tjen3();
case "vyhd_stol_otn_vniz":
   return gets_vyhd_stol_otn_vniz();
case "vyhd_stol_otn_vverh":
   return gets_vyhd_stol_otn_vverh();
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
case "vyhd_kv1":
   return gets_vyhd_kv1();
case "vyhd_kv2":
   return gets_vyhd_kv2();
case "vyhd_kje9":
   return gets_vyhd_kje9();
case "vyhd_kje10":
   return gets_vyhd_kje10();
case "vyhd_kar_prav_abs":
   return gets_vyhd_kar_prav_abs();
case "vyhd_kar_lev_abs":
   return gets_vyhd_kar_lev_abs();
case "vyhd_doz_prav_vper":
   return gets_vyhd_doz_prav_vper();
case "vyhd_doz_lev_vper":
   return gets_vyhd_doz_lev_vper();
case "vyhd_doz_prav_nazad":
   return gets_vyhd_doz_prav_nazad();
case "vyhd_doz_lev_nazad":
   return gets_vyhd_doz_lev_nazad();
case "vyhd_pereschjot":
   return gets_vyhd_pereschjot();
case "vyhd_bar_lev_vper":
   return gets_vyhd_bar_lev_vper();
case "vyhd_bar_prav_vper":
   return gets_vyhd_bar_prav_vper();
case "vyhd_bar_lev_nazad":
   return gets_vyhd_bar_lev_nazad();
case "vyhd_bar_prav_nazad":
   return gets_vyhd_bar_prav_nazad();
case "vyhd_tolk_lev_vper":
   return gets_vyhd_tolk_lev_vper();
case "vyhd_tolk_prav_vper":
   return gets_vyhd_tolk_prav_vper();
case "vyhd_tolk_lev_nazad":
   return gets_vyhd_tolk_lev_nazad();
case "vyhd_tolk_prav_nazad":
   return gets_vyhd_tolk_prav_nazad();
case "vyhd_kar_prav_otn_vper":
   return gets_vyhd_kar_prav_otn_vper();
case "vyhd_kar_prav_otn_naz":
   return gets_vyhd_kar_prav_otn_naz();
case "vyhd_kar_lev_otn_vper":
   return gets_vyhd_kar_lev_otn_vper();
case "vyhd_kar_lev_otn_naz":
   return gets_vyhd_kar_lev_otn_naz();
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
case "kom_rezerv":
   return sets_kom_rezerv(val);
case "kom_rezerv_1":
   return sets_kom_rezerv_1(val);
case "kom_rezerv_2":
   return sets_kom_rezerv_2(val);
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
case "kom_kar_lev_sh1_vperjod":
   return sets_kom_kar_lev_sh1_vperjod(val);
case "kom_kar_lev_sh1_nazad":
   return sets_kom_kar_lev_sh1_nazad(val);
case "kom_kar_lev_sh1_abs":
   return sets_kom_kar_lev_sh1_abs(val);
case "kom_kar_lev_sh1_stop":
   return sets_kom_kar_lev_sh1_stop(val);
case "kom_kar_prav_sh2_vperjod":
   return sets_kom_kar_prav_sh2_vperjod(val);
case "kom_kar_prav_sh2_nazad":
   return sets_kom_kar_prav_sh2_nazad(val);
case "kom_kar_prav_sh2_abs":
   return sets_kom_kar_prav_sh2_abs(val);
case "kom_kar_prav_sh2_stop":
   return sets_kom_kar_prav_sh2_stop(val);
case "kom_bar_prav_sh3_vperjod":
   return sets_kom_bar_prav_sh3_vperjod(val);
case "kom_bar_prav_sh3_nazad":
   return sets_kom_bar_prav_sh3_nazad(val);
case "kom_bar_prav_sh3_abs":
   return sets_kom_bar_prav_sh3_abs(val);
case "kom_bar_prav_sh3_stop":
   return sets_kom_bar_prav_sh3_stop(val);
case "kom_bar_lev_sh4_vperjod":
   return sets_kom_bar_lev_sh4_vperjod(val);
case "kom_bar_lev_sh4_nazad":
   return sets_kom_bar_lev_sh4_nazad(val);
case "kom_bar_lev_sh4_abs":
   return sets_kom_bar_lev_sh4_abs(val);
case "kom_bar_lev_sh4_stop":
   return sets_kom_bar_lev_sh4_stop(val);
case "kom_dozator_lev_vper":
   return sets_kom_dozator_lev_vper(val);
case "kom_dozator_prav_vper":
   return sets_kom_dozator_prav_vper(val);
case "kom_tolkatel_lev_vperjod":
   return sets_kom_tolkatel_lev_vperjod(val);
case "kom_tolkatel_lev_nazad":
   return sets_kom_tolkatel_lev_nazad(val);
case "kom_tolkatel_prav_vperjod":
   return sets_kom_tolkatel_prav_vperjod(val);
case "kom_tolkatel_prav_nazad":
   return sets_kom_tolkatel_prav_nazad(val);
case "kom_dozator_lev_nazad":
   return sets_kom_dozator_lev_nazad(val);
case "kom_dozator_prav_nazad":
   return sets_kom_dozator_prav_nazad(val);
case "kom_kje9":
   return sets_kom_kje9(val);
case "kom_kje10":
   return sets_kom_kje10(val);
case "kom_kv1":
   return sets_kom_kv1(val);
case "kom_kv2":
   return sets_kom_kv2(val);
case "ust_stol_poziciya":
   return sets_ust_stol_poziciya(val);
case "ust_stol_skor_vverh":
   return sets_ust_stol_skor_vverh(val);
case "ust_stol_otn_rasst":
   return sets_ust_stol_otn_rasst(val);
case "ust_sloj_kar_lev_nachalo":
   return sets_ust_sloj_kar_lev_nachalo(val);
case "ust_sloj_kar_lev_konec":
   return sets_ust_sloj_kar_lev_konec(val);
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
case "ust_kol_slojov_dlya_doz_prav":
   return sets_ust_kol_slojov_dlya_doz_prav(val);
case "ust_kol_slojov_dlya_doz_lev":
   return sets_ust_kol_slojov_dlya_doz_lev(val);
case "ust_tjen1_temp":
   return sets_ust_tjen1_temp(val);
case "ust_tjen2_temp":
   return sets_ust_tjen2_temp(val);
case "ust_tjen3_temp":
   return sets_ust_tjen3_temp(val);
case "ust_kar_lev_skor":
   return sets_ust_kar_lev_skor(val);
case "ust_kar_lev_rast":
   return sets_ust_kar_lev_rast(val);
case "ust_kar_lev_poz":
   return sets_ust_kar_lev_poz(val);
case "ust_kar_prav_skor":
   return sets_ust_kar_prav_skor(val);
case "ust_kar_prav_rast":
   return sets_ust_kar_prav_rast(val);
case "ust_kar_prav_poz":
   return sets_ust_kar_prav_poz(val);
case "ust_bar_prav_skor":
   return sets_ust_bar_prav_skor(val);
case "ust_bar_lev_skor":
   return sets_ust_bar_lev_skor(val);
case "ust_doz_lev_vremya":
   return sets_ust_doz_lev_vremya(val);
case "ust_doz_prav_vremya":
   return sets_ust_doz_prav_vremya(val);
case "ust_tolk_lev_rasst":
   return sets_ust_tolk_lev_rasst(val);
case "ust_tolk_prav_rasst":
   return sets_ust_tolk_prav_rasst(val);
case "ust_doz_prav_skor":
   return sets_ust_doz_prav_skor(val);
case "ust_doz_lev_skor":
   return sets_ust_doz_lev_skor(val);
case "ust_tolk_lev_skor":
   return sets_ust_tolk_lev_skor(val);
case "ust_tolk_prav_skor":
   return sets_ust_tolk_prav_skor(val);
case "ust_sloj_kar_prav_nachalo":
   return sets_ust_sloj_kar_prav_nachalo(val);
case "ust_sloj_kar_prav_konec":
   return sets_ust_sloj_kar_prav_konec(val);
case "vyhd_stol_abs":
   return sets_vyhd_stol_abs(val);
case "vyhd_tjen1":
   return sets_vyhd_tjen1(val);
case "vyhd_tjen2":
   return sets_vyhd_tjen2(val);
case "vyhd_tjen3":
   return sets_vyhd_tjen3(val);
case "vyhd_stol_otn_vniz":
   return sets_vyhd_stol_otn_vniz(val);
case "vyhd_stol_otn_vverh":
   return sets_vyhd_stol_otn_vverh(val);
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
case "vyhd_kv1":
   return sets_vyhd_kv1(val);
case "vyhd_kv2":
   return sets_vyhd_kv2(val);
case "vyhd_kje9":
   return sets_vyhd_kje9(val);
case "vyhd_kje10":
   return sets_vyhd_kje10(val);
case "vyhd_kar_prav_abs":
   return sets_vyhd_kar_prav_abs(val);
case "vyhd_kar_lev_abs":
   return sets_vyhd_kar_lev_abs(val);
case "vyhd_doz_prav_vper":
   return sets_vyhd_doz_prav_vper(val);
case "vyhd_doz_lev_vper":
   return sets_vyhd_doz_lev_vper(val);
case "vyhd_doz_prav_nazad":
   return sets_vyhd_doz_prav_nazad(val);
case "vyhd_doz_lev_nazad":
   return sets_vyhd_doz_lev_nazad(val);
case "vyhd_pereschjot":
   return sets_vyhd_pereschjot(val);
case "vyhd_bar_lev_vper":
   return sets_vyhd_bar_lev_vper(val);
case "vyhd_bar_prav_vper":
   return sets_vyhd_bar_prav_vper(val);
case "vyhd_bar_lev_nazad":
   return sets_vyhd_bar_lev_nazad(val);
case "vyhd_bar_prav_nazad":
   return sets_vyhd_bar_prav_nazad(val);
case "vyhd_tolk_lev_vper":
   return sets_vyhd_tolk_lev_vper(val);
case "vyhd_tolk_prav_vper":
   return sets_vyhd_tolk_prav_vper(val);
case "vyhd_tolk_lev_nazad":
   return sets_vyhd_tolk_lev_nazad(val);
case "vyhd_tolk_prav_nazad":
   return sets_vyhd_tolk_prav_nazad(val);
case "vyhd_kar_prav_otn_vper":
   return sets_vyhd_kar_prav_otn_vper(val);
case "vyhd_kar_prav_otn_naz":
   return sets_vyhd_kar_prav_otn_naz(val);
case "vyhd_kar_lev_otn_vper":
   return sets_vyhd_kar_lev_otn_vper(val);
case "vyhd_kar_lev_otn_naz":
   return sets_vyhd_kar_lev_otn_naz(val);
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
case "kom_rezerv":
   return debug_name_kom_rezerv();
case "kom_rezerv_1":
   return debug_name_kom_rezerv_1();
case "kom_rezerv_2":
   return debug_name_kom_rezerv_2();
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
case "kom_kar_lev_sh1_vperjod":
   return debug_name_kom_kar_lev_sh1_vperjod();
case "kom_kar_lev_sh1_nazad":
   return debug_name_kom_kar_lev_sh1_nazad();
case "kom_kar_lev_sh1_abs":
   return debug_name_kom_kar_lev_sh1_abs();
case "kom_kar_lev_sh1_stop":
   return debug_name_kom_kar_lev_sh1_stop();
case "kom_kar_prav_sh2_vperjod":
   return debug_name_kom_kar_prav_sh2_vperjod();
case "kom_kar_prav_sh2_nazad":
   return debug_name_kom_kar_prav_sh2_nazad();
case "kom_kar_prav_sh2_abs":
   return debug_name_kom_kar_prav_sh2_abs();
case "kom_kar_prav_sh2_stop":
   return debug_name_kom_kar_prav_sh2_stop();
case "kom_bar_prav_sh3_vperjod":
   return debug_name_kom_bar_prav_sh3_vperjod();
case "kom_bar_prav_sh3_nazad":
   return debug_name_kom_bar_prav_sh3_nazad();
case "kom_bar_prav_sh3_abs":
   return debug_name_kom_bar_prav_sh3_abs();
case "kom_bar_prav_sh3_stop":
   return debug_name_kom_bar_prav_sh3_stop();
case "kom_bar_lev_sh4_vperjod":
   return debug_name_kom_bar_lev_sh4_vperjod();
case "kom_bar_lev_sh4_nazad":
   return debug_name_kom_bar_lev_sh4_nazad();
case "kom_bar_lev_sh4_abs":
   return debug_name_kom_bar_lev_sh4_abs();
case "kom_bar_lev_sh4_stop":
   return debug_name_kom_bar_lev_sh4_stop();
case "kom_dozator_lev_vper":
   return debug_name_kom_dozator_lev_vper();
case "kom_dozator_prav_vper":
   return debug_name_kom_dozator_prav_vper();
case "kom_tolkatel_lev_vperjod":
   return debug_name_kom_tolkatel_lev_vperjod();
case "kom_tolkatel_lev_nazad":
   return debug_name_kom_tolkatel_lev_nazad();
case "kom_tolkatel_prav_vperjod":
   return debug_name_kom_tolkatel_prav_vperjod();
case "kom_tolkatel_prav_nazad":
   return debug_name_kom_tolkatel_prav_nazad();
case "kom_dozator_lev_nazad":
   return debug_name_kom_dozator_lev_nazad();
case "kom_dozator_prav_nazad":
   return debug_name_kom_dozator_prav_nazad();
case "kom_kje9":
   return debug_name_kom_kje9();
case "kom_kje10":
   return debug_name_kom_kje10();
case "kom_kv1":
   return debug_name_kom_kv1();
case "kom_kv2":
   return debug_name_kom_kv2();
case "ust_stol_poziciya":
   return debug_name_ust_stol_poziciya();
case "ust_stol_skor_vverh":
   return debug_name_ust_stol_skor_vverh();
case "ust_stol_otn_rasst":
   return debug_name_ust_stol_otn_rasst();
case "ust_sloj_kar_lev_nachalo":
   return debug_name_ust_sloj_kar_lev_nachalo();
case "ust_sloj_kar_lev_konec":
   return debug_name_ust_sloj_kar_lev_konec();
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
case "ust_kol_slojov_dlya_doz_prav":
   return debug_name_ust_kol_slojov_dlya_doz_prav();
case "ust_kol_slojov_dlya_doz_lev":
   return debug_name_ust_kol_slojov_dlya_doz_lev();
case "ust_tjen1_temp":
   return debug_name_ust_tjen1_temp();
case "ust_tjen2_temp":
   return debug_name_ust_tjen2_temp();
case "ust_tjen3_temp":
   return debug_name_ust_tjen3_temp();
case "ust_kar_lev_skor":
   return debug_name_ust_kar_lev_skor();
case "ust_kar_lev_rast":
   return debug_name_ust_kar_lev_rast();
case "ust_kar_lev_poz":
   return debug_name_ust_kar_lev_poz();
case "ust_kar_prav_skor":
   return debug_name_ust_kar_prav_skor();
case "ust_kar_prav_rast":
   return debug_name_ust_kar_prav_rast();
case "ust_kar_prav_poz":
   return debug_name_ust_kar_prav_poz();
case "ust_bar_prav_skor":
   return debug_name_ust_bar_prav_skor();
case "ust_bar_lev_skor":
   return debug_name_ust_bar_lev_skor();
case "ust_doz_lev_vremya":
   return debug_name_ust_doz_lev_vremya();
case "ust_doz_prav_vremya":
   return debug_name_ust_doz_prav_vremya();
case "ust_tolk_lev_rasst":
   return debug_name_ust_tolk_lev_rasst();
case "ust_tolk_prav_rasst":
   return debug_name_ust_tolk_prav_rasst();
case "ust_doz_prav_skor":
   return debug_name_ust_doz_prav_skor();
case "ust_doz_lev_skor":
   return debug_name_ust_doz_lev_skor();
case "ust_tolk_lev_skor":
   return debug_name_ust_tolk_lev_skor();
case "ust_tolk_prav_skor":
   return debug_name_ust_tolk_prav_skor();
case "ust_sloj_kar_prav_nachalo":
   return debug_name_ust_sloj_kar_prav_nachalo();
case "ust_sloj_kar_prav_konec":
   return debug_name_ust_sloj_kar_prav_konec();
case "vyhd_stol_abs":
   return debug_name_vyhd_stol_abs();
case "vyhd_tjen1":
   return debug_name_vyhd_tjen1();
case "vyhd_tjen2":
   return debug_name_vyhd_tjen2();
case "vyhd_tjen3":
   return debug_name_vyhd_tjen3();
case "vyhd_stol_otn_vniz":
   return debug_name_vyhd_stol_otn_vniz();
case "vyhd_stol_otn_vverh":
   return debug_name_vyhd_stol_otn_vverh();
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
case "vyhd_kv1":
   return debug_name_vyhd_kv1();
case "vyhd_kv2":
   return debug_name_vyhd_kv2();
case "vyhd_kje9":
   return debug_name_vyhd_kje9();
case "vyhd_kje10":
   return debug_name_vyhd_kje10();
case "vyhd_kar_prav_abs":
   return debug_name_vyhd_kar_prav_abs();
case "vyhd_kar_lev_abs":
   return debug_name_vyhd_kar_lev_abs();
case "vyhd_doz_prav_vper":
   return debug_name_vyhd_doz_prav_vper();
case "vyhd_doz_lev_vper":
   return debug_name_vyhd_doz_lev_vper();
case "vyhd_doz_prav_nazad":
   return debug_name_vyhd_doz_prav_nazad();
case "vyhd_doz_lev_nazad":
   return debug_name_vyhd_doz_lev_nazad();
case "vyhd_pereschjot":
   return debug_name_vyhd_pereschjot();
case "vyhd_bar_lev_vper":
   return debug_name_vyhd_bar_lev_vper();
case "vyhd_bar_prav_vper":
   return debug_name_vyhd_bar_prav_vper();
case "vyhd_bar_lev_nazad":
   return debug_name_vyhd_bar_lev_nazad();
case "vyhd_bar_prav_nazad":
   return debug_name_vyhd_bar_prav_nazad();
case "vyhd_tolk_lev_vper":
   return debug_name_vyhd_tolk_lev_vper();
case "vyhd_tolk_prav_vper":
   return debug_name_vyhd_tolk_prav_vper();
case "vyhd_tolk_lev_nazad":
   return debug_name_vyhd_tolk_lev_nazad();
case "vyhd_tolk_prav_nazad":
   return debug_name_vyhd_tolk_prav_nazad();
case "vyhd_kar_prav_otn_vper":
   return debug_name_vyhd_kar_prav_otn_vper();
case "vyhd_kar_prav_otn_naz":
   return debug_name_vyhd_kar_prav_otn_naz();
case "vyhd_kar_lev_otn_vper":
   return debug_name_vyhd_kar_lev_otn_vper();
case "vyhd_kar_lev_otn_naz":
   return debug_name_vyhd_kar_lev_otn_naz();
default: 
   return "NAN";
} 
 }
    }
 }
//__+_________________________________________________________________________________________________
//________++++____________________++++++++____++++++++++++++++____________________++++________________
//____++++____________________________________________________________________++++++++++++++++++++++++
//++++++++++++++++++++++++++++++++________++++________++++++++++++++++++++++++++++++++________________
//____________________________________________________________________________________________________
//+__+_++++++_______+++++_+++++++++++_________________________________________________________________
//____++++++++++++++++++++++++______________++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//++________________________________++++++++______++++____++++++++++++++++++__________________________
//____________________________________________________________________________________________________
//____________________________________________________________________________________________________
