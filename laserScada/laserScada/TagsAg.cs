using System;
using log4netSample.Logging;
using System.Collections.Generic;
 namespace laserScada {

partial class Tags {
//-----------------------------------------------------------------------------
//tags/am.xml
//-----------------------------------------------------------------------------
// АМ_термопара1 ( Температура1/Нагреватели),   Real, %MD604   reg = M  width = UInt32
    public float get_am_termopara1 ()
    { return (float) m_mem.getMFloat(604); }

    public void set_am_termopara1 (float val)
    { m_mem.setMFloat(604, (float) val); 
      Log.Write(LogLevel.Info, "set am_termopara1 to " + val.ToString());}

    public bool sets_am_termopara1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_termopara1 (val);
    return true;}

    public string gets_am_termopara1 () { 
    return get_am_termopara1().ToString();}

    public string debug_name_am_termopara1 () { 
    return "АМ_термопара1";}

// АМ_диф датч расх ( Диф датчик расхода/Рецеркуляция),   Real, %MD616   reg = M  width = UInt32
    public float get_am_dif_datch_rash ()
    { return (float) m_mem.getMFloat(616); }

    public void set_am_dif_datch_rash (float val)
    { m_mem.setMFloat(616, (float) val); 
      Log.Write(LogLevel.Info, "set am_dif_datch_rash to " + val.ToString());}

    public bool sets_am_dif_datch_rash ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dif_datch_rash (val);
    return true;}

    public string gets_am_dif_datch_rash () { 
    return get_am_dif_datch_rash().ToString();}

    public string debug_name_am_dif_datch_rash () { 
    return "АМ_диф датч расх";}

// АМ_давл лев фильтр ( Давление левый фильтр/Рецеркуляция),   Real, %MD620   reg = M  width = UInt32
    public float get_am_dawl_lew_fil_tr ()
    { return (float) m_mem.getMFloat(620); }

    public void set_am_dawl_lew_fil_tr (float val)
    { m_mem.setMFloat(620, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_lew_fil_tr to " + val.ToString());}

    public bool sets_am_dawl_lew_fil_tr ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_lew_fil_tr (val);
    return true;}

    public string gets_am_dawl_lew_fil_tr () { 
    return get_am_dawl_lew_fil_tr().ToString();}

    public string debug_name_am_dawl_lew_fil_tr () { 
    return "АМ_давл лев фильтр";}

// АМ_давл прав фильтр ( Давление правый фильтр/Рецеркуляция),   Real, %MD624   reg = M  width = UInt32
    public float get_am_dawl_praw_fil_tr ()
    { return (float) m_mem.getMFloat(624); }

    public void set_am_dawl_praw_fil_tr (float val)
    { m_mem.setMFloat(624, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_praw_fil_tr to " + val.ToString());}

    public bool sets_am_dawl_praw_fil_tr ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_praw_fil_tr (val);
    return true;}

    public string gets_am_dawl_praw_fil_tr () { 
    return get_am_dawl_praw_fil_tr().ToString();}

    public string debug_name_am_dawl_praw_fil_tr () { 
    return "АМ_давл прав фильтр";}

// АМ_линейка ( Линейка/Стол),   Real, %MD642   reg = M  width = UInt32
    public float get_am_linejka ()
    { return (float) m_mem.getMFloat(642); }

    public void set_am_linejka (float val)
    { m_mem.setMFloat(642, (float) val); 
      Log.Write(LogLevel.Info, "set am_linejka to " + val.ToString());}

    public bool sets_am_linejka ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_linejka (val);
    return true;}

    public string gets_am_linejka () { 
    return get_am_linejka().ToString();}

    public string debug_name_am_linejka () { 
    return "АМ_линейка";}

// АМ_ТЭН1 тек мощн ( ТЭН1текущая мощность/Нагреватели),   Real, %MD650   reg = M  width = UInt32
    public float get_am_tjen1_tek_moschn ()
    { return (float) m_mem.getMFloat(650); }

    public void set_am_tjen1_tek_moschn (float val)
    { m_mem.setMFloat(650, (float) val); 
      Log.Write(LogLevel.Info, "set am_tjen1_tek_moschn to " + val.ToString());}

    public bool sets_am_tjen1_tek_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_tjen1_tek_moschn (val);
    return true;}

    public string gets_am_tjen1_tek_moschn () { 
    return get_am_tjen1_tek_moschn().ToString();}

    public string debug_name_am_tjen1_tek_moschn () { 
    return "АМ_ТЭН1 тек мощн";}

// АМ_кар лев тек поз ( Каретка левая тек позиция/Каретки),   Real, %MD734   reg = M  width = UInt32
    public float get_am_kar_lew_tek_poz ()
    { return (float) m_mem.getMFloat(734); }

    public void set_am_kar_lew_tek_poz (float val)
    { m_mem.setMFloat(734, (float) val); 
      Log.Write(LogLevel.Info, "set am_kar_lew_tek_poz to " + val.ToString());}

    public bool sets_am_kar_lew_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_kar_lew_tek_poz (val);
    return true;}

    public string gets_am_kar_lew_tek_poz () { 
    return get_am_kar_lew_tek_poz().ToString();}

    public string debug_name_am_kar_lew_tek_poz () { 
    return "АМ_кар лев тек поз";}

// АМ_стол тек поз ( тек позиция/Стол),   Real, %MD738   reg = M  width = UInt32
    public float get_am_stol_tek_poz ()
    { return (float) m_mem.getMFloat(738); }

    public void set_am_stol_tek_poz (float val)
    { m_mem.setMFloat(738, (float) val); 
      Log.Write(LogLevel.Info, "set am_stol_tek_poz to " + val.ToString());}

    public bool sets_am_stol_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_stol_tek_poz (val);
    return true;}

    public string gets_am_stol_tek_poz () { 
    return get_am_stol_tek_poz().ToString();}

    public string debug_name_am_stol_tek_poz () { 
    return "АМ_стол тек поз";}

// АМ_темп1 ( Температура1/Чиллеры),   Real, %MD654   reg = M  width = UInt32
    public float get_am_temp1 ()
    { return (float) m_mem.getMFloat(654); }

    public void set_am_temp1 (float val)
    { m_mem.setMFloat(654, (float) val); 
      Log.Write(LogLevel.Info, "set am_temp1 to " + val.ToString());}

    public bool sets_am_temp1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_temp1 (val);
    return true;}

    public string gets_am_temp1 () { 
    return get_am_temp1().ToString();}

    public string debug_name_am_temp1 () { 
    return "АМ_темп1";}

// АМ_темп2 ( Температура2/Чиллеры),   Real, %MD658   reg = M  width = UInt32
    public float get_am_temp2 ()
    { return (float) m_mem.getMFloat(658); }

    public void set_am_temp2 (float val)
    { m_mem.setMFloat(658, (float) val); 
      Log.Write(LogLevel.Info, "set am_temp2 to " + val.ToString());}

    public bool sets_am_temp2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_temp2 (val);
    return true;}

    public string gets_am_temp2 () { 
    return get_am_temp2().ToString();}

    public string debug_name_am_temp2 () { 
    return "АМ_темп2";}

// АМ_темп3 ( Температура3/Чиллеры),   Real, %MD662   reg = M  width = UInt32
    public float get_am_temp3 ()
    { return (float) m_mem.getMFloat(662); }

    public void set_am_temp3 (float val)
    { m_mem.setMFloat(662, (float) val); 
      Log.Write(LogLevel.Info, "set am_temp3 to " + val.ToString());}

    public bool sets_am_temp3 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_temp3 (val);
    return true;}

    public string gets_am_temp3 () { 
    return get_am_temp3().ToString();}

    public string debug_name_am_temp3 () { 
    return "АМ_темп3";}

// АМ_темп4 ( Температура4/Чиллеры),   Real, %MD666   reg = M  width = UInt32
    public float get_am_temp4 ()
    { return (float) m_mem.getMFloat(666); }

    public void set_am_temp4 (float val)
    { m_mem.setMFloat(666, (float) val); 
      Log.Write(LogLevel.Info, "set am_temp4 to " + val.ToString());}

    public bool sets_am_temp4 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_temp4 (val);
    return true;}

    public string gets_am_temp4 () { 
    return get_am_temp4().ToString();}

    public string debug_name_am_temp4 () { 
    return "АМ_темп4";}

// АМ_темп5 ( Температура5/Чиллеры),   Real, %MD670   reg = M  width = UInt32
    public float get_am_temp5 ()
    { return (float) m_mem.getMFloat(670); }

    public void set_am_temp5 (float val)
    { m_mem.setMFloat(670, (float) val); 
      Log.Write(LogLevel.Info, "set am_temp5 to " + val.ToString());}

    public bool sets_am_temp5 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_temp5 (val);
    return true;}

    public string gets_am_temp5 () { 
    return get_am_temp5().ToString();}

    public string debug_name_am_temp5 () { 
    return "АМ_темп5";}

// АМ_темп6 ( Температура6/Чиллеры),   Real, %MD674   reg = M  width = UInt32
    public float get_am_temp6 ()
    { return (float) m_mem.getMFloat(674); }

    public void set_am_temp6 (float val)
    { m_mem.setMFloat(674, (float) val); 
      Log.Write(LogLevel.Info, "set am_temp6 to " + val.ToString());}

    public bool sets_am_temp6 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_temp6 (val);
    return true;}

    public string gets_am_temp6 () { 
    return get_am_temp6().ToString();}

    public string debug_name_am_temp6 () { 
    return "АМ_темп6";}

// АМ_датч кисл1 ( Кислород1/Рецеркуляция),   Real, %MD628   reg = M  width = UInt32
    public float get_am_datch_kisl1 ()
    { return (float) m_mem.getMFloat(628); }

    public void set_am_datch_kisl1 (float val)
    { m_mem.setMFloat(628, (float) val); 
      Log.Write(LogLevel.Info, "set am_datch_kisl1 to " + val.ToString());}

    public bool sets_am_datch_kisl1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_datch_kisl1 (val);
    return true;}

    public string gets_am_datch_kisl1 () { 
    return get_am_datch_kisl1().ToString();}

    public string debug_name_am_datch_kisl1 () { 
    return "АМ_датч кисл1";}

// АМ_датч кисл2 ( Кмслород2/Рецеркуляция),   Real, %MD632   reg = M  width = UInt32
    public float get_am_datch_kisl2 ()
    { return (float) m_mem.getMFloat(632); }

    public void set_am_datch_kisl2 (float val)
    { m_mem.setMFloat(632, (float) val); 
      Log.Write(LogLevel.Info, "set am_datch_kisl2 to " + val.ToString());}

    public bool sets_am_datch_kisl2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_datch_kisl2 (val);
    return true;}

    public string gets_am_datch_kisl2 () { 
    return get_am_datch_kisl2().ToString();}

    public string debug_name_am_datch_kisl2 () { 
    return "АМ_датч кисл2";}

// АМ_кар прав тек поз ( Каретка правая тек позиция/Каретки),   Real, %MD742   reg = M  width = UInt32
    public float get_am_kar_praw_tek_poz ()
    { return (float) m_mem.getMFloat(742); }

    public void set_am_kar_praw_tek_poz (float val)
    { m_mem.setMFloat(742, (float) val); 
      Log.Write(LogLevel.Info, "set am_kar_praw_tek_poz to " + val.ToString());}

    public bool sets_am_kar_praw_tek_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_kar_praw_tek_poz (val);
    return true;}

    public string gets_am_kar_praw_tek_poz () { 
    return get_am_kar_praw_tek_poz().ToString();}

    public string debug_name_am_kar_praw_tek_poz () { 
    return "АМ_кар прав тек поз";}

// АМ_давл в камере ( Давление в камере/Рецеркуляция),   Real, %MD636   reg = M  width = UInt32
    public float get_am_dawl_w_kamere ()
    { return (float) m_mem.getMFloat(636); }

    public void set_am_dawl_w_kamere (float val)
    { m_mem.setMFloat(636, (float) val); 
      Log.Write(LogLevel.Info, "set am_dawl_w_kamere to " + val.ToString());}

    public bool sets_am_dawl_w_kamere ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_dawl_w_kamere (val);
    return true;}

    public string gets_am_dawl_w_kamere () { 
    return get_am_dawl_w_kamere().ToString();}

    public string debug_name_am_dawl_w_kamere () { 
    return "АМ_давл в камере";}

// АМ_охл скан1 ( Расход возд скан1/Лазеры),   Real, %MD646   reg = M  width = UInt32
    public float get_am_ohl_skan1 ()
    { return (float) m_mem.getMFloat(646); }

    public void set_am_ohl_skan1 (float val)
    { m_mem.setMFloat(646, (float) val); 
      Log.Write(LogLevel.Info, "set am_ohl_skan1 to " + val.ToString());}

    public bool sets_am_ohl_skan1 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_ohl_skan1 (val);
    return true;}

    public string gets_am_ohl_skan1 () { 
    return get_am_ohl_skan1().ToString();}

    public string debug_name_am_ohl_skan1 () { 
    return "АМ_охл скан1";}

// АМ_охл скан2 ( Расход возд скан2/Лазеры),   Real, %MD678   reg = M  width = UInt32
    public float get_am_ohl_skan2 ()
    { return (float) m_mem.getMFloat(678); }

    public void set_am_ohl_skan2 (float val)
    { m_mem.setMFloat(678, (float) val); 
      Log.Write(LogLevel.Info, "set am_ohl_skan2 to " + val.ToString());}

    public bool sets_am_ohl_skan2 ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_am_ohl_skan2 (val);
    return true;}

    public string gets_am_ohl_skan2 () { 
    return get_am_ohl_skan2().ToString();}

    public string debug_name_am_ohl_skan2 () { 
    return "АМ_охл скан2";}

public enum local_am{
am_termopara1,
am_dif_datch_rash,
am_dawl_lew_fil_tr,
am_dawl_praw_fil_tr,
am_linejka,
am_tjen1_tek_moschn,
am_kar_lew_tek_poz,
am_stol_tek_poz,
am_temp1,
am_temp2,
am_temp3,
am_temp4,
am_temp5,
am_temp6,
am_datch_kisl1,
am_datch_kisl2,
am_kar_praw_tek_poz,
am_dawl_w_kamere,
am_ohl_skan1,
am_ohl_skan2,
};

public gTags[] group_am = {
gTags.am_termopara1,
gTags.am_dif_datch_rash,
gTags.am_dawl_lew_fil_tr,
gTags.am_dawl_praw_fil_tr,
gTags.am_linejka,
gTags.am_tjen1_tek_moschn,
gTags.am_kar_lew_tek_poz,
gTags.am_stol_tek_poz,
gTags.am_temp1,
gTags.am_temp2,
gTags.am_temp3,
gTags.am_temp4,
gTags.am_temp5,
gTags.am_temp6,
gTags.am_datch_kisl1,
gTags.am_datch_kisl2,
gTags.am_kar_praw_tek_poz,
gTags.am_dawl_w_kamere,
gTags.am_ohl_skan1,
gTags.am_ohl_skan2,
};

//-----------------------------------------------------------------------------
//tags/outD.xml
//-----------------------------------------------------------------------------
// выхд_стол_абс ( Позиция/Стол),   Bool, %M500.4   reg = M  width = Bit
    public bool get_wyhd_stol_abs ()
    { return (bool) m_mem.getMBit(500, 4); }

    public void set_wyhd_stol_abs (bool val)
    { m_mem.setMBit(500, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_abs to " + val.ToString());}

    public bool sets_wyhd_stol_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_abs (val);
    return true;}

    public string gets_wyhd_stol_abs () { 
    return get_wyhd_stol_abs().ToString();}

    public string debug_name_wyhd_stol_abs () { 
    return "выхд_стол_абс";}

// выхд_ТЭН1_пит ( ТЭН1/Нагреватели),   Bool, %M503.2   reg = M  width = Bit
    public bool get_wyhd_tjen1_pit ()
    { return (bool) m_mem.getMBit(503, 2); }

    public void set_wyhd_tjen1_pit (bool val)
    { m_mem.setMBit(503, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tjen1_pit to " + val.ToString());}

    public bool sets_wyhd_tjen1_pit ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tjen1_pit (val);
    return true;}

    public string gets_wyhd_tjen1_pit () { 
    return get_wyhd_tjen1_pit().ToString();}

    public string debug_name_wyhd_tjen1_pit () { 
    return "выхд_ТЭН1_пит";}

// выхд_ТЭН2_пит ( ТЭН2/Нагреватели),   Bool, %M503.3   reg = M  width = Bit
    public bool get_wyhd_tjen2_pit ()
    { return (bool) m_mem.getMBit(503, 3); }

    public void set_wyhd_tjen2_pit (bool val)
    { m_mem.setMBit(503, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tjen2_pit to " + val.ToString());}

    public bool sets_wyhd_tjen2_pit ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tjen2_pit (val);
    return true;}

    public string gets_wyhd_tjen2_pit () { 
    return get_wyhd_tjen2_pit().ToString();}

    public string debug_name_wyhd_tjen2_pit () { 
    return "выхд_ТЭН2_пит";}

// выхд_ТЭН3_пит ( ТЭН3/Нагреватели),   Bool, %M503.4   reg = M  width = Bit
    public bool get_wyhd_tjen3_pit ()
    { return (bool) m_mem.getMBit(503, 4); }

    public void set_wyhd_tjen3_pit (bool val)
    { m_mem.setMBit(503, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tjen3_pit to " + val.ToString());}

    public bool sets_wyhd_tjen3_pit ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tjen3_pit (val);
    return true;}

    public string gets_wyhd_tjen3_pit () { 
    return get_wyhd_tjen3_pit().ToString();}

    public string debug_name_wyhd_tjen3_pit () { 
    return "выхд_ТЭН3_пит";}

// выхд_стол_отн_вниз ( Вниз/Стол),   Bool, %M505.7   reg = M  width = Bit
    public bool get_wyhd_stol_otn_wniz ()
    { return (bool) m_mem.getMBit(505, 7); }

    public void set_wyhd_stol_otn_wniz (bool val)
    { m_mem.setMBit(505, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_otn_wniz to " + val.ToString());}

    public bool sets_wyhd_stol_otn_wniz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_otn_wniz (val);
    return true;}

    public string gets_wyhd_stol_otn_wniz () { 
    return get_wyhd_stol_otn_wniz().ToString();}

    public string debug_name_wyhd_stol_otn_wniz () { 
    return "выхд_стол_отн_вниз";}

// выхд_стол_отн_вверх ( Вверх/Стол),   Bool, %M506.0   reg = M  width = Bit
    public bool get_wyhd_stol_otn_wwerh ()
    { return (bool) m_mem.getMBit(506, 0); }

    public void set_wyhd_stol_otn_wwerh (bool val)
    { m_mem.setMBit(506, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_otn_wwerh to " + val.ToString());}

    public bool sets_wyhd_stol_otn_wwerh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_otn_wwerh (val);
    return true;}

    public string gets_wyhd_stol_otn_wwerh () { 
    return get_wyhd_stol_otn_wwerh().ToString();}

    public string debug_name_wyhd_stol_otn_wwerh () { 
    return "выхд_стол_отн_вверх";}

// выхд_лаз_пит1 ( Питание лазера1/Лазеры),   Bool, %M506.5   reg = M  width = Bit
    public bool get_wyhd_laz_pit1 ()
    { return (bool) m_mem.getMBit(506, 5); }

    public void set_wyhd_laz_pit1 (bool val)
    { m_mem.setMBit(506, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_laz_pit1 to " + val.ToString());}

    public bool sets_wyhd_laz_pit1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_laz_pit1 (val);
    return true;}

    public string gets_wyhd_laz_pit1 () { 
    return get_wyhd_laz_pit1().ToString();}

    public string debug_name_wyhd_laz_pit1 () { 
    return "выхд_лаз_пит1";}

// выхд_питЧил1 ( Питание чиллера1/Чиллеры),   Bool, %M506.6   reg = M  width = Bit
    public bool get_wyhd_pitchil1 ()
    { return (bool) m_mem.getMBit(506, 6); }

    public void set_wyhd_pitchil1 (bool val)
    { m_mem.setMBit(506, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitchil1 to " + val.ToString());}

    public bool sets_wyhd_pitchil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitchil1 (val);
    return true;}

    public string gets_wyhd_pitchil1 () { 
    return get_wyhd_pitchil1().ToString();}

    public string debug_name_wyhd_pitchil1 () { 
    return "выхд_питЧил1";}

// выхд_питЧил2 ( Питание чиллера2/Чиллеры),   Bool, %M506.7   reg = M  width = Bit
    public bool get_wyhd_pitchil2 ()
    { return (bool) m_mem.getMBit(506, 7); }

    public void set_wyhd_pitchil2 (bool val)
    { m_mem.setMBit(506, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitchil2 to " + val.ToString());}

    public bool sets_wyhd_pitchil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitchil2 (val);
    return true;}

    public string gets_wyhd_pitchil2 () { 
    return get_wyhd_pitchil2().ToString();}

    public string debug_name_wyhd_pitchil2 () { 
    return "выхд_питЧил2";}

// выхд_клЧил1 ( Клапаны чиллера1/Чиллеры),   Bool, %M507.0   reg = M  width = Bit
    public bool get_wyhd_klchil1 ()
    { return (bool) m_mem.getMBit(507, 0); }

    public void set_wyhd_klchil1 (bool val)
    { m_mem.setMBit(507, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klchil1 to " + val.ToString());}

    public bool sets_wyhd_klchil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klchil1 (val);
    return true;}

    public string gets_wyhd_klchil1 () { 
    return get_wyhd_klchil1().ToString();}

    public string debug_name_wyhd_klchil1 () { 
    return "выхд_клЧил1";}

// выхд_клЧил2 ( Клапаны чиллера2/Чиллеры),   Bool, %M507.1   reg = M  width = Bit
    public bool get_wyhd_klchil2 ()
    { return (bool) m_mem.getMBit(507, 1); }

    public void set_wyhd_klchil2 (bool val)
    { m_mem.setMBit(507, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klchil2 to " + val.ToString());}

    public bool sets_wyhd_klchil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klchil2 (val);
    return true;}

    public string gets_wyhd_klchil2 () { 
    return get_wyhd_klchil2().ToString();}

    public string debug_name_wyhd_klchil2 () { 
    return "выхд_клЧил2";}

// выхд_питМПС ( Питание МПС/Каретки),   Bool, %M507.2   reg = M  width = Bit
    public bool get_wyhd_pitmps ()
    { return (bool) m_mem.getMBit(507, 2); }

    public void set_wyhd_pitmps (bool val)
    { m_mem.setMBit(507, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitmps to " + val.ToString());}

    public bool sets_wyhd_pitmps ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitmps (val);
    return true;}

    public string gets_wyhd_pitmps () { 
    return get_wyhd_pitmps().ToString();}

    public string debug_name_wyhd_pitmps () { 
    return "выхд_питМПС";}

// выхд_питРец ( Насос - улитка/Рецеркуляция),   Bool, %M507.3   reg = M  width = Bit
    public bool get_wyhd_pitrec ()
    { return (bool) m_mem.getMBit(507, 3); }

    public void set_wyhd_pitrec (bool val)
    { m_mem.setMBit(507, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_pitrec to " + val.ToString());}

    public bool sets_wyhd_pitrec ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_pitrec (val);
    return true;}

    public string gets_wyhd_pitrec () { 
    return get_wyhd_pitrec().ToString();}

    public string debug_name_wyhd_pitrec () { 
    return "выхд_питРец";}

// выхд_КВ1 ( КВ1/Рецеркуляция),   Bool, %M507.4   reg = M  width = Bit
    public bool get_wyhd_kv1 ()
    { return (bool) m_mem.getMBit(507, 4); }

    public void set_wyhd_kv1 (bool val)
    { m_mem.setMBit(507, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kv1 to " + val.ToString());}

    public bool sets_wyhd_kv1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kv1 (val);
    return true;}

    public string gets_wyhd_kv1 () { 
    return get_wyhd_kv1().ToString();}

    public string debug_name_wyhd_kv1 () { 
    return "выхд_КВ1";}

// выхд_КВ2 ( КВ2/Рецеркуляция),   Bool, %M507.5   reg = M  width = Bit
    public bool get_wyhd_kv2 ()
    { return (bool) m_mem.getMBit(507, 5); }

    public void set_wyhd_kv2 (bool val)
    { m_mem.setMBit(507, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kv2 to " + val.ToString());}

    public bool sets_wyhd_kv2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kv2 (val);
    return true;}

    public string gets_wyhd_kv2 () { 
    return get_wyhd_kv2().ToString();}

    public string debug_name_wyhd_kv2 () { 
    return "выхд_КВ2";}

// выхд_КЭ9 ( КЭ9/Лазеры),   Bool, %M507.6   reg = M  width = Bit
    public bool get_wyhd_kje9 ()
    { return (bool) m_mem.getMBit(507, 6); }

    public void set_wyhd_kje9 (bool val)
    { m_mem.setMBit(507, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kje9 to " + val.ToString());}

    public bool sets_wyhd_kje9 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kje9 (val);
    return true;}

    public string gets_wyhd_kje9 () { 
    return get_wyhd_kje9().ToString();}

    public string debug_name_wyhd_kje9 () { 
    return "выхд_КЭ9";}

// выхд_КЭ10 ( КЭ10/Лазеры),   Bool, %M507.7   reg = M  width = Bit
    public bool get_wyhd_kje10 ()
    { return (bool) m_mem.getMBit(507, 7); }

    public void set_wyhd_kje10 (bool val)
    { m_mem.setMBit(507, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_kje10 to " + val.ToString());}

    public bool sets_wyhd_kje10 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_kje10 (val);
    return true;}

    public string gets_wyhd_kje10 () { 
    return get_wyhd_kje10().ToString();}

    public string debug_name_wyhd_kje10 () { 
    return "выхд_КЭ10";}

// выхд_карПрав_абс ( Каретка правая - позиция/Каретки),   Bool, %M508.0   reg = M  width = Bit
    public bool get_wyhd_karpraw_abs ()
    { return (bool) m_mem.getMBit(508, 0); }

    public void set_wyhd_karpraw_abs (bool val)
    { m_mem.setMBit(508, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karpraw_abs to " + val.ToString());}

    public bool sets_wyhd_karpraw_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karpraw_abs (val);
    return true;}

    public string gets_wyhd_karpraw_abs () { 
    return get_wyhd_karpraw_abs().ToString();}

    public string debug_name_wyhd_karpraw_abs () { 
    return "выхд_карПрав_абс";}

// выхд_карЛев_абс ( Каретка левая - позиция/Каретки),   Bool, %M508.1   reg = M  width = Bit
    public bool get_wyhd_karlew_abs ()
    { return (bool) m_mem.getMBit(508, 1); }

    public void set_wyhd_karlew_abs (bool val)
    { m_mem.setMBit(508, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karlew_abs to " + val.ToString());}

    public bool sets_wyhd_karlew_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karlew_abs (val);
    return true;}

    public string gets_wyhd_karlew_abs () { 
    return get_wyhd_karlew_abs().ToString();}

    public string debug_name_wyhd_karlew_abs () { 
    return "выхд_карЛев_абс";}

// выхд_дозПрав_впер ( Дозатор правый - вперёд/Дозаторы),   Bool, %M508.2   reg = M  width = Bit
    public bool get_wyhd_dozpraw_wper ()
    { return (bool) m_mem.getMBit(508, 2); }

    public void set_wyhd_dozpraw_wper (bool val)
    { m_mem.setMBit(508, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozpraw_wper to " + val.ToString());}

    public bool sets_wyhd_dozpraw_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozpraw_wper (val);
    return true;}

    public string gets_wyhd_dozpraw_wper () { 
    return get_wyhd_dozpraw_wper().ToString();}

    public string debug_name_wyhd_dozpraw_wper () { 
    return "выхд_дозПрав_впер";}

// выхд_дозЛев_впер ( Дозатор левый - вперёд/Дозаторы),   Bool, %M508.3   reg = M  width = Bit
    public bool get_wyhd_dozlew_wper ()
    { return (bool) m_mem.getMBit(508, 3); }

    public void set_wyhd_dozlew_wper (bool val)
    { m_mem.setMBit(508, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozlew_wper to " + val.ToString());}

    public bool sets_wyhd_dozlew_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozlew_wper (val);
    return true;}

    public string gets_wyhd_dozlew_wper () { 
    return get_wyhd_dozlew_wper().ToString();}

    public string debug_name_wyhd_dozlew_wper () { 
    return "выхд_дозЛев_впер";}

// выхд_дозПрав_назад ( Дозатор правый - назад/Дозаторы),   Bool, %M508.4   reg = M  width = Bit
    public bool get_wyhd_dozpraw_nazad ()
    { return (bool) m_mem.getMBit(508, 4); }

    public void set_wyhd_dozpraw_nazad (bool val)
    { m_mem.setMBit(508, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozpraw_nazad to " + val.ToString());}

    public bool sets_wyhd_dozpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozpraw_nazad (val);
    return true;}

    public string gets_wyhd_dozpraw_nazad () { 
    return get_wyhd_dozpraw_nazad().ToString();}

    public string debug_name_wyhd_dozpraw_nazad () { 
    return "выхд_дозПрав_назад";}

// выхд_дозЛев_назад ( Дозатор левый - назад/Дозаторы),   Bool, %M508.5   reg = M  width = Bit
    public bool get_wyhd_dozlew_nazad ()
    { return (bool) m_mem.getMBit(508, 5); }

    public void set_wyhd_dozlew_nazad (bool val)
    { m_mem.setMBit(508, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_dozlew_nazad to " + val.ToString());}

    public bool sets_wyhd_dozlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_dozlew_nazad (val);
    return true;}

    public string gets_wyhd_dozlew_nazad () { 
    return get_wyhd_dozlew_nazad().ToString();}

    public string debug_name_wyhd_dozlew_nazad () { 
    return "выхд_дозЛев_назад";}

// выхд_стол_пересчёт ( Пересчёт/Стол),   Bool, %M280.0   reg = M  width = Bit
    public bool get_wyhd_stol_peresch_t ()
    { return (bool) m_mem.getMBit(280, 0); }

    public void set_wyhd_stol_peresch_t (bool val)
    { m_mem.setMBit(280, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_stol_peresch_t to " + val.ToString());}

    public bool sets_wyhd_stol_peresch_t ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_stol_peresch_t (val);
    return true;}

    public string gets_wyhd_stol_peresch_t () { 
    return get_wyhd_stol_peresch_t().ToString();}

    public string debug_name_wyhd_stol_peresch_t () { 
    return "выхд_стол_пересчёт";}

// выхд_барЛев_вперёд ( Барабан левый - вперёд/Барабаны),   Bool, %M508.6   reg = M  width = Bit
    public bool get_wyhd_barlew_wper_d ()
    { return (bool) m_mem.getMBit(508, 6); }

    public void set_wyhd_barlew_wper_d (bool val)
    { m_mem.setMBit(508, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barlew_wper_d to " + val.ToString());}

    public bool sets_wyhd_barlew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barlew_wper_d (val);
    return true;}

    public string gets_wyhd_barlew_wper_d () { 
    return get_wyhd_barlew_wper_d().ToString();}

    public string debug_name_wyhd_barlew_wper_d () { 
    return "выхд_барЛев_вперёд";}

// выхд_барПрав_вперёд ( Барабан правый - вперёд/Барабаны),   Bool, %M508.7   reg = M  width = Bit
    public bool get_wyhd_barpraw_wper_d ()
    { return (bool) m_mem.getMBit(508, 7); }

    public void set_wyhd_barpraw_wper_d (bool val)
    { m_mem.setMBit(508, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barpraw_wper_d to " + val.ToString());}

    public bool sets_wyhd_barpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barpraw_wper_d (val);
    return true;}

    public string gets_wyhd_barpraw_wper_d () { 
    return get_wyhd_barpraw_wper_d().ToString();}

    public string debug_name_wyhd_barpraw_wper_d () { 
    return "выхд_барПрав_вперёд";}

// выхд_барЛев_назад ( Барабан левый - назад/Барабаны),   Bool, %M509.0   reg = M  width = Bit
    public bool get_wyhd_barlew_nazad ()
    { return (bool) m_mem.getMBit(509, 0); }

    public void set_wyhd_barlew_nazad (bool val)
    { m_mem.setMBit(509, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barlew_nazad to " + val.ToString());}

    public bool sets_wyhd_barlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barlew_nazad (val);
    return true;}

    public string gets_wyhd_barlew_nazad () { 
    return get_wyhd_barlew_nazad().ToString();}

    public string debug_name_wyhd_barlew_nazad () { 
    return "выхд_барЛев_назад";}

// выхд_барПрав_назад ( Барабан правый - назад/Барабаны),   Bool, %M509.1   reg = M  width = Bit
    public bool get_wyhd_barpraw_nazad ()
    { return (bool) m_mem.getMBit(509, 1); }

    public void set_wyhd_barpraw_nazad (bool val)
    { m_mem.setMBit(509, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_barpraw_nazad to " + val.ToString());}

    public bool sets_wyhd_barpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_barpraw_nazad (val);
    return true;}

    public string gets_wyhd_barpraw_nazad () { 
    return get_wyhd_barpraw_nazad().ToString();}

    public string debug_name_wyhd_barpraw_nazad () { 
    return "выхд_барПрав_назад";}

// выхд_толкЛев_вперёд ( Толкатель левый - вперёд/Толкатели),   Bool, %M509.2   reg = M  width = Bit
    public bool get_wyhd_tolklew_wper_d ()
    { return (bool) m_mem.getMBit(509, 2); }

    public void set_wyhd_tolklew_wper_d (bool val)
    { m_mem.setMBit(509, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolklew_wper_d to " + val.ToString());}

    public bool sets_wyhd_tolklew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolklew_wper_d (val);
    return true;}

    public string gets_wyhd_tolklew_wper_d () { 
    return get_wyhd_tolklew_wper_d().ToString();}

    public string debug_name_wyhd_tolklew_wper_d () { 
    return "выхд_толкЛев_вперёд";}

// выхд_толкПрав_вперёд ( Толкатель правый - вперёд/Толкатели),   Bool, %M509.3   reg = M  width = Bit
    public bool get_wyhd_tolkpraw_wper_d ()
    { return (bool) m_mem.getMBit(509, 3); }

    public void set_wyhd_tolkpraw_wper_d (bool val)
    { m_mem.setMBit(509, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolkpraw_wper_d to " + val.ToString());}

    public bool sets_wyhd_tolkpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolkpraw_wper_d (val);
    return true;}

    public string gets_wyhd_tolkpraw_wper_d () { 
    return get_wyhd_tolkpraw_wper_d().ToString();}

    public string debug_name_wyhd_tolkpraw_wper_d () { 
    return "выхд_толкПрав_вперёд";}

// выхд_толкЛев_назад ( Толкатель левый - назад/Толкатели),   Bool, %M509.4   reg = M  width = Bit
    public bool get_wyhd_tolklew_nazad ()
    { return (bool) m_mem.getMBit(509, 4); }

    public void set_wyhd_tolklew_nazad (bool val)
    { m_mem.setMBit(509, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolklew_nazad to " + val.ToString());}

    public bool sets_wyhd_tolklew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolklew_nazad (val);
    return true;}

    public string gets_wyhd_tolklew_nazad () { 
    return get_wyhd_tolklew_nazad().ToString();}

    public string debug_name_wyhd_tolklew_nazad () { 
    return "выхд_толкЛев_назад";}

// выхд_толкПрав_назад ( Толкатель правый - назад/Толкатели),   Bool, %M509.5   reg = M  width = Bit
    public bool get_wyhd_tolkpraw_nazad ()
    { return (bool) m_mem.getMBit(509, 5); }

    public void set_wyhd_tolkpraw_nazad (bool val)
    { m_mem.setMBit(509, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tolkpraw_nazad to " + val.ToString());}

    public bool sets_wyhd_tolkpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tolkpraw_nazad (val);
    return true;}

    public string gets_wyhd_tolkpraw_nazad () { 
    return get_wyhd_tolkpraw_nazad().ToString();}

    public string debug_name_wyhd_tolkpraw_nazad () { 
    return "выхд_толкПрав_назад";}

// выхд_карПрав_отн_вперёд ( Каретка правая - вперёд/Каретки),   Bool, %M509.6   reg = M  width = Bit
    public bool get_wyhd_karpraw_otn_wper_d ()
    { return (bool) m_mem.getMBit(509, 6); }

    public void set_wyhd_karpraw_otn_wper_d (bool val)
    { m_mem.setMBit(509, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karpraw_otn_wper_d to " + val.ToString());}

    public bool sets_wyhd_karpraw_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karpraw_otn_wper_d (val);
    return true;}

    public string gets_wyhd_karpraw_otn_wper_d () { 
    return get_wyhd_karpraw_otn_wper_d().ToString();}

    public string debug_name_wyhd_karpraw_otn_wper_d () { 
    return "выхд_карПрав_отн_вперёд";}

// выхд_карПрав_отн_назад ( Каретка правая - назад/Каретки),   Bool, %M509.7   reg = M  width = Bit
    public bool get_wyhd_karpraw_otn_nazad ()
    { return (bool) m_mem.getMBit(509, 7); }

    public void set_wyhd_karpraw_otn_nazad (bool val)
    { m_mem.setMBit(509, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karpraw_otn_nazad to " + val.ToString());}

    public bool sets_wyhd_karpraw_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karpraw_otn_nazad (val);
    return true;}

    public string gets_wyhd_karpraw_otn_nazad () { 
    return get_wyhd_karpraw_otn_nazad().ToString();}

    public string debug_name_wyhd_karpraw_otn_nazad () { 
    return "выхд_карПрав_отн_назад";}

// выхд_карЛев_отн_вперёд ( Каретка левая - вперёд/Каретки),   Bool, %M510.0   reg = M  width = Bit
    public bool get_wyhd_karlew_otn_wper_d ()
    { return (bool) m_mem.getMBit(510, 0); }

    public void set_wyhd_karlew_otn_wper_d (bool val)
    { m_mem.setMBit(510, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karlew_otn_wper_d to " + val.ToString());}

    public bool sets_wyhd_karlew_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karlew_otn_wper_d (val);
    return true;}

    public string gets_wyhd_karlew_otn_wper_d () { 
    return get_wyhd_karlew_otn_wper_d().ToString();}

    public string debug_name_wyhd_karlew_otn_wper_d () { 
    return "выхд_карЛев_отн_вперёд";}

// выхд_карЛев_отн_назад ( Каретка левая - назад/Каретки),   Bool, %M510.1   reg = M  width = Bit
    public bool get_wyhd_karlew_otn_nazad ()
    { return (bool) m_mem.getMBit(510, 1); }

    public void set_wyhd_karlew_otn_nazad (bool val)
    { m_mem.setMBit(510, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_karlew_otn_nazad to " + val.ToString());}

    public bool sets_wyhd_karlew_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_karlew_otn_nazad (val);
    return true;}

    public string gets_wyhd_karlew_otn_nazad () { 
    return get_wyhd_karlew_otn_nazad().ToString();}

    public string debug_name_wyhd_karlew_otn_nazad () { 
    return "выхд_карЛев_отн_назад";}

// выхд_клБарЛев ( Клапан барабана левого/Барабаны),   Bool, %M510.2   reg = M  width = Bit
    public bool get_wyhd_klbarlew ()
    { return (bool) m_mem.getMBit(510, 2); }

    public void set_wyhd_klbarlew (bool val)
    { m_mem.setMBit(510, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klbarlew to " + val.ToString());}

    public bool sets_wyhd_klbarlew ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klbarlew (val);
    return true;}

    public string gets_wyhd_klbarlew () { 
    return get_wyhd_klbarlew().ToString();}

    public string debug_name_wyhd_klbarlew () { 
    return "выхд_клБарЛев";}

// выхд_клБарПрав ( Клапан барабана правого/Барабаны),   Bool, %M510.3   reg = M  width = Bit
    public bool get_wyhd_klbarpraw ()
    { return (bool) m_mem.getMBit(510, 3); }

    public void set_wyhd_klbarpraw (bool val)
    { m_mem.setMBit(510, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_klbarpraw to " + val.ToString());}

    public bool sets_wyhd_klbarpraw ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_klbarpraw (val);
    return true;}

    public string gets_wyhd_klbarpraw () { 
    return get_wyhd_klbarpraw().ToString();}

    public string debug_name_wyhd_klbarpraw () { 
    return "выхд_клБарПрав";}

// выхд_насОткГаза ( Насос/Барабаны),   Bool, %M510.4   reg = M  width = Bit
    public bool get_wyhd_nasotkgaza ()
    { return (bool) m_mem.getMBit(510, 4); }

    public void set_wyhd_nasotkgaza (bool val)
    { m_mem.setMBit(510, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_nasotkgaza to " + val.ToString());}

    public bool sets_wyhd_nasotkgaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_nasotkgaza (val);
    return true;}

    public string gets_wyhd_nasotkgaza () { 
    return get_wyhd_nasotkgaza().ToString();}

    public string debug_name_wyhd_nasotkgaza () { 
    return "выхд_насОткГаза";}

// выхд_ТП_слой ( Слой/Автоматический процесс),   Bool, %M522.0   reg = M  width = Bit
    public bool get_wyhd_tp_sloj ()
    { return (bool) m_mem.getMBit(522, 0); }

    public void set_wyhd_tp_sloj (bool val)
    { m_mem.setMBit(522, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_sloj to " + val.ToString());}

    public bool sets_wyhd_tp_sloj ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_sloj (val);
    return true;}

    public string gets_wyhd_tp_sloj () { 
    return get_wyhd_tp_sloj().ToString();}

    public string debug_name_wyhd_tp_sloj () { 
    return "выхд_ТП_слой";}

// выхд_ТП_процесс ( Процесс/Автоматический процесс),   Bool, %M518.5   reg = M  width = Bit
    public bool get_wyhd_tp_process ()
    { return (bool) m_mem.getMBit(518, 5); }

    public void set_wyhd_tp_process (bool val)
    { m_mem.setMBit(518, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_tp_process to " + val.ToString());}

    public bool sets_wyhd_tp_process ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_tp_process (val);
    return true;}

    public string gets_wyhd_tp_process () { 
    return get_wyhd_tp_process().ToString();}

    public string debug_name_wyhd_tp_process () { 
    return "выхд_ТП_процесс";}

// выхд_лаз_пит2 ( Питание лазера2/Лазеры),   Bool, %M510.5   reg = M  width = Bit
    public bool get_wyhd_laz_pit2 ()
    { return (bool) m_mem.getMBit(510, 5); }

    public void set_wyhd_laz_pit2 (bool val)
    { m_mem.setMBit(510, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set wyhd_laz_pit2 to " + val.ToString());}

    public bool sets_wyhd_laz_pit2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_wyhd_laz_pit2 (val);
    return true;}

    public string gets_wyhd_laz_pit2 () { 
    return get_wyhd_laz_pit2().ToString();}

    public string debug_name_wyhd_laz_pit2 () { 
    return "выхд_лаз_пит2";}

public enum local_outD{
wyhd_stol_abs,
wyhd_tjen1_pit,
wyhd_tjen2_pit,
wyhd_tjen3_pit,
wyhd_stol_otn_wniz,
wyhd_stol_otn_wwerh,
wyhd_laz_pit1,
wyhd_pitchil1,
wyhd_pitchil2,
wyhd_klchil1,
wyhd_klchil2,
wyhd_pitmps,
wyhd_pitrec,
wyhd_kv1,
wyhd_kv2,
wyhd_kje9,
wyhd_kje10,
wyhd_karpraw_abs,
wyhd_karlew_abs,
wyhd_dozpraw_wper,
wyhd_dozlew_wper,
wyhd_dozpraw_nazad,
wyhd_dozlew_nazad,
wyhd_stol_peresch_t,
wyhd_barlew_wper_d,
wyhd_barpraw_wper_d,
wyhd_barlew_nazad,
wyhd_barpraw_nazad,
wyhd_tolklew_wper_d,
wyhd_tolkpraw_wper_d,
wyhd_tolklew_nazad,
wyhd_tolkpraw_nazad,
wyhd_karpraw_otn_wper_d,
wyhd_karpraw_otn_nazad,
wyhd_karlew_otn_wper_d,
wyhd_karlew_otn_nazad,
wyhd_klbarlew,
wyhd_klbarpraw,
wyhd_nasotkgaza,
wyhd_tp_sloj,
wyhd_tp_process,
wyhd_laz_pit2,
};

public gTags[] group_outD = {
gTags.wyhd_stol_abs,
gTags.wyhd_tjen1_pit,
gTags.wyhd_tjen2_pit,
gTags.wyhd_tjen3_pit,
gTags.wyhd_stol_otn_wniz,
gTags.wyhd_stol_otn_wwerh,
gTags.wyhd_laz_pit1,
gTags.wyhd_pitchil1,
gTags.wyhd_pitchil2,
gTags.wyhd_klchil1,
gTags.wyhd_klchil2,
gTags.wyhd_pitmps,
gTags.wyhd_pitrec,
gTags.wyhd_kv1,
gTags.wyhd_kv2,
gTags.wyhd_kje9,
gTags.wyhd_kje10,
gTags.wyhd_karpraw_abs,
gTags.wyhd_karlew_abs,
gTags.wyhd_dozpraw_wper,
gTags.wyhd_dozlew_wper,
gTags.wyhd_dozpraw_nazad,
gTags.wyhd_dozlew_nazad,
gTags.wyhd_stol_peresch_t,
gTags.wyhd_barlew_wper_d,
gTags.wyhd_barpraw_wper_d,
gTags.wyhd_barlew_nazad,
gTags.wyhd_barpraw_nazad,
gTags.wyhd_tolklew_wper_d,
gTags.wyhd_tolkpraw_wper_d,
gTags.wyhd_tolklew_nazad,
gTags.wyhd_tolkpraw_nazad,
gTags.wyhd_karpraw_otn_wper_d,
gTags.wyhd_karpraw_otn_nazad,
gTags.wyhd_karlew_otn_wper_d,
gTags.wyhd_karlew_otn_nazad,
gTags.wyhd_klbarlew,
gTags.wyhd_klbarpraw,
gTags.wyhd_nasotkgaza,
gTags.wyhd_tp_sloj,
gTags.wyhd_tp_process,
gTags.wyhd_laz_pit2,
};

//-----------------------------------------------------------------------------
//tags/dm.xml
//-----------------------------------------------------------------------------
// ДМ_стол_абс_домГот ( Ноль установлен/Стол),   Bool, %M521.1   reg = M  width = Bit
    public bool get_dm_stol_abs_domgot ()
    { return (bool) m_mem.getMBit(521, 1); }

    public void set_dm_stol_abs_domgot (bool val)
    { m_mem.setMBit(521, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_stol_abs_domgot to " + val.ToString());}

    public bool sets_dm_stol_abs_domgot ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_stol_abs_domgot (val);
    return true;}

    public string gets_dm_stol_abs_domgot () { 
    return get_dm_stol_abs_domgot().ToString();}

    public string debug_name_dm_stol_abs_domgot () { 
    return "ДМ_стол_абс_домГот";}

// ДМ_Расход1-1 ( Расход1-1/Лазеры),   Bool, %M528.6   reg = M  width = Bit
    public bool get_dm_rashod1_1 ()
    { return (bool) m_mem.getMBit(528, 6); }

    public void set_dm_rashod1_1 (bool val)
    { m_mem.setMBit(528, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_rashod1_1 to " + val.ToString());}

    public bool sets_dm_rashod1_1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_rashod1_1 (val);
    return true;}

    public string gets_dm_rashod1_1 () { 
    return get_dm_rashod1_1().ToString();}

    public string debug_name_dm_rashod1_1 () { 
    return "ДМ_Расход1-1";}

// ДМ_Расход1-2 ( Расход1-2/Лазеры),   Bool, %M528.7   reg = M  width = Bit
    public bool get_dm_rashod1_2 ()
    { return (bool) m_mem.getMBit(528, 7); }

    public void set_dm_rashod1_2 (bool val)
    { m_mem.setMBit(528, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_rashod1_2 to " + val.ToString());}

    public bool sets_dm_rashod1_2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_rashod1_2 (val);
    return true;}

    public string gets_dm_rashod1_2 () { 
    return get_dm_rashod1_2().ToString();}

    public string debug_name_dm_rashod1_2 () { 
    return "ДМ_Расход1-2";}

// ДМ_Расход2-1 ( Расход2-1/Лазеры),   Bool, %M529.0   reg = M  width = Bit
    public bool get_dm_rashod2_1 ()
    { return (bool) m_mem.getMBit(529, 0); }

    public void set_dm_rashod2_1 (bool val)
    { m_mem.setMBit(529, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_rashod2_1 to " + val.ToString());}

    public bool sets_dm_rashod2_1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_rashod2_1 (val);
    return true;}

    public string gets_dm_rashod2_1 () { 
    return get_dm_rashod2_1().ToString();}

    public string debug_name_dm_rashod2_1 () { 
    return "ДМ_Расход2-1";}

// ДМ_Расход2-2 ( Расход2-2/Лазеры),   Bool, %M529.1   reg = M  width = Bit
    public bool get_dm_rashod2_2 ()
    { return (bool) m_mem.getMBit(529, 1); }

    public void set_dm_rashod2_2 (bool val)
    { m_mem.setMBit(529, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_rashod2_2 to " + val.ToString());}

    public bool sets_dm_rashod2_2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_rashod2_2 (val);
    return true;}

    public string gets_dm_rashod2_2 () { 
    return get_dm_rashod2_2().ToString();}

    public string debug_name_dm_rashod2_2 () { 
    return "ДМ_Расход2-2";}

// ДМ_прот1 ( Проток1/Чиллеры),   Bool, %M532.5   reg = M  width = Bit
    public bool get_dm_prot1 ()
    { return (bool) m_mem.getMBit(532, 5); }

    public void set_dm_prot1 (bool val)
    { m_mem.setMBit(532, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_prot1 to " + val.ToString());}

    public bool sets_dm_prot1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_prot1 (val);
    return true;}

    public string gets_dm_prot1 () { 
    return get_dm_prot1().ToString();}

    public string debug_name_dm_prot1 () { 
    return "ДМ_прот1";}

// ДМ_прот2 ( Проток2/Чиллеры),   Bool, %M532.6   reg = M  width = Bit
    public bool get_dm_prot2 ()
    { return (bool) m_mem.getMBit(532, 6); }

    public void set_dm_prot2 (bool val)
    { m_mem.setMBit(532, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_prot2 to " + val.ToString());}

    public bool sets_dm_prot2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_prot2 (val);
    return true;}

    public string gets_dm_prot2 () { 
    return get_dm_prot2().ToString();}

    public string debug_name_dm_prot2 () { 
    return "ДМ_прот2";}

// ДМ_прот3 ( Проток3/Чиллеры),   Bool, %M534.4   reg = M  width = Bit
    public bool get_dm_prot3 ()
    { return (bool) m_mem.getMBit(534, 4); }

    public void set_dm_prot3 (bool val)
    { m_mem.setMBit(534, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_prot3 to " + val.ToString());}

    public bool sets_dm_prot3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_prot3 (val);
    return true;}

    public string gets_dm_prot3 () { 
    return get_dm_prot3().ToString();}

    public string debug_name_dm_prot3 () { 
    return "ДМ_прот3";}

// ДМ_прот4 ( Проток4/Чиллеры),   Bool, %M534.5   reg = M  width = Bit
    public bool get_dm_prot4 ()
    { return (bool) m_mem.getMBit(534, 5); }

    public void set_dm_prot4 (bool val)
    { m_mem.setMBit(534, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_prot4 to " + val.ToString());}

    public bool sets_dm_prot4 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_prot4 (val);
    return true;}

    public string gets_dm_prot4 () { 
    return get_dm_prot4().ToString();}

    public string debug_name_dm_prot4 () { 
    return "ДМ_прот4";}

// ДМ_прот5 ( Проток5/Чиллеры),   Bool, %M534.6   reg = M  width = Bit
    public bool get_dm_prot5 ()
    { return (bool) m_mem.getMBit(534, 6); }

    public void set_dm_prot5 (bool val)
    { m_mem.setMBit(534, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_prot5 to " + val.ToString());}

    public bool sets_dm_prot5 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_prot5 (val);
    return true;}

    public string gets_dm_prot5 () { 
    return get_dm_prot5().ToString();}

    public string debug_name_dm_prot5 () { 
    return "ДМ_прот5";}

// ДМ_прот6 ( Проток6/Чиллеры),   Bool, %M534.7   reg = M  width = Bit
    public bool get_dm_prot6 ()
    { return (bool) m_mem.getMBit(534, 7); }

    public void set_dm_prot6 (bool val)
    { m_mem.setMBit(534, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_prot6 to " + val.ToString());}

    public bool sets_dm_prot6 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_prot6 (val);
    return true;}

    public string gets_dm_prot6 () { 
    return get_dm_prot6().ToString();}

    public string debug_name_dm_prot6 () { 
    return "ДМ_прот6";}

// ДМ_карПрав_конц ( Каретка правая- концевик/Каретки),   Bool, %M535.2   reg = M  width = Bit
    public bool get_dm_karpraw_konc ()
    { return (bool) m_mem.getMBit(535, 2); }

    public void set_dm_karpraw_konc (bool val)
    { m_mem.setMBit(535, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_karpraw_konc to " + val.ToString());}

    public bool sets_dm_karpraw_konc ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_karpraw_konc (val);
    return true;}

    public string gets_dm_karpraw_konc () { 
    return get_dm_karpraw_konc().ToString();}

    public string debug_name_dm_karpraw_konc () { 
    return "ДМ_карПрав_конц";}

// ДМ_карЛев_конц ( Каретка левая- концевик/Каретки),   Bool, %M535.3   reg = M  width = Bit
    public bool get_dm_karlew_konc ()
    { return (bool) m_mem.getMBit(535, 3); }

    public void set_dm_karlew_konc (bool val)
    { m_mem.setMBit(535, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set dm_karlew_konc to " + val.ToString());}

    public bool sets_dm_karlew_konc ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_dm_karlew_konc (val);
    return true;}

    public string gets_dm_karlew_konc () { 
    return get_dm_karlew_konc().ToString();}

    public string debug_name_dm_karlew_konc () { 
    return "ДМ_карЛев_конц";}

public enum local_dm{
dm_stol_abs_domgot,
dm_rashod1_1,
dm_rashod1_2,
dm_rashod2_1,
dm_rashod2_2,
dm_prot1,
dm_prot2,
dm_prot3,
dm_prot4,
dm_prot5,
dm_prot6,
dm_karpraw_konc,
dm_karlew_konc,
};

public gTags[] group_dm = {
gTags.dm_stol_abs_domgot,
gTags.dm_rashod1_1,
gTags.dm_rashod1_2,
gTags.dm_rashod2_1,
gTags.dm_rashod2_2,
gTags.dm_prot1,
gTags.dm_prot2,
gTags.dm_prot3,
gTags.dm_prot4,
gTags.dm_prot5,
gTags.dm_prot6,
gTags.dm_karpraw_konc,
gTags.dm_karlew_konc,
};

//-----------------------------------------------------------------------------
//tags/com.xml
//-----------------------------------------------------------------------------
// ком_стол_абс ( Позиция/Стол),   Bool, %M518.4   reg = M  width = Bit
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
    return "ком_стол_абс";}

// ком_ТП_прер ( Прерывание/Автоматический процесс),   Bool, %M518.7   reg = M  width = Bit
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
    return "ком_ТП_прер";}

// ком_стол_стоп ( Стоп/Стол),   Bool, %M519.2   reg = M  width = Bit
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
    return "ком_стол_стоп";}

// ком_стол_устНуля ( Установить ноль/Стол),   Bool, %M521.0   reg = M  width = Bit
    public bool get_kom_stol_ustnulq ()
    { return (bool) m_mem.getMBit(521, 0); }

    public void set_kom_stol_ustnulq (bool val)
    { m_mem.setMBit(521, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_ustnulq to " + val.ToString());}

    public bool sets_kom_stol_ustnulq ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_ustnulq (val);
    return true;}

    public string gets_kom_stol_ustnulq () { 
    return get_kom_stol_ustnulq().ToString();}

    public string debug_name_kom_stol_ustnulq () { 
    return "ком_стол_устНуля";}

// ком_стол_отн_вниз ( Вниз/Стол),   Bool, %M521.2   reg = M  width = Bit
    public bool get_kom_stol_otn_wniz ()
    { return (bool) m_mem.getMBit(521, 2); }

    public void set_kom_stol_otn_wniz (bool val)
    { m_mem.setMBit(521, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_otn_wniz to " + val.ToString());}

    public bool sets_kom_stol_otn_wniz ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_otn_wniz (val);
    return true;}

    public string gets_kom_stol_otn_wniz () { 
    return get_kom_stol_otn_wniz().ToString();}

    public string debug_name_kom_stol_otn_wniz () { 
    return "ком_стол_отн_вниз";}

// ком_стол_отн_вверх ( Вверх/Стол),   Bool, %M521.3   reg = M  width = Bit
    public bool get_kom_stol_otn_wwerh ()
    { return (bool) m_mem.getMBit(521, 3); }

    public void set_kom_stol_otn_wwerh (bool val)
    { m_mem.setMBit(521, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_otn_wwerh to " + val.ToString());}

    public bool sets_kom_stol_otn_wwerh ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_otn_wwerh (val);
    return true;}

    public string gets_kom_stol_otn_wwerh () { 
    return get_kom_stol_otn_wwerh().ToString();}

    public string debug_name_kom_stol_otn_wwerh () { 
    return "ком_стол_отн_вверх";}

// ком_ТП_слой ( Слой/Автоматический процесс),   Bool, %M521.5   reg = M  width = Bit
    public bool get_kom_tp_sloj ()
    { return (bool) m_mem.getMBit(521, 5); }

    public void set_kom_tp_sloj (bool val)
    { m_mem.setMBit(521, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_sloj to " + val.ToString());}

    public bool sets_kom_tp_sloj ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_sloj (val);
    return true;}

    public string gets_kom_tp_sloj () { 
    return get_kom_tp_sloj().ToString();}

    public string debug_name_kom_tp_sloj () { 
    return "ком_ТП_слой";}

// ком_стол_обнулитьЛинейку ( Обнулить линейку/Стол),   Bool, %M522.7   reg = M  width = Bit
    public bool get_kom_stol_obnulit_linejku ()
    { return (bool) m_mem.getMBit(522, 7); }

    public void set_kom_stol_obnulit_linejku (bool val)
    { m_mem.setMBit(522, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_obnulit_linejku to " + val.ToString());}

    public bool sets_kom_stol_obnulit_linejku ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_obnulit_linejku (val);
    return true;}

    public string gets_kom_stol_obnulit_linejku () { 
    return get_kom_stol_obnulit_linejku().ToString();}

    public string debug_name_kom_stol_obnulit_linejku () { 
    return "ком_стол_обнулитьЛинейку";}

// ком_ТЭН3 ( ТЭН3/Нагреватели),   Bool, %M524.2   reg = M  width = Bit
    public bool get_kom_tjen3 ()
    { return (bool) m_mem.getMBit(524, 2); }

    public void set_kom_tjen3 (bool val)
    { m_mem.setMBit(524, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tjen3 to " + val.ToString());}

    public bool sets_kom_tjen3 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tjen3 (val);
    return true;}

    public string gets_kom_tjen3 () { 
    return get_kom_tjen3().ToString();}

    public string debug_name_kom_tjen3 () { 
    return "ком_ТЭН3";}

// ком_ТЭН1 ( ТЭН1/Нагреватели),   Bool, %M524.3   reg = M  width = Bit
    public bool get_kom_tjen1 ()
    { return (bool) m_mem.getMBit(524, 3); }

    public void set_kom_tjen1 (bool val)
    { m_mem.setMBit(524, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tjen1 to " + val.ToString());}

    public bool sets_kom_tjen1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tjen1 (val);
    return true;}

    public string gets_kom_tjen1 () { 
    return get_kom_tjen1().ToString();}

    public string debug_name_kom_tjen1 () { 
    return "ком_ТЭН1";}

// ком_ТЭН2 ( ТЭН2/Нагреватели),   Bool, %M524.4   reg = M  width = Bit
    public bool get_kom_tjen2 ()
    { return (bool) m_mem.getMBit(524, 4); }

    public void set_kom_tjen2 (bool val)
    { m_mem.setMBit(524, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tjen2 to " + val.ToString());}

    public bool sets_kom_tjen2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tjen2 (val);
    return true;}

    public string gets_kom_tjen2 () { 
    return get_kom_tjen2().ToString();}

    public string debug_name_kom_tjen2 () { 
    return "ком_ТЭН2";}

// ком_ТП_процесс ( Процесс/Автоматический процесс),   Bool, %M521.4   reg = M  width = Bit
    public bool get_kom_tp_process ()
    { return (bool) m_mem.getMBit(521, 4); }

    public void set_kom_tp_process (bool val)
    { m_mem.setMBit(521, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_process to " + val.ToString());}

    public bool sets_kom_tp_process ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_process (val);
    return true;}

    public string gets_kom_tp_process () { 
    return get_kom_tp_process().ToString();}

    public string debug_name_kom_tp_process () { 
    return "ком_ТП_процесс";}

// ком_стол_пересчёт ( Пересчёт/Стол),   Bool, %M526.1   reg = M  width = Bit
    public bool get_kom_stol_peresch_t ()
    { return (bool) m_mem.getMBit(526, 1); }

    public void set_kom_stol_peresch_t (bool val)
    { m_mem.setMBit(526, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_stol_peresch_t to " + val.ToString());}

    public bool sets_kom_stol_peresch_t ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_stol_peresch_t (val);
    return true;}

    public string gets_kom_stol_peresch_t () { 
    return get_kom_stol_peresch_t().ToString();}

    public string debug_name_kom_stol_peresch_t () { 
    return "ком_стол_пересчёт";}

// ком_лаз_пит1 ( Питание лазера1/Лазеры),   Bool, %M526.2   reg = M  width = Bit
    public bool get_kom_laz_pit1 ()
    { return (bool) m_mem.getMBit(526, 2); }

    public void set_kom_laz_pit1 (bool val)
    { m_mem.setMBit(526, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_pit1 to " + val.ToString());}

    public bool sets_kom_laz_pit1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_pit1 (val);
    return true;}

    public string gets_kom_laz_pit1 () { 
    return get_kom_laz_pit1().ToString();}

    public string debug_name_kom_laz_pit1 () { 
    return "ком_лаз_пит1";}

// ком_лаз_гот1 ( Готовностть1/Лазеры),   Bool, %M526.3   reg = M  width = Bit
    public bool get_kom_laz_got1 ()
    { return (bool) m_mem.getMBit(526, 3); }

    public void set_kom_laz_got1 (bool val)
    { m_mem.setMBit(526, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_got1 to " + val.ToString());}

    public bool sets_kom_laz_got1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_got1 (val);
    return true;}

    public string gets_kom_laz_got1 () { 
    return get_kom_laz_got1().ToString();}

    public string debug_name_kom_laz_got1 () { 
    return "ком_лаз_гот1";}

// ком_ТП_пауза ( Пауза/Автоматический процесс),   Bool, %M526.7   reg = M  width = Bit
    public bool get_kom_tp_pauza ()
    { return (bool) m_mem.getMBit(526, 7); }

    public void set_kom_tp_pauza (bool val)
    { m_mem.setMBit(526, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tp_pauza to " + val.ToString());}

    public bool sets_kom_tp_pauza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tp_pauza (val);
    return true;}

    public string gets_kom_tp_pauza () { 
    return get_kom_tp_pauza().ToString();}

    public string debug_name_kom_tp_pauza () { 
    return "ком_ТП_пауза";}

// ком_питЧил1 ( Питание чиллера1/Чиллеры),   Bool, %M527.7   reg = M  width = Bit
    public bool get_kom_pitchil1 ()
    { return (bool) m_mem.getMBit(527, 7); }

    public void set_kom_pitchil1 (bool val)
    { m_mem.setMBit(527, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitchil1 to " + val.ToString());}

    public bool sets_kom_pitchil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitchil1 (val);
    return true;}

    public string gets_kom_pitchil1 () { 
    return get_kom_pitchil1().ToString();}

    public string debug_name_kom_pitchil1 () { 
    return "ком_питЧил1";}

// ком_питЧил2 ( Питание чиллера2/Чиллеры),   Bool, %M528.0   reg = M  width = Bit
    public bool get_kom_pitchil2 ()
    { return (bool) m_mem.getMBit(528, 0); }

    public void set_kom_pitchil2 (bool val)
    { m_mem.setMBit(528, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitchil2 to " + val.ToString());}

    public bool sets_kom_pitchil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitchil2 (val);
    return true;}

    public string gets_kom_pitchil2 () { 
    return get_kom_pitchil2().ToString();}

    public string debug_name_kom_pitchil2 () { 
    return "ком_питЧил2";}

// ком_клЧил1 ( Клапаны чиллера1/Чиллеры),   Bool, %M528.1   reg = M  width = Bit
    public bool get_kom_klchil1 ()
    { return (bool) m_mem.getMBit(528, 1); }

    public void set_kom_klchil1 (bool val)
    { m_mem.setMBit(528, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klchil1 to " + val.ToString());}

    public bool sets_kom_klchil1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klchil1 (val);
    return true;}

    public string gets_kom_klchil1 () { 
    return get_kom_klchil1().ToString();}

    public string debug_name_kom_klchil1 () { 
    return "ком_клЧил1";}

// ком_клЧил2 ( Клапаны чиллера2/Чиллеры),   Bool, %M528.2   reg = M  width = Bit
    public bool get_kom_klchil2 ()
    { return (bool) m_mem.getMBit(528, 2); }

    public void set_kom_klchil2 (bool val)
    { m_mem.setMBit(528, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klchil2 to " + val.ToString());}

    public bool sets_kom_klchil2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klchil2 (val);
    return true;}

    public string gets_kom_klchil2 () { 
    return get_kom_klchil2().ToString();}

    public string debug_name_kom_klchil2 () { 
    return "ком_клЧил2";}

// ком_питРец ( Насос - улитка/Рецеркуляция),   Bool, %M528.3   reg = M  width = Bit
    public bool get_kom_pitrec ()
    { return (bool) m_mem.getMBit(528, 3); }

    public void set_kom_pitrec (bool val)
    { m_mem.setMBit(528, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitrec to " + val.ToString());}

    public bool sets_kom_pitrec ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitrec (val);
    return true;}

    public string gets_kom_pitrec () { 
    return get_kom_pitrec().ToString();}

    public string debug_name_kom_pitrec () { 
    return "ком_питРец";}

// ком_питМПС ( Питание МПС/Каретки),   Bool, %M528.4   reg = M  width = Bit
    public bool get_kom_pitmps ()
    { return (bool) m_mem.getMBit(528, 4); }

    public void set_kom_pitmps (bool val)
    { m_mem.setMBit(528, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_pitmps to " + val.ToString());}

    public bool sets_kom_pitmps ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_pitmps (val);
    return true;}

    public string gets_kom_pitmps () { 
    return get_kom_pitmps().ToString();}

    public string debug_name_kom_pitmps () { 
    return "ком_питМПС";}

// ком_карЛев_отн_вперёд ( Каретка левая - вперёд/Каретки),   Bool, %M529.2   reg = M  width = Bit
    public bool get_kom_karlew_otn_wper_d ()
    { return (bool) m_mem.getMBit(529, 2); }

    public void set_kom_karlew_otn_wper_d (bool val)
    { m_mem.setMBit(529, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_otn_wper_d to " + val.ToString());}

    public bool sets_kom_karlew_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_otn_wper_d (val);
    return true;}

    public string gets_kom_karlew_otn_wper_d () { 
    return get_kom_karlew_otn_wper_d().ToString();}

    public string debug_name_kom_karlew_otn_wper_d () { 
    return "ком_карЛев_отн_вперёд";}

// ком_карЛев_отн_назад ( Каретка левая - назад/Каретки),   Bool, %M529.3   reg = M  width = Bit
    public bool get_kom_karlew_otn_nazad ()
    { return (bool) m_mem.getMBit(529, 3); }

    public void set_kom_karlew_otn_nazad (bool val)
    { m_mem.setMBit(529, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_otn_nazad to " + val.ToString());}

    public bool sets_kom_karlew_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_otn_nazad (val);
    return true;}

    public string gets_kom_karlew_otn_nazad () { 
    return get_kom_karlew_otn_nazad().ToString();}

    public string debug_name_kom_karlew_otn_nazad () { 
    return "ком_карЛев_отн_назад";}

// ком_карЛев_абс ( Каретка левая - позиция/Каретки),   Bool, %M529.4   reg = M  width = Bit
    public bool get_kom_karlew_abs ()
    { return (bool) m_mem.getMBit(529, 4); }

    public void set_kom_karlew_abs (bool val)
    { m_mem.setMBit(529, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_abs to " + val.ToString());}

    public bool sets_kom_karlew_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_abs (val);
    return true;}

    public string gets_kom_karlew_abs () { 
    return get_kom_karlew_abs().ToString();}

    public string debug_name_kom_karlew_abs () { 
    return "ком_карЛев_абс";}

// ком_карПрав_отн_вперёд ( Каретка правая - вперёд/Каретки),   Bool, %M529.6   reg = M  width = Bit
    public bool get_kom_karpraw_otn_wper_d ()
    { return (bool) m_mem.getMBit(529, 6); }

    public void set_kom_karpraw_otn_wper_d (bool val)
    { m_mem.setMBit(529, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_otn_wper_d to " + val.ToString());}

    public bool sets_kom_karpraw_otn_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_otn_wper_d (val);
    return true;}

    public string gets_kom_karpraw_otn_wper_d () { 
    return get_kom_karpraw_otn_wper_d().ToString();}

    public string debug_name_kom_karpraw_otn_wper_d () { 
    return "ком_карПрав_отн_вперёд";}

// ком_карПрав_отн_назад ( Каретка правая - назад/Каретки),   Bool, %M529.7   reg = M  width = Bit
    public bool get_kom_karpraw_otn_nazad ()
    { return (bool) m_mem.getMBit(529, 7); }

    public void set_kom_karpraw_otn_nazad (bool val)
    { m_mem.setMBit(529, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_otn_nazad to " + val.ToString());}

    public bool sets_kom_karpraw_otn_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_otn_nazad (val);
    return true;}

    public string gets_kom_karpraw_otn_nazad () { 
    return get_kom_karpraw_otn_nazad().ToString();}

    public string debug_name_kom_karpraw_otn_nazad () { 
    return "ком_карПрав_отн_назад";}

// ком_карПрав_абс ( Каретка правая - позиция/Каретки),   Bool, %M530.1   reg = M  width = Bit
    public bool get_kom_karpraw_abs ()
    { return (bool) m_mem.getMBit(530, 1); }

    public void set_kom_karpraw_abs (bool val)
    { m_mem.setMBit(530, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_abs to " + val.ToString());}

    public bool sets_kom_karpraw_abs ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_abs (val);
    return true;}

    public string gets_kom_karpraw_abs () { 
    return get_kom_karpraw_abs().ToString();}

    public string debug_name_kom_karpraw_abs () { 
    return "ком_карПрав_абс";}

// ком_барПрав_вперёд ( Барабан правый - вперёд/Барабаны),   Bool, %M531.4   reg = M  width = Bit
    public bool get_kom_barpraw_wper_d ()
    { return (bool) m_mem.getMBit(531, 4); }

    public void set_kom_barpraw_wper_d (bool val)
    { m_mem.setMBit(531, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barpraw_wper_d to " + val.ToString());}

    public bool sets_kom_barpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barpraw_wper_d (val);
    return true;}

    public string gets_kom_barpraw_wper_d () { 
    return get_kom_barpraw_wper_d().ToString();}

    public string debug_name_kom_barpraw_wper_d () { 
    return "ком_барПрав_вперёд";}

// ком_барПрав_назад ( Барабан правый - назад/Барабаны),   Bool, %M531.5   reg = M  width = Bit
    public bool get_kom_barpraw_nazad ()
    { return (bool) m_mem.getMBit(531, 5); }

    public void set_kom_barpraw_nazad (bool val)
    { m_mem.setMBit(531, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barpraw_nazad to " + val.ToString());}

    public bool sets_kom_barpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barpraw_nazad (val);
    return true;}

    public string gets_kom_barpraw_nazad () { 
    return get_kom_barpraw_nazad().ToString();}

    public string debug_name_kom_barpraw_nazad () { 
    return "ком_барПрав_назад";}

// ком_барЛев_вперёд ( Барабан левый - вперёд/Барабаны),   Bool, %M532.0   reg = M  width = Bit
    public bool get_kom_barlew_wper_d ()
    { return (bool) m_mem.getMBit(532, 0); }

    public void set_kom_barlew_wper_d (bool val)
    { m_mem.setMBit(532, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barlew_wper_d to " + val.ToString());}

    public bool sets_kom_barlew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barlew_wper_d (val);
    return true;}

    public string gets_kom_barlew_wper_d () { 
    return get_kom_barlew_wper_d().ToString();}

    public string debug_name_kom_barlew_wper_d () { 
    return "ком_барЛев_вперёд";}

// ком_барЛев_назад ( Барабан левый - назад/Барабаны),   Bool, %M532.1   reg = M  width = Bit
    public bool get_kom_barlew_nazad ()
    { return (bool) m_mem.getMBit(532, 1); }

    public void set_kom_barlew_nazad (bool val)
    { m_mem.setMBit(532, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barlew_nazad to " + val.ToString());}

    public bool sets_kom_barlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barlew_nazad (val);
    return true;}

    public string gets_kom_barlew_nazad () { 
    return get_kom_barlew_nazad().ToString();}

    public string debug_name_kom_barlew_nazad () { 
    return "ком_барЛев_назад";}

// ком_дозЛев_впер ( Дозатор левый - вперёд/Дозаторы),   Bool, %M532.4   reg = M  width = Bit
    public bool get_kom_dozlew_wper ()
    { return (bool) m_mem.getMBit(532, 4); }

    public void set_kom_dozlew_wper (bool val)
    { m_mem.setMBit(532, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozlew_wper to " + val.ToString());}

    public bool sets_kom_dozlew_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozlew_wper (val);
    return true;}

    public string gets_kom_dozlew_wper () { 
    return get_kom_dozlew_wper().ToString();}

    public string debug_name_kom_dozlew_wper () { 
    return "ком_дозЛев_впер";}

// ком_дозПрав_впер ( Дозатор правый - вперёд/Дозаторы),   Bool, %M532.7   reg = M  width = Bit
    public bool get_kom_dozpraw_wper ()
    { return (bool) m_mem.getMBit(532, 7); }

    public void set_kom_dozpraw_wper (bool val)
    { m_mem.setMBit(532, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozpraw_wper to " + val.ToString());}

    public bool sets_kom_dozpraw_wper ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozpraw_wper (val);
    return true;}

    public string gets_kom_dozpraw_wper () { 
    return get_kom_dozpraw_wper().ToString();}

    public string debug_name_kom_dozpraw_wper () { 
    return "ком_дозПрав_впер";}

// ком_толкЛев_вперёд ( Толкатель левый - вперёд/Толкатели),   Bool, %M533.2   reg = M  width = Bit
    public bool get_kom_tolklew_wper_d ()
    { return (bool) m_mem.getMBit(533, 2); }

    public void set_kom_tolklew_wper_d (bool val)
    { m_mem.setMBit(533, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolklew_wper_d to " + val.ToString());}

    public bool sets_kom_tolklew_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolklew_wper_d (val);
    return true;}

    public string gets_kom_tolklew_wper_d () { 
    return get_kom_tolklew_wper_d().ToString();}

    public string debug_name_kom_tolklew_wper_d () { 
    return "ком_толкЛев_вперёд";}

// ком_толкЛев_назад ( Толкатель левый - назад/Толкатели),   Bool, %M533.3   reg = M  width = Bit
    public bool get_kom_tolklew_nazad ()
    { return (bool) m_mem.getMBit(533, 3); }

    public void set_kom_tolklew_nazad (bool val)
    { m_mem.setMBit(533, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolklew_nazad to " + val.ToString());}

    public bool sets_kom_tolklew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolklew_nazad (val);
    return true;}

    public string gets_kom_tolklew_nazad () { 
    return get_kom_tolklew_nazad().ToString();}

    public string debug_name_kom_tolklew_nazad () { 
    return "ком_толкЛев_назад";}

// ком_толкПрав_вперёд ( Толкатель правый - вперёд/Толкатели),   Bool, %M533.5   reg = M  width = Bit
    public bool get_kom_tolkpraw_wper_d ()
    { return (bool) m_mem.getMBit(533, 5); }

    public void set_kom_tolkpraw_wper_d (bool val)
    { m_mem.setMBit(533, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkpraw_wper_d to " + val.ToString());}

    public bool sets_kom_tolkpraw_wper_d ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkpraw_wper_d (val);
    return true;}

    public string gets_kom_tolkpraw_wper_d () { 
    return get_kom_tolkpraw_wper_d().ToString();}

    public string debug_name_kom_tolkpraw_wper_d () { 
    return "ком_толкПрав_вперёд";}

// ком_толкПрав_назад ( Толкатель правый - назад/Толкатели),   Bool, %M533.6   reg = M  width = Bit
    public bool get_kom_tolkpraw_nazad ()
    { return (bool) m_mem.getMBit(533, 6); }

    public void set_kom_tolkpraw_nazad (bool val)
    { m_mem.setMBit(533, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_tolkpraw_nazad to " + val.ToString());}

    public bool sets_kom_tolkpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_tolkpraw_nazad (val);
    return true;}

    public string gets_kom_tolkpraw_nazad () { 
    return get_kom_tolkpraw_nazad().ToString();}

    public string debug_name_kom_tolkpraw_nazad () { 
    return "ком_толкПрав_назад";}

// ком_дозЛев_назад ( Дозатор левый - назад/Дозаторы),   Bool, %M533.0   reg = M  width = Bit
    public bool get_kom_dozlew_nazad ()
    { return (bool) m_mem.getMBit(533, 0); }

    public void set_kom_dozlew_nazad (bool val)
    { m_mem.setMBit(533, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozlew_nazad to " + val.ToString());}

    public bool sets_kom_dozlew_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozlew_nazad (val);
    return true;}

    public string gets_kom_dozlew_nazad () { 
    return get_kom_dozlew_nazad().ToString();}

    public string debug_name_kom_dozlew_nazad () { 
    return "ком_дозЛев_назад";}

// ком_дозПрав_назад ( Дозатор правый - назад/Дозаторы),   Bool, %M533.1   reg = M  width = Bit
    public bool get_kom_dozpraw_nazad ()
    { return (bool) m_mem.getMBit(533, 1); }

    public void set_kom_dozpraw_nazad (bool val)
    { m_mem.setMBit(533, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozpraw_nazad to " + val.ToString());}

    public bool sets_kom_dozpraw_nazad ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozpraw_nazad (val);
    return true;}

    public string gets_kom_dozpraw_nazad () { 
    return get_kom_dozpraw_nazad().ToString();}

    public string debug_name_kom_dozpraw_nazad () { 
    return "ком_дозПрав_назад";}

// ком_КЭ9_охл_скан1 ( КЭ9 Клапан охл скан1/Лазеры),   Bool, %M533.4   reg = M  width = Bit
    public bool get_kom_kje9_ohl_skan1 ()
    { return (bool) m_mem.getMBit(533, 4); }

    public void set_kom_kje9_ohl_skan1 (bool val)
    { m_mem.setMBit(533, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kje9_ohl_skan1 to " + val.ToString());}

    public bool sets_kom_kje9_ohl_skan1 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kje9_ohl_skan1 (val);
    return true;}

    public string gets_kom_kje9_ohl_skan1 () { 
    return get_kom_kje9_ohl_skan1().ToString();}

    public string debug_name_kom_kje9_ohl_skan1 () { 
    return "ком_КЭ9_охл_скан1";}

// ком_КЭ10_охл_скан2 ( КЭ10 Клапан охл скан2/Лазеры),   Bool, %M533.7   reg = M  width = Bit
    public bool get_kom_kje10_ohl_skan2 ()
    { return (bool) m_mem.getMBit(533, 7); }

    public void set_kom_kje10_ohl_skan2 (bool val)
    { m_mem.setMBit(533, 7, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_kje10_ohl_skan2 to " + val.ToString());}

    public bool sets_kom_kje10_ohl_skan2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_kje10_ohl_skan2 (val);
    return true;}

    public string gets_kom_kje10_ohl_skan2 () { 
    return get_kom_kje10_ohl_skan2().ToString();}

    public string debug_name_kom_kje10_ohl_skan2 () { 
    return "ком_КЭ10_охл_скан2";}

// ком_КВ1 ( КВ1/Рецеркуляция),   Bool, %M534.0   reg = M  width = Bit
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
    return "ком_КВ1";}

// ком_КВ2 ( КВ2/Рецеркуляция),   Bool, %M534.1   reg = M  width = Bit
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
    return "ком_КВ2";}

// ком_клБарЛев ( Клапан барабана левого/Барабаны),   Bool, %M534.2   reg = M  width = Bit
    public bool get_kom_klbarlew ()
    { return (bool) m_mem.getMBit(534, 2); }

    public void set_kom_klbarlew (bool val)
    { m_mem.setMBit(534, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klbarlew to " + val.ToString());}

    public bool sets_kom_klbarlew ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klbarlew (val);
    return true;}

    public string gets_kom_klbarlew () { 
    return get_kom_klbarlew().ToString();}

    public string debug_name_kom_klbarlew () { 
    return "ком_клБарЛев";}

// ком_клБарПрав ( Клапан барабана правого/Барабаны),   Bool, %M534.3   reg = M  width = Bit
    public bool get_kom_klbarpraw ()
    { return (bool) m_mem.getMBit(534, 3); }

    public void set_kom_klbarpraw (bool val)
    { m_mem.setMBit(534, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_klbarpraw to " + val.ToString());}

    public bool sets_kom_klbarpraw ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_klbarpraw (val);
    return true;}

    public string gets_kom_klbarpraw () { 
    return get_kom_klbarpraw().ToString();}

    public string debug_name_kom_klbarpraw () { 
    return "ком_клБарПрав";}

// ком_насОткГаза ( Насос/Барабаны),   Bool, %M519.1   reg = M  width = Bit
    public bool get_kom_nasotkgaza ()
    { return (bool) m_mem.getMBit(519, 1); }

    public void set_kom_nasotkgaza (bool val)
    { m_mem.setMBit(519, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_nasotkgaza to " + val.ToString());}

    public bool sets_kom_nasotkgaza ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_nasotkgaza (val);
    return true;}

    public string gets_kom_nasotkgaza () { 
    return get_kom_nasotkgaza().ToString();}

    public string debug_name_kom_nasotkgaza () { 
    return "ком_насОткГаза";}

// ком_барЛев_стоп ( Барабан левый - стоп/Барабаны),   Bool, %M532.2   reg = M  width = Bit
    public bool get_kom_barlew_stop ()
    { return (bool) m_mem.getMBit(532, 2); }

    public void set_kom_barlew_stop (bool val)
    { m_mem.setMBit(532, 2, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barlew_stop to " + val.ToString());}

    public bool sets_kom_barlew_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barlew_stop (val);
    return true;}

    public string gets_kom_barlew_stop () { 
    return get_kom_barlew_stop().ToString();}

    public string debug_name_kom_barlew_stop () { 
    return "ком_барЛев_стоп";}

// ком_барПрав_стоп ( Барабан правый - стоп/Барабаны),   Bool, %M531.6   reg = M  width = Bit
    public bool get_kom_barpraw_stop ()
    { return (bool) m_mem.getMBit(531, 6); }

    public void set_kom_barpraw_stop (bool val)
    { m_mem.setMBit(531, 6, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_barpraw_stop to " + val.ToString());}

    public bool sets_kom_barpraw_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_barpraw_stop (val);
    return true;}

    public string gets_kom_barpraw_stop () { 
    return get_kom_barpraw_stop().ToString();}

    public string debug_name_kom_barpraw_stop () { 
    return "ком_барПрав_стоп";}

// ком_дозЛев_стоп ( Дозатор левый - стоп/Дозаторы),   Bool, %M535.0   reg = M  width = Bit
    public bool get_kom_dozlew_stop ()
    { return (bool) m_mem.getMBit(535, 0); }

    public void set_kom_dozlew_stop (bool val)
    { m_mem.setMBit(535, 0, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozlew_stop to " + val.ToString());}

    public bool sets_kom_dozlew_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozlew_stop (val);
    return true;}

    public string gets_kom_dozlew_stop () { 
    return get_kom_dozlew_stop().ToString();}

    public string debug_name_kom_dozlew_stop () { 
    return "ком_дозЛев_стоп";}

// ком_дозПрав_стоп ( Дозатор правый - стоп/Дозаторы),   Bool, %M535.1   reg = M  width = Bit
    public bool get_kom_dozpraw_stop ()
    { return (bool) m_mem.getMBit(535, 1); }

    public void set_kom_dozpraw_stop (bool val)
    { m_mem.setMBit(535, 1, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_dozpraw_stop to " + val.ToString());}

    public bool sets_kom_dozpraw_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_dozpraw_stop (val);
    return true;}

    public string gets_kom_dozpraw_stop () { 
    return get_kom_dozpraw_stop().ToString();}

    public string debug_name_kom_dozpraw_stop () { 
    return "ком_дозПрав_стоп";}

// ком_карЛев_стоп ( Каретка левая - стоп/Каретки),   Bool, %M529.5   reg = M  width = Bit
    public bool get_kom_karlew_stop ()
    { return (bool) m_mem.getMBit(529, 5); }

    public void set_kom_karlew_stop (bool val)
    { m_mem.setMBit(529, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karlew_stop to " + val.ToString());}

    public bool sets_kom_karlew_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karlew_stop (val);
    return true;}

    public string gets_kom_karlew_stop () { 
    return get_kom_karlew_stop().ToString();}

    public string debug_name_kom_karlew_stop () { 
    return "ком_карЛев_стоп";}

// ком_карПрав_стоп ( Каретка правая - стоп/Каретки),   Bool, %M531.3   reg = M  width = Bit
    public bool get_kom_karpraw_stop ()
    { return (bool) m_mem.getMBit(531, 3); }

    public void set_kom_karpraw_stop (bool val)
    { m_mem.setMBit(531, 3, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_karpraw_stop to " + val.ToString());}

    public bool sets_kom_karpraw_stop ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_karpraw_stop (val);
    return true;}

    public string gets_kom_karpraw_stop () { 
    return get_kom_karpraw_stop().ToString();}

    public string debug_name_kom_karpraw_stop () { 
    return "ком_карПрав_стоп";}

// ком_лаз_гот2 ( Готовностть2/Лазеры),   Bool, %M526.4   reg = M  width = Bit
    public bool get_kom_laz_got2 ()
    { return (bool) m_mem.getMBit(526, 4); }

    public void set_kom_laz_got2 (bool val)
    { m_mem.setMBit(526, 4, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_got2 to " + val.ToString());}

    public bool sets_kom_laz_got2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_got2 (val);
    return true;}

    public string gets_kom_laz_got2 () { 
    return get_kom_laz_got2().ToString();}

    public string debug_name_kom_laz_got2 () { 
    return "ком_лаз_гот2";}

// ком_лаз_пит2 ( Питание лазера2/Лазеры),   Bool, %M526.5   reg = M  width = Bit
    public bool get_kom_laz_pit2 ()
    { return (bool) m_mem.getMBit(526, 5); }

    public void set_kom_laz_pit2 (bool val)
    { m_mem.setMBit(526, 5, (bool) val); 
      Log.Write(LogLevel.Info, "set kom_laz_pit2 to " + val.ToString());}

    public bool sets_kom_laz_pit2 ( string str) {
    bool val;
    if (!bool.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as bool ");
        return false; }
    set_kom_laz_pit2 (val);
    return true;}

    public string gets_kom_laz_pit2 () { 
    return get_kom_laz_pit2().ToString();}

    public string debug_name_kom_laz_pit2 () { 
    return "ком_лаз_пит2";}

public enum local_com{
kom_stol_abs,
kom_tp_prer,
kom_stol_stop,
kom_stol_ustnulq,
kom_stol_otn_wniz,
kom_stol_otn_wwerh,
kom_tp_sloj,
kom_stol_obnulit_linejku,
kom_tjen3,
kom_tjen1,
kom_tjen2,
kom_tp_process,
kom_stol_peresch_t,
kom_laz_pit1,
kom_laz_got1,
kom_tp_pauza,
kom_pitchil1,
kom_pitchil2,
kom_klchil1,
kom_klchil2,
kom_pitrec,
kom_pitmps,
kom_karlew_otn_wper_d,
kom_karlew_otn_nazad,
kom_karlew_abs,
kom_karpraw_otn_wper_d,
kom_karpraw_otn_nazad,
kom_karpraw_abs,
kom_barpraw_wper_d,
kom_barpraw_nazad,
kom_barlew_wper_d,
kom_barlew_nazad,
kom_dozlew_wper,
kom_dozpraw_wper,
kom_tolklew_wper_d,
kom_tolklew_nazad,
kom_tolkpraw_wper_d,
kom_tolkpraw_nazad,
kom_dozlew_nazad,
kom_dozpraw_nazad,
kom_kje9_ohl_skan1,
kom_kje10_ohl_skan2,
kom_kv1,
kom_kv2,
kom_klbarlew,
kom_klbarpraw,
kom_nasotkgaza,
kom_barlew_stop,
kom_barpraw_stop,
kom_dozlew_stop,
kom_dozpraw_stop,
kom_karlew_stop,
kom_karpraw_stop,
kom_laz_got2,
kom_laz_pit2,
};

public gTags[] group_com = {
gTags.kom_stol_abs,
gTags.kom_tp_prer,
gTags.kom_stol_stop,
gTags.kom_stol_ustnulq,
gTags.kom_stol_otn_wniz,
gTags.kom_stol_otn_wwerh,
gTags.kom_tp_sloj,
gTags.kom_stol_obnulit_linejku,
gTags.kom_tjen3,
gTags.kom_tjen1,
gTags.kom_tjen2,
gTags.kom_tp_process,
gTags.kom_stol_peresch_t,
gTags.kom_laz_pit1,
gTags.kom_laz_got1,
gTags.kom_tp_pauza,
gTags.kom_pitchil1,
gTags.kom_pitchil2,
gTags.kom_klchil1,
gTags.kom_klchil2,
gTags.kom_pitrec,
gTags.kom_pitmps,
gTags.kom_karlew_otn_wper_d,
gTags.kom_karlew_otn_nazad,
gTags.kom_karlew_abs,
gTags.kom_karpraw_otn_wper_d,
gTags.kom_karpraw_otn_nazad,
gTags.kom_karpraw_abs,
gTags.kom_barpraw_wper_d,
gTags.kom_barpraw_nazad,
gTags.kom_barlew_wper_d,
gTags.kom_barlew_nazad,
gTags.kom_dozlew_wper,
gTags.kom_dozpraw_wper,
gTags.kom_tolklew_wper_d,
gTags.kom_tolklew_nazad,
gTags.kom_tolkpraw_wper_d,
gTags.kom_tolkpraw_nazad,
gTags.kom_dozlew_nazad,
gTags.kom_dozpraw_nazad,
gTags.kom_kje9_ohl_skan1,
gTags.kom_kje10_ohl_skan2,
gTags.kom_kv1,
gTags.kom_kv2,
gTags.kom_klbarlew,
gTags.kom_klbarpraw,
gTags.kom_nasotkgaza,
gTags.kom_barlew_stop,
gTags.kom_barpraw_stop,
gTags.kom_dozlew_stop,
gTags.kom_dozpraw_stop,
gTags.kom_karlew_stop,
gTags.kom_karpraw_stop,
gTags.kom_laz_got2,
gTags.kom_laz_pit2,
};

//-----------------------------------------------------------------------------
//tags/usta.xml
//-----------------------------------------------------------------------------
// уст_стол_абс_поз ( Позиция/Стол),   Real, %MD436   reg = M  width = UInt32
    public float get_ust_stol_abs_poz ()
    { return (float) m_mem.getMFloat(436); }

    public void set_ust_stol_abs_poz (float val)
    { m_mem.setMFloat(436, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_abs_poz to " + val.ToString());}

    public bool sets_ust_stol_abs_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_abs_poz (val);
    return true;}

    public string gets_ust_stol_abs_poz () { 
    return get_ust_stol_abs_poz().ToString();}

    public string debug_name_ust_stol_abs_poz () { 
    return "уст_стол_абс_поз";}

// уст_стол_скор ( Скорость/Стол),   Real, %MD424   reg = M  width = UInt32
    public float get_ust_stol_skor ()
    { return (float) m_mem.getMFloat(424); }

    public void set_ust_stol_skor (float val)
    { m_mem.setMFloat(424, (float) val); 
      Log.Write(LogLevel.Info, "set ust_stol_skor to " + val.ToString());}

    public bool sets_ust_stol_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_stol_skor (val);
    return true;}

    public string gets_ust_stol_skor () { 
    return get_ust_stol_skor().ToString();}

    public string debug_name_ust_stol_skor () { 
    return "уст_стол_скор";}

// уст_стол_отн_расст ( Расстояние/Стол),   Real, %MD448   reg = M  width = UInt32
    public float get_ust_stol_otn_rasst ()
    { return (float) m_mem.getMFloat(448); }

    public void set_ust_stol_otn_rasst (float val)
    { m_mem.setMFloat(448, (float) val); 
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
    return "уст_стол_отн_расст";}

// уст_ТП_карЛев_начало ( Каретка левая - начало/Автоматический процесс),   Real, %MD432   reg = M  width = UInt32
    public float get_ust_tp_karlew_nachalo ()
    { return (float) m_mem.getMFloat(432); }

    public void set_ust_tp_karlew_nachalo (float val)
    { m_mem.setMFloat(432, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tp_karlew_nachalo to " + val.ToString());}

    public bool sets_ust_tp_karlew_nachalo ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tp_karlew_nachalo (val);
    return true;}

    public string gets_ust_tp_karlew_nachalo () { 
    return get_ust_tp_karlew_nachalo().ToString();}

    public string debug_name_ust_tp_karlew_nachalo () { 
    return "уст_ТП_карЛев_начало";}

// уст_ТП_карЛев_конец ( Каретка левая - конец/Автоматический процесс),   Real, %MD444   reg = M  width = UInt32
    public float get_ust_tp_karlew_konec ()
    { return (float) m_mem.getMFloat(444); }

    public void set_ust_tp_karlew_konec (float val)
    { m_mem.setMFloat(444, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tp_karlew_konec to " + val.ToString());}

    public bool sets_ust_tp_karlew_konec ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tp_karlew_konec (val);
    return true;}

    public string gets_ust_tp_karlew_konec () { 
    return get_ust_tp_karlew_konec().ToString();}

    public string debug_name_ust_tp_karlew_konec () { 
    return "уст_ТП_карЛев_конец";}

// уст_ТП_толщСлоя ( Толщина слоя/Автоматический процесс),   Real, %MD428   reg = M  width = UInt32
    public float get_ust_tp_tolschsloq ()
    { return (float) m_mem.getMFloat(428); }

    public void set_ust_tp_tolschsloq (float val)
    { m_mem.setMFloat(428, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tp_tolschsloq to " + val.ToString());}

    public bool sets_ust_tp_tolschsloq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tp_tolschsloq (val);
    return true;}

    public string gets_ust_tp_tolschsloq () { 
    return get_ust_tp_tolschsloq().ToString();}

    public string debug_name_ust_tp_tolschsloq () { 
    return "уст_ТП_толщСлоя";}

// уст_ТЭН1_мощн ( Мощность/Нагреватели),   Real, %MD476   reg = M  width = UInt32
    public float get_ust_tjen1_moschn ()
    { return (float) m_mem.getMFloat(476); }

    public void set_ust_tjen1_moschn (float val)
    { m_mem.setMFloat(476, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen1_moschn to " + val.ToString());}

    public bool sets_ust_tjen1_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen1_moschn (val);
    return true;}

    public string gets_ust_tjen1_moschn () { 
    return get_ust_tjen1_moschn().ToString();}

    public string debug_name_ust_tjen1_moschn () { 
    return "уст_ТЭН1_мощн";}

// уст_ТЭН2_мощн ( Мощность/Нагреватели),   Real, %MD480   reg = M  width = UInt32
    public float get_ust_tjen2_moschn ()
    { return (float) m_mem.getMFloat(480); }

    public void set_ust_tjen2_moschn (float val)
    { m_mem.setMFloat(480, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen2_moschn to " + val.ToString());}

    public bool sets_ust_tjen2_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen2_moschn (val);
    return true;}

    public string gets_ust_tjen2_moschn () { 
    return get_ust_tjen2_moschn().ToString();}

    public string debug_name_ust_tjen2_moschn () { 
    return "уст_ТЭН2_мощн";}

// уст_ТЭН3_мощн ( Мощность/Нагреватели),   Real, %MD484   reg = M  width = UInt32
    public float get_ust_tjen3_moschn ()
    { return (float) m_mem.getMFloat(484); }

    public void set_ust_tjen3_moschn (float val)
    { m_mem.setMFloat(484, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tjen3_moschn to " + val.ToString());}

    public bool sets_ust_tjen3_moschn ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tjen3_moschn (val);
    return true;}

    public string gets_ust_tjen3_moschn () { 
    return get_ust_tjen3_moschn().ToString();}

    public string debug_name_ust_tjen3_moschn () { 
    return "уст_ТЭН3_мощн";}

// уст_ТЭН1_темп ( Температура/Нагреватели),   Real, %MD488   reg = M  width = UInt32
    public float get_ust_tjen1_temp ()
    { return (float) m_mem.getMFloat(488); }

    public void set_ust_tjen1_temp (float val)
    { m_mem.setMFloat(488, (float) val); 
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
    return "уст_ТЭН1_темп";}

// уст_ТЭН2_темп ( Температура/Нагреватели),   Real, %MD296   reg = M  width = UInt32
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
    return "уст_ТЭН2_темп";}

// уст_ТЭН3_темп ( Температура/Нагреватели),   Real, %MD300   reg = M  width = UInt32
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
    return "уст_ТЭН3_темп";}

// уст_карЛев_скор ( Каретка левая - скорость/Каретки),   Real, %MD304   reg = M  width = UInt32
    public float get_ust_karlew_skor ()
    { return (float) m_mem.getMFloat(304); }

    public void set_ust_karlew_skor (float val)
    { m_mem.setMFloat(304, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karlew_skor to " + val.ToString());}

    public bool sets_ust_karlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karlew_skor (val);
    return true;}

    public string gets_ust_karlew_skor () { 
    return get_ust_karlew_skor().ToString();}

    public string debug_name_ust_karlew_skor () { 
    return "уст_карЛев_скор";}

// уст_карЛев_отн_раст ( Каретка левая - расстояние/Каретки),   Real, %MD308   reg = M  width = UInt32
    public float get_ust_karlew_otn_rast ()
    { return (float) m_mem.getMFloat(308); }

    public void set_ust_karlew_otn_rast (float val)
    { m_mem.setMFloat(308, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karlew_otn_rast to " + val.ToString());}

    public bool sets_ust_karlew_otn_rast ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karlew_otn_rast (val);
    return true;}

    public string gets_ust_karlew_otn_rast () { 
    return get_ust_karlew_otn_rast().ToString();}

    public string debug_name_ust_karlew_otn_rast () { 
    return "уст_карЛев_отн_раст";}

// уст_карЛев_абс_поз ( Каретка левая - позиция/Каретки),   Real, %MD312   reg = M  width = UInt32
    public float get_ust_karlew_abs_poz ()
    { return (float) m_mem.getMFloat(312); }

    public void set_ust_karlew_abs_poz (float val)
    { m_mem.setMFloat(312, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karlew_abs_poz to " + val.ToString());}

    public bool sets_ust_karlew_abs_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karlew_abs_poz (val);
    return true;}

    public string gets_ust_karlew_abs_poz () { 
    return get_ust_karlew_abs_poz().ToString();}

    public string debug_name_ust_karlew_abs_poz () { 
    return "уст_карЛев_абс_поз";}

// уст_карПрав_скор ( Каретка правая - скорость/Каретки),   Real, %MD316   reg = M  width = UInt32
    public float get_ust_karpraw_skor ()
    { return (float) m_mem.getMFloat(316); }

    public void set_ust_karpraw_skor (float val)
    { m_mem.setMFloat(316, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karpraw_skor to " + val.ToString());}

    public bool sets_ust_karpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karpraw_skor (val);
    return true;}

    public string gets_ust_karpraw_skor () { 
    return get_ust_karpraw_skor().ToString();}

    public string debug_name_ust_karpraw_skor () { 
    return "уст_карПрав_скор";}

// уст_карПрав_отн_раст ( Каретка правая - расстояние/Каретки),   Real, %MD320   reg = M  width = UInt32
    public float get_ust_karpraw_otn_rast ()
    { return (float) m_mem.getMFloat(320); }

    public void set_ust_karpraw_otn_rast (float val)
    { m_mem.setMFloat(320, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karpraw_otn_rast to " + val.ToString());}

    public bool sets_ust_karpraw_otn_rast ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karpraw_otn_rast (val);
    return true;}

    public string gets_ust_karpraw_otn_rast () { 
    return get_ust_karpraw_otn_rast().ToString();}

    public string debug_name_ust_karpraw_otn_rast () { 
    return "уст_карПрав_отн_раст";}

// уст_карПрав_абс_поз ( Каретка правая - позиция/Каретки),   Real, %MD324   reg = M  width = UInt32
    public float get_ust_karpraw_abs_poz ()
    { return (float) m_mem.getMFloat(324); }

    public void set_ust_karpraw_abs_poz (float val)
    { m_mem.setMFloat(324, (float) val); 
      Log.Write(LogLevel.Info, "set ust_karpraw_abs_poz to " + val.ToString());}

    public bool sets_ust_karpraw_abs_poz ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_karpraw_abs_poz (val);
    return true;}

    public string gets_ust_karpraw_abs_poz () { 
    return get_ust_karpraw_abs_poz().ToString();}

    public string debug_name_ust_karpraw_abs_poz () { 
    return "уст_карПрав_абс_поз";}

// уст_барПрав_скор ( Барабан правый - скорость/Барабаны),   Real, %MD328   reg = M  width = UInt32
    public float get_ust_barpraw_skor ()
    { return (float) m_mem.getMFloat(328); }

    public void set_ust_barpraw_skor (float val)
    { m_mem.setMFloat(328, (float) val); 
      Log.Write(LogLevel.Info, "set ust_barpraw_skor to " + val.ToString());}

    public bool sets_ust_barpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_barpraw_skor (val);
    return true;}

    public string gets_ust_barpraw_skor () { 
    return get_ust_barpraw_skor().ToString();}

    public string debug_name_ust_barpraw_skor () { 
    return "уст_барПрав_скор";}

// уст_барЛев_скор ( Барабан левый - скорость/Барабаны),   Real, %MD340   reg = M  width = UInt32
    public float get_ust_barlew_skor ()
    { return (float) m_mem.getMFloat(340); }

    public void set_ust_barlew_skor (float val)
    { m_mem.setMFloat(340, (float) val); 
      Log.Write(LogLevel.Info, "set ust_barlew_skor to " + val.ToString());}

    public bool sets_ust_barlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_barlew_skor (val);
    return true;}

    public string gets_ust_barlew_skor () { 
    return get_ust_barlew_skor().ToString();}

    public string debug_name_ust_barlew_skor () { 
    return "уст_барЛев_скор";}

// уст_дозЛев_время ( Дозатор левый - время/Дозаторы),   Real, %MD352   reg = M  width = UInt32
    public float get_ust_dozlew_wremq ()
    { return (float) m_mem.getMFloat(352); }

    public void set_ust_dozlew_wremq (float val)
    { m_mem.setMFloat(352, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozlew_wremq to " + val.ToString());}

    public bool sets_ust_dozlew_wremq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozlew_wremq (val);
    return true;}

    public string gets_ust_dozlew_wremq () { 
    return get_ust_dozlew_wremq().ToString();}

    public string debug_name_ust_dozlew_wremq () { 
    return "уст_дозЛев_время";}

// уст_дозПрав_время ( Дозатор правый - время/Дозаторы),   Real, %MD356   reg = M  width = UInt32
    public float get_ust_dozpraw_wremq ()
    { return (float) m_mem.getMFloat(356); }

    public void set_ust_dozpraw_wremq (float val)
    { m_mem.setMFloat(356, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozpraw_wremq to " + val.ToString());}

    public bool sets_ust_dozpraw_wremq ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozpraw_wremq (val);
    return true;}

    public string gets_ust_dozpraw_wremq () { 
    return get_ust_dozpraw_wremq().ToString();}

    public string debug_name_ust_dozpraw_wremq () { 
    return "уст_дозПрав_время";}

// уст_толкЛев_расст ( Толкатель левый - расстояние/Толкатели),   Real, %MD360   reg = M  width = UInt32
    public float get_ust_tolklew_rasst ()
    { return (float) m_mem.getMFloat(360); }

    public void set_ust_tolklew_rasst (float val)
    { m_mem.setMFloat(360, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolklew_rasst to " + val.ToString());}

    public bool sets_ust_tolklew_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolklew_rasst (val);
    return true;}

    public string gets_ust_tolklew_rasst () { 
    return get_ust_tolklew_rasst().ToString();}

    public string debug_name_ust_tolklew_rasst () { 
    return "уст_толкЛев_расст";}

// уст_толкПрав_расст ( Толкатель правый - расстояние/Толкатели),   Real, %MD364   reg = M  width = UInt32
    public float get_ust_tolkpraw_rasst ()
    { return (float) m_mem.getMFloat(364); }

    public void set_ust_tolkpraw_rasst (float val)
    { m_mem.setMFloat(364, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolkpraw_rasst to " + val.ToString());}

    public bool sets_ust_tolkpraw_rasst ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolkpraw_rasst (val);
    return true;}

    public string gets_ust_tolkpraw_rasst () { 
    return get_ust_tolkpraw_rasst().ToString();}

    public string debug_name_ust_tolkpraw_rasst () { 
    return "уст_толкПрав_расст";}

// уст_дозПрав_скор ( Дозатор правый - скорость/Дозаторы),   Real, %MD368   reg = M  width = UInt32
    public float get_ust_dozpraw_skor ()
    { return (float) m_mem.getMFloat(368); }

    public void set_ust_dozpraw_skor (float val)
    { m_mem.setMFloat(368, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozpraw_skor to " + val.ToString());}

    public bool sets_ust_dozpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozpraw_skor (val);
    return true;}

    public string gets_ust_dozpraw_skor () { 
    return get_ust_dozpraw_skor().ToString();}

    public string debug_name_ust_dozpraw_skor () { 
    return "уст_дозПрав_скор";}

// уст_дозЛев_скор ( Дозатор левый - скорость/Дозаторы),   Real, %MD372   reg = M  width = UInt32
    public float get_ust_dozlew_skor ()
    { return (float) m_mem.getMFloat(372); }

    public void set_ust_dozlew_skor (float val)
    { m_mem.setMFloat(372, (float) val); 
      Log.Write(LogLevel.Info, "set ust_dozlew_skor to " + val.ToString());}

    public bool sets_ust_dozlew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_dozlew_skor (val);
    return true;}

    public string gets_ust_dozlew_skor () { 
    return get_ust_dozlew_skor().ToString();}

    public string debug_name_ust_dozlew_skor () { 
    return "уст_дозЛев_скор";}

// уст_толкЛев_скор ( Толкатель левый - скорость/Толкатели),   Real, %MD376   reg = M  width = UInt32
    public float get_ust_tolklew_skor ()
    { return (float) m_mem.getMFloat(376); }

    public void set_ust_tolklew_skor (float val)
    { m_mem.setMFloat(376, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolklew_skor to " + val.ToString());}

    public bool sets_ust_tolklew_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolklew_skor (val);
    return true;}

    public string gets_ust_tolklew_skor () { 
    return get_ust_tolklew_skor().ToString();}

    public string debug_name_ust_tolklew_skor () { 
    return "уст_толкЛев_скор";}

// уст_толкПрав_скор ( Толкатель правый - скорость/Толкатели),   Real, %MD380   reg = M  width = UInt32
    public float get_ust_tolkpraw_skor ()
    { return (float) m_mem.getMFloat(380); }

    public void set_ust_tolkpraw_skor (float val)
    { m_mem.setMFloat(380, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tolkpraw_skor to " + val.ToString());}

    public bool sets_ust_tolkpraw_skor ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tolkpraw_skor (val);
    return true;}

    public string gets_ust_tolkpraw_skor () { 
    return get_ust_tolkpraw_skor().ToString();}

    public string debug_name_ust_tolkpraw_skor () { 
    return "уст_толкПрав_скор";}

// уст_ТП_карПрав_начало ( Каретка правая - начало/Автоматический процесс),   Real, %MD452   reg = M  width = UInt32
    public float get_ust_tp_karpraw_nachalo ()
    { return (float) m_mem.getMFloat(452); }

    public void set_ust_tp_karpraw_nachalo (float val)
    { m_mem.setMFloat(452, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tp_karpraw_nachalo to " + val.ToString());}

    public bool sets_ust_tp_karpraw_nachalo ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tp_karpraw_nachalo (val);
    return true;}

    public string gets_ust_tp_karpraw_nachalo () { 
    return get_ust_tp_karpraw_nachalo().ToString();}

    public string debug_name_ust_tp_karpraw_nachalo () { 
    return "уст_ТП_карПрав_начало";}

// уст_ТП_карПрав_конец ( Каретка правая - конец/Автоматический процесс),   Real, %MD456   reg = M  width = UInt32
    public float get_ust_tp_karpraw_konec ()
    { return (float) m_mem.getMFloat(456); }

    public void set_ust_tp_karpraw_konec (float val)
    { m_mem.setMFloat(456, (float) val); 
      Log.Write(LogLevel.Info, "set ust_tp_karpraw_konec to " + val.ToString());}

    public bool sets_ust_tp_karpraw_konec ( string str) {
    float val;
    if (!float.TryParse(str, out val)){
        System.Windows.MessageBox.Show("Failed on try parse " + str + " as float ");
        return false; }
    set_ust_tp_karpraw_konec (val);
    return true;}

    public string gets_ust_tp_karpraw_konec () { 
    return get_ust_tp_karpraw_konec().ToString();}

    public string debug_name_ust_tp_karpraw_konec () { 
    return "уст_ТП_карПрав_конец";}

public enum local_usta{
ust_stol_abs_poz,
ust_stol_skor,
ust_stol_otn_rasst,
ust_tp_karlew_nachalo,
ust_tp_karlew_konec,
ust_tp_tolschsloq,
ust_tjen1_moschn,
ust_tjen2_moschn,
ust_tjen3_moschn,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
ust_karlew_skor,
ust_karlew_otn_rast,
ust_karlew_abs_poz,
ust_karpraw_skor,
ust_karpraw_otn_rast,
ust_karpraw_abs_poz,
ust_barpraw_skor,
ust_barlew_skor,
ust_dozlew_wremq,
ust_dozpraw_wremq,
ust_tolklew_rasst,
ust_tolkpraw_rasst,
ust_dozpraw_skor,
ust_dozlew_skor,
ust_tolklew_skor,
ust_tolkpraw_skor,
ust_tp_karpraw_nachalo,
ust_tp_karpraw_konec,
};

public gTags[] group_usta = {
gTags.ust_stol_abs_poz,
gTags.ust_stol_skor,
gTags.ust_stol_otn_rasst,
gTags.ust_tp_karlew_nachalo,
gTags.ust_tp_karlew_konec,
gTags.ust_tp_tolschsloq,
gTags.ust_tjen1_moschn,
gTags.ust_tjen2_moschn,
gTags.ust_tjen3_moschn,
gTags.ust_tjen1_temp,
gTags.ust_tjen2_temp,
gTags.ust_tjen3_temp,
gTags.ust_karlew_skor,
gTags.ust_karlew_otn_rast,
gTags.ust_karlew_abs_poz,
gTags.ust_karpraw_skor,
gTags.ust_karpraw_otn_rast,
gTags.ust_karpraw_abs_poz,
gTags.ust_barpraw_skor,
gTags.ust_barlew_skor,
gTags.ust_dozlew_wremq,
gTags.ust_dozpraw_wremq,
gTags.ust_tolklew_rasst,
gTags.ust_tolkpraw_rasst,
gTags.ust_dozpraw_skor,
gTags.ust_dozlew_skor,
gTags.ust_tolklew_skor,
gTags.ust_tolkpraw_skor,
gTags.ust_tp_karpraw_nachalo,
gTags.ust_tp_karpraw_konec,
};

public enum gTags{
am_termopara1,
am_dif_datch_rash,
am_dawl_lew_fil_tr,
am_dawl_praw_fil_tr,
am_linejka,
am_tjen1_tek_moschn,
am_kar_lew_tek_poz,
am_stol_tek_poz,
am_temp1,
am_temp2,
am_temp3,
am_temp4,
am_temp5,
am_temp6,
am_datch_kisl1,
am_datch_kisl2,
am_kar_praw_tek_poz,
am_dawl_w_kamere,
am_ohl_skan1,
am_ohl_skan2,
wyhd_stol_abs,
wyhd_tjen1_pit,
wyhd_tjen2_pit,
wyhd_tjen3_pit,
wyhd_stol_otn_wniz,
wyhd_stol_otn_wwerh,
wyhd_laz_pit1,
wyhd_pitchil1,
wyhd_pitchil2,
wyhd_klchil1,
wyhd_klchil2,
wyhd_pitmps,
wyhd_pitrec,
wyhd_kv1,
wyhd_kv2,
wyhd_kje9,
wyhd_kje10,
wyhd_karpraw_abs,
wyhd_karlew_abs,
wyhd_dozpraw_wper,
wyhd_dozlew_wper,
wyhd_dozpraw_nazad,
wyhd_dozlew_nazad,
wyhd_stol_peresch_t,
wyhd_barlew_wper_d,
wyhd_barpraw_wper_d,
wyhd_barlew_nazad,
wyhd_barpraw_nazad,
wyhd_tolklew_wper_d,
wyhd_tolkpraw_wper_d,
wyhd_tolklew_nazad,
wyhd_tolkpraw_nazad,
wyhd_karpraw_otn_wper_d,
wyhd_karpraw_otn_nazad,
wyhd_karlew_otn_wper_d,
wyhd_karlew_otn_nazad,
wyhd_klbarlew,
wyhd_klbarpraw,
wyhd_nasotkgaza,
wyhd_tp_sloj,
wyhd_tp_process,
wyhd_laz_pit2,
dm_stol_abs_domgot,
dm_rashod1_1,
dm_rashod1_2,
dm_rashod2_1,
dm_rashod2_2,
dm_prot1,
dm_prot2,
dm_prot3,
dm_prot4,
dm_prot5,
dm_prot6,
dm_karpraw_konc,
dm_karlew_konc,
kom_stol_abs,
kom_tp_prer,
kom_stol_stop,
kom_stol_ustnulq,
kom_stol_otn_wniz,
kom_stol_otn_wwerh,
kom_tp_sloj,
kom_stol_obnulit_linejku,
kom_tjen3,
kom_tjen1,
kom_tjen2,
kom_tp_process,
kom_stol_peresch_t,
kom_laz_pit1,
kom_laz_got1,
kom_tp_pauza,
kom_pitchil1,
kom_pitchil2,
kom_klchil1,
kom_klchil2,
kom_pitrec,
kom_pitmps,
kom_karlew_otn_wper_d,
kom_karlew_otn_nazad,
kom_karlew_abs,
kom_karpraw_otn_wper_d,
kom_karpraw_otn_nazad,
kom_karpraw_abs,
kom_barpraw_wper_d,
kom_barpraw_nazad,
kom_barlew_wper_d,
kom_barlew_nazad,
kom_dozlew_wper,
kom_dozpraw_wper,
kom_tolklew_wper_d,
kom_tolklew_nazad,
kom_tolkpraw_wper_d,
kom_tolkpraw_nazad,
kom_dozlew_nazad,
kom_dozpraw_nazad,
kom_kje9_ohl_skan1,
kom_kje10_ohl_skan2,
kom_kv1,
kom_kv2,
kom_klbarlew,
kom_klbarpraw,
kom_nasotkgaza,
kom_barlew_stop,
kom_barpraw_stop,
kom_dozlew_stop,
kom_dozpraw_stop,
kom_karlew_stop,
kom_karpraw_stop,
kom_laz_got2,
kom_laz_pit2,
ust_stol_abs_poz,
ust_stol_skor,
ust_stol_otn_rasst,
ust_tp_karlew_nachalo,
ust_tp_karlew_konec,
ust_tp_tolschsloq,
ust_tjen1_moschn,
ust_tjen2_moschn,
ust_tjen3_moschn,
ust_tjen1_temp,
ust_tjen2_temp,
ust_tjen3_temp,
ust_karlew_skor,
ust_karlew_otn_rast,
ust_karlew_abs_poz,
ust_karpraw_skor,
ust_karpraw_otn_rast,
ust_karpraw_abs_poz,
ust_barpraw_skor,
ust_barlew_skor,
ust_dozlew_wremq,
ust_dozpraw_wremq,
ust_tolklew_rasst,
ust_tolkpraw_rasst,
ust_dozpraw_skor,
ust_dozlew_skor,
ust_tolklew_skor,
ust_tolkpraw_skor,
ust_tp_karpraw_nachalo,
ust_tp_karpraw_konec,
lastGTag,
separator,
};

public string [] debugNames = {
" Температура1",
" Диф датчик расхода",
" Давление левый фильтр",
" Давление правый фильтр",
" Линейка",
" ТЭН1текущая мощность",
" Каретка левая тек позиция",
" тек позиция",
" Температура1",
" Температура2",
" Температура3",
" Температура4",
" Температура5",
" Температура6",
" Кислород1",
" Кмслород2",
" Каретка правая тек позиция",
" Давление в камере",
" Расход возд скан1",
" Расход возд скан2",
" Позиция",
" ТЭН1",
" ТЭН2",
" ТЭН3",
" Вниз",
" Вверх",
" Питание лазера1",
" Питание чиллера1",
" Питание чиллера2",
" Клапаны чиллера1",
" Клапаны чиллера2",
" Питание МПС",
" Насос - улитка",
" КВ1",
" КВ2",
" КЭ9",
" КЭ10",
" Каретка правая - позиция",
" Каретка левая - позиция",
" Дозатор правый - вперёд",
" Дозатор левый - вперёд",
" Дозатор правый - назад",
" Дозатор левый - назад",
" Пересчёт",
" Барабан левый - вперёд",
" Барабан правый - вперёд",
" Барабан левый - назад",
" Барабан правый - назад",
" Толкатель левый - вперёд",
" Толкатель правый - вперёд",
" Толкатель левый - назад",
" Толкатель правый - назад",
" Каретка правая - вперёд",
" Каретка правая - назад",
" Каретка левая - вперёд",
" Каретка левая - назад",
" Клапан барабана левого",
" Клапан барабана правого",
" Насос",
" Слой",
" Процесс",
" Питание лазера2",
" Ноль установлен",
" Расход1-1",
" Расход1-2",
" Расход2-1",
" Расход2-2",
" Проток1",
" Проток2",
" Проток3",
" Проток4",
" Проток5",
" Проток6",
" Каретка правая- концевик",
" Каретка левая- концевик",
" Позиция",
" Прерывание",
" Стоп",
" Установить ноль",
" Вниз",
" Вверх",
" Слой",
" Обнулить линейку",
" ТЭН3",
" ТЭН1",
" ТЭН2",
" Процесс",
" Пересчёт",
" Питание лазера1",
" Готовностть1",
" Пауза",
" Питание чиллера1",
" Питание чиллера2",
" Клапаны чиллера1",
" Клапаны чиллера2",
" Насос - улитка",
" Питание МПС",
" Каретка левая - вперёд",
" Каретка левая - назад",
" Каретка левая - позиция",
" Каретка правая - вперёд",
" Каретка правая - назад",
" Каретка правая - позиция",
" Барабан правый - вперёд",
" Барабан правый - назад",
" Барабан левый - вперёд",
" Барабан левый - назад",
" Дозатор левый - вперёд",
" Дозатор правый - вперёд",
" Толкатель левый - вперёд",
" Толкатель левый - назад",
" Толкатель правый - вперёд",
" Толкатель правый - назад",
" Дозатор левый - назад",
" Дозатор правый - назад",
" КЭ9 Клапан охл скан1",
" КЭ10 Клапан охл скан2",
" КВ1",
" КВ2",
" Клапан барабана левого",
" Клапан барабана правого",
" Насос",
" Барабан левый - стоп",
" Барабан правый - стоп",
" Дозатор левый - стоп",
" Дозатор правый - стоп",
" Каретка левая - стоп",
" Каретка правая - стоп",
" Готовностть2",
" Питание лазера2",
" Позиция",
" Скорость",
" Расстояние",
" Каретка левая - начало",
" Каретка левая - конец",
" Толщина слоя",
" Мощность",
" Мощность",
" Мощность",
" Температура",
" Температура",
" Температура",
" Каретка левая - скорость",
" Каретка левая - расстояние",
" Каретка левая - позиция",
" Каретка правая - скорость",
" Каретка правая - расстояние",
" Каретка правая - позиция",
" Барабан правый - скорость",
" Барабан левый - скорость",
" Дозатор левый - время",
" Дозатор правый - время",
" Толкатель левый - расстояние",
" Толкатель правый - расстояние",
" Дозатор правый - скорость",
" Дозатор левый - скорость",
" Толкатель левый - скорость",
" Толкатель правый - скорость",
" Каретка правая - начало",
" Каретка правая - конец",
};

public string getDebugName(gTags tag) {return debugNames[(int)tag];}

 Func<string>[] sGetters  = new Func<string>[(int)gTags.lastGTag];
public string getSValue(gTags tag) { return sGetters[(int)tag]();}
public void init_sGetters () {
sGetters[(int)gTags.am_termopara1] =  gets_am_termopara1;
sGetters[(int)gTags.am_dif_datch_rash] =  gets_am_dif_datch_rash;
sGetters[(int)gTags.am_dawl_lew_fil_tr] =  gets_am_dawl_lew_fil_tr;
sGetters[(int)gTags.am_dawl_praw_fil_tr] =  gets_am_dawl_praw_fil_tr;
sGetters[(int)gTags.am_linejka] =  gets_am_linejka;
sGetters[(int)gTags.am_tjen1_tek_moschn] =  gets_am_tjen1_tek_moschn;
sGetters[(int)gTags.am_kar_lew_tek_poz] =  gets_am_kar_lew_tek_poz;
sGetters[(int)gTags.am_stol_tek_poz] =  gets_am_stol_tek_poz;
sGetters[(int)gTags.am_temp1] =  gets_am_temp1;
sGetters[(int)gTags.am_temp2] =  gets_am_temp2;
sGetters[(int)gTags.am_temp3] =  gets_am_temp3;
sGetters[(int)gTags.am_temp4] =  gets_am_temp4;
sGetters[(int)gTags.am_temp5] =  gets_am_temp5;
sGetters[(int)gTags.am_temp6] =  gets_am_temp6;
sGetters[(int)gTags.am_datch_kisl1] =  gets_am_datch_kisl1;
sGetters[(int)gTags.am_datch_kisl2] =  gets_am_datch_kisl2;
sGetters[(int)gTags.am_kar_praw_tek_poz] =  gets_am_kar_praw_tek_poz;
sGetters[(int)gTags.am_dawl_w_kamere] =  gets_am_dawl_w_kamere;
sGetters[(int)gTags.am_ohl_skan1] =  gets_am_ohl_skan1;
sGetters[(int)gTags.am_ohl_skan2] =  gets_am_ohl_skan2;
sGetters[(int)gTags.wyhd_stol_abs] =  gets_wyhd_stol_abs;
sGetters[(int)gTags.wyhd_tjen1_pit] =  gets_wyhd_tjen1_pit;
sGetters[(int)gTags.wyhd_tjen2_pit] =  gets_wyhd_tjen2_pit;
sGetters[(int)gTags.wyhd_tjen3_pit] =  gets_wyhd_tjen3_pit;
sGetters[(int)gTags.wyhd_stol_otn_wniz] =  gets_wyhd_stol_otn_wniz;
sGetters[(int)gTags.wyhd_stol_otn_wwerh] =  gets_wyhd_stol_otn_wwerh;
sGetters[(int)gTags.wyhd_laz_pit1] =  gets_wyhd_laz_pit1;
sGetters[(int)gTags.wyhd_pitchil1] =  gets_wyhd_pitchil1;
sGetters[(int)gTags.wyhd_pitchil2] =  gets_wyhd_pitchil2;
sGetters[(int)gTags.wyhd_klchil1] =  gets_wyhd_klchil1;
sGetters[(int)gTags.wyhd_klchil2] =  gets_wyhd_klchil2;
sGetters[(int)gTags.wyhd_pitmps] =  gets_wyhd_pitmps;
sGetters[(int)gTags.wyhd_pitrec] =  gets_wyhd_pitrec;
sGetters[(int)gTags.wyhd_kv1] =  gets_wyhd_kv1;
sGetters[(int)gTags.wyhd_kv2] =  gets_wyhd_kv2;
sGetters[(int)gTags.wyhd_kje9] =  gets_wyhd_kje9;
sGetters[(int)gTags.wyhd_kje10] =  gets_wyhd_kje10;
sGetters[(int)gTags.wyhd_karpraw_abs] =  gets_wyhd_karpraw_abs;
sGetters[(int)gTags.wyhd_karlew_abs] =  gets_wyhd_karlew_abs;
sGetters[(int)gTags.wyhd_dozpraw_wper] =  gets_wyhd_dozpraw_wper;
sGetters[(int)gTags.wyhd_dozlew_wper] =  gets_wyhd_dozlew_wper;
sGetters[(int)gTags.wyhd_dozpraw_nazad] =  gets_wyhd_dozpraw_nazad;
sGetters[(int)gTags.wyhd_dozlew_nazad] =  gets_wyhd_dozlew_nazad;
sGetters[(int)gTags.wyhd_stol_peresch_t] =  gets_wyhd_stol_peresch_t;
sGetters[(int)gTags.wyhd_barlew_wper_d] =  gets_wyhd_barlew_wper_d;
sGetters[(int)gTags.wyhd_barpraw_wper_d] =  gets_wyhd_barpraw_wper_d;
sGetters[(int)gTags.wyhd_barlew_nazad] =  gets_wyhd_barlew_nazad;
sGetters[(int)gTags.wyhd_barpraw_nazad] =  gets_wyhd_barpraw_nazad;
sGetters[(int)gTags.wyhd_tolklew_wper_d] =  gets_wyhd_tolklew_wper_d;
sGetters[(int)gTags.wyhd_tolkpraw_wper_d] =  gets_wyhd_tolkpraw_wper_d;
sGetters[(int)gTags.wyhd_tolklew_nazad] =  gets_wyhd_tolklew_nazad;
sGetters[(int)gTags.wyhd_tolkpraw_nazad] =  gets_wyhd_tolkpraw_nazad;
sGetters[(int)gTags.wyhd_karpraw_otn_wper_d] =  gets_wyhd_karpraw_otn_wper_d;
sGetters[(int)gTags.wyhd_karpraw_otn_nazad] =  gets_wyhd_karpraw_otn_nazad;
sGetters[(int)gTags.wyhd_karlew_otn_wper_d] =  gets_wyhd_karlew_otn_wper_d;
sGetters[(int)gTags.wyhd_karlew_otn_nazad] =  gets_wyhd_karlew_otn_nazad;
sGetters[(int)gTags.wyhd_klbarlew] =  gets_wyhd_klbarlew;
sGetters[(int)gTags.wyhd_klbarpraw] =  gets_wyhd_klbarpraw;
sGetters[(int)gTags.wyhd_nasotkgaza] =  gets_wyhd_nasotkgaza;
sGetters[(int)gTags.wyhd_tp_sloj] =  gets_wyhd_tp_sloj;
sGetters[(int)gTags.wyhd_tp_process] =  gets_wyhd_tp_process;
sGetters[(int)gTags.wyhd_laz_pit2] =  gets_wyhd_laz_pit2;
sGetters[(int)gTags.dm_stol_abs_domgot] =  gets_dm_stol_abs_domgot;
sGetters[(int)gTags.dm_rashod1_1] =  gets_dm_rashod1_1;
sGetters[(int)gTags.dm_rashod1_2] =  gets_dm_rashod1_2;
sGetters[(int)gTags.dm_rashod2_1] =  gets_dm_rashod2_1;
sGetters[(int)gTags.dm_rashod2_2] =  gets_dm_rashod2_2;
sGetters[(int)gTags.dm_prot1] =  gets_dm_prot1;
sGetters[(int)gTags.dm_prot2] =  gets_dm_prot2;
sGetters[(int)gTags.dm_prot3] =  gets_dm_prot3;
sGetters[(int)gTags.dm_prot4] =  gets_dm_prot4;
sGetters[(int)gTags.dm_prot5] =  gets_dm_prot5;
sGetters[(int)gTags.dm_prot6] =  gets_dm_prot6;
sGetters[(int)gTags.dm_karpraw_konc] =  gets_dm_karpraw_konc;
sGetters[(int)gTags.dm_karlew_konc] =  gets_dm_karlew_konc;
sGetters[(int)gTags.kom_stol_abs] =  gets_kom_stol_abs;
sGetters[(int)gTags.kom_tp_prer] =  gets_kom_tp_prer;
sGetters[(int)gTags.kom_stol_stop] =  gets_kom_stol_stop;
sGetters[(int)gTags.kom_stol_ustnulq] =  gets_kom_stol_ustnulq;
sGetters[(int)gTags.kom_stol_otn_wniz] =  gets_kom_stol_otn_wniz;
sGetters[(int)gTags.kom_stol_otn_wwerh] =  gets_kom_stol_otn_wwerh;
sGetters[(int)gTags.kom_tp_sloj] =  gets_kom_tp_sloj;
sGetters[(int)gTags.kom_stol_obnulit_linejku] =  gets_kom_stol_obnulit_linejku;
sGetters[(int)gTags.kom_tjen3] =  gets_kom_tjen3;
sGetters[(int)gTags.kom_tjen1] =  gets_kom_tjen1;
sGetters[(int)gTags.kom_tjen2] =  gets_kom_tjen2;
sGetters[(int)gTags.kom_tp_process] =  gets_kom_tp_process;
sGetters[(int)gTags.kom_stol_peresch_t] =  gets_kom_stol_peresch_t;
sGetters[(int)gTags.kom_laz_pit1] =  gets_kom_laz_pit1;
sGetters[(int)gTags.kom_laz_got1] =  gets_kom_laz_got1;
sGetters[(int)gTags.kom_tp_pauza] =  gets_kom_tp_pauza;
sGetters[(int)gTags.kom_pitchil1] =  gets_kom_pitchil1;
sGetters[(int)gTags.kom_pitchil2] =  gets_kom_pitchil2;
sGetters[(int)gTags.kom_klchil1] =  gets_kom_klchil1;
sGetters[(int)gTags.kom_klchil2] =  gets_kom_klchil2;
sGetters[(int)gTags.kom_pitrec] =  gets_kom_pitrec;
sGetters[(int)gTags.kom_pitmps] =  gets_kom_pitmps;
sGetters[(int)gTags.kom_karlew_otn_wper_d] =  gets_kom_karlew_otn_wper_d;
sGetters[(int)gTags.kom_karlew_otn_nazad] =  gets_kom_karlew_otn_nazad;
sGetters[(int)gTags.kom_karlew_abs] =  gets_kom_karlew_abs;
sGetters[(int)gTags.kom_karpraw_otn_wper_d] =  gets_kom_karpraw_otn_wper_d;
sGetters[(int)gTags.kom_karpraw_otn_nazad] =  gets_kom_karpraw_otn_nazad;
sGetters[(int)gTags.kom_karpraw_abs] =  gets_kom_karpraw_abs;
sGetters[(int)gTags.kom_barpraw_wper_d] =  gets_kom_barpraw_wper_d;
sGetters[(int)gTags.kom_barpraw_nazad] =  gets_kom_barpraw_nazad;
sGetters[(int)gTags.kom_barlew_wper_d] =  gets_kom_barlew_wper_d;
sGetters[(int)gTags.kom_barlew_nazad] =  gets_kom_barlew_nazad;
sGetters[(int)gTags.kom_dozlew_wper] =  gets_kom_dozlew_wper;
sGetters[(int)gTags.kom_dozpraw_wper] =  gets_kom_dozpraw_wper;
sGetters[(int)gTags.kom_tolklew_wper_d] =  gets_kom_tolklew_wper_d;
sGetters[(int)gTags.kom_tolklew_nazad] =  gets_kom_tolklew_nazad;
sGetters[(int)gTags.kom_tolkpraw_wper_d] =  gets_kom_tolkpraw_wper_d;
sGetters[(int)gTags.kom_tolkpraw_nazad] =  gets_kom_tolkpraw_nazad;
sGetters[(int)gTags.kom_dozlew_nazad] =  gets_kom_dozlew_nazad;
sGetters[(int)gTags.kom_dozpraw_nazad] =  gets_kom_dozpraw_nazad;
sGetters[(int)gTags.kom_kje9_ohl_skan1] =  gets_kom_kje9_ohl_skan1;
sGetters[(int)gTags.kom_kje10_ohl_skan2] =  gets_kom_kje10_ohl_skan2;
sGetters[(int)gTags.kom_kv1] =  gets_kom_kv1;
sGetters[(int)gTags.kom_kv2] =  gets_kom_kv2;
sGetters[(int)gTags.kom_klbarlew] =  gets_kom_klbarlew;
sGetters[(int)gTags.kom_klbarpraw] =  gets_kom_klbarpraw;
sGetters[(int)gTags.kom_nasotkgaza] =  gets_kom_nasotkgaza;
sGetters[(int)gTags.kom_barlew_stop] =  gets_kom_barlew_stop;
sGetters[(int)gTags.kom_barpraw_stop] =  gets_kom_barpraw_stop;
sGetters[(int)gTags.kom_dozlew_stop] =  gets_kom_dozlew_stop;
sGetters[(int)gTags.kom_dozpraw_stop] =  gets_kom_dozpraw_stop;
sGetters[(int)gTags.kom_karlew_stop] =  gets_kom_karlew_stop;
sGetters[(int)gTags.kom_karpraw_stop] =  gets_kom_karpraw_stop;
sGetters[(int)gTags.kom_laz_got2] =  gets_kom_laz_got2;
sGetters[(int)gTags.kom_laz_pit2] =  gets_kom_laz_pit2;
sGetters[(int)gTags.ust_stol_abs_poz] =  gets_ust_stol_abs_poz;
sGetters[(int)gTags.ust_stol_skor] =  gets_ust_stol_skor;
sGetters[(int)gTags.ust_stol_otn_rasst] =  gets_ust_stol_otn_rasst;
sGetters[(int)gTags.ust_tp_karlew_nachalo] =  gets_ust_tp_karlew_nachalo;
sGetters[(int)gTags.ust_tp_karlew_konec] =  gets_ust_tp_karlew_konec;
sGetters[(int)gTags.ust_tp_tolschsloq] =  gets_ust_tp_tolschsloq;
sGetters[(int)gTags.ust_tjen1_moschn] =  gets_ust_tjen1_moschn;
sGetters[(int)gTags.ust_tjen2_moschn] =  gets_ust_tjen2_moschn;
sGetters[(int)gTags.ust_tjen3_moschn] =  gets_ust_tjen3_moschn;
sGetters[(int)gTags.ust_tjen1_temp] =  gets_ust_tjen1_temp;
sGetters[(int)gTags.ust_tjen2_temp] =  gets_ust_tjen2_temp;
sGetters[(int)gTags.ust_tjen3_temp] =  gets_ust_tjen3_temp;
sGetters[(int)gTags.ust_karlew_skor] =  gets_ust_karlew_skor;
sGetters[(int)gTags.ust_karlew_otn_rast] =  gets_ust_karlew_otn_rast;
sGetters[(int)gTags.ust_karlew_abs_poz] =  gets_ust_karlew_abs_poz;
sGetters[(int)gTags.ust_karpraw_skor] =  gets_ust_karpraw_skor;
sGetters[(int)gTags.ust_karpraw_otn_rast] =  gets_ust_karpraw_otn_rast;
sGetters[(int)gTags.ust_karpraw_abs_poz] =  gets_ust_karpraw_abs_poz;
sGetters[(int)gTags.ust_barpraw_skor] =  gets_ust_barpraw_skor;
sGetters[(int)gTags.ust_barlew_skor] =  gets_ust_barlew_skor;
sGetters[(int)gTags.ust_dozlew_wremq] =  gets_ust_dozlew_wremq;
sGetters[(int)gTags.ust_dozpraw_wremq] =  gets_ust_dozpraw_wremq;
sGetters[(int)gTags.ust_tolklew_rasst] =  gets_ust_tolklew_rasst;
sGetters[(int)gTags.ust_tolkpraw_rasst] =  gets_ust_tolkpraw_rasst;
sGetters[(int)gTags.ust_dozpraw_skor] =  gets_ust_dozpraw_skor;
sGetters[(int)gTags.ust_dozlew_skor] =  gets_ust_dozlew_skor;
sGetters[(int)gTags.ust_tolklew_skor] =  gets_ust_tolklew_skor;
sGetters[(int)gTags.ust_tolkpraw_skor] =  gets_ust_tolkpraw_skor;
sGetters[(int)gTags.ust_tp_karpraw_nachalo] =  gets_ust_tp_karpraw_nachalo;
sGetters[(int)gTags.ust_tp_karpraw_konec] =  gets_ust_tp_karpraw_konec;
}

Func<string, bool>[] sSetters = new Func<string, bool>[(int)gTags.lastGTag];
public bool setSValue(gTags tag, string val) { return sSetters[(int)tag](val); }
public void init_sSetters () {
sSetters[(int)gTags.am_termopara1] =  sets_am_termopara1;
sSetters[(int)gTags.am_dif_datch_rash] =  sets_am_dif_datch_rash;
sSetters[(int)gTags.am_dawl_lew_fil_tr] =  sets_am_dawl_lew_fil_tr;
sSetters[(int)gTags.am_dawl_praw_fil_tr] =  sets_am_dawl_praw_fil_tr;
sSetters[(int)gTags.am_linejka] =  sets_am_linejka;
sSetters[(int)gTags.am_tjen1_tek_moschn] =  sets_am_tjen1_tek_moschn;
sSetters[(int)gTags.am_kar_lew_tek_poz] =  sets_am_kar_lew_tek_poz;
sSetters[(int)gTags.am_stol_tek_poz] =  sets_am_stol_tek_poz;
sSetters[(int)gTags.am_temp1] =  sets_am_temp1;
sSetters[(int)gTags.am_temp2] =  sets_am_temp2;
sSetters[(int)gTags.am_temp3] =  sets_am_temp3;
sSetters[(int)gTags.am_temp4] =  sets_am_temp4;
sSetters[(int)gTags.am_temp5] =  sets_am_temp5;
sSetters[(int)gTags.am_temp6] =  sets_am_temp6;
sSetters[(int)gTags.am_datch_kisl1] =  sets_am_datch_kisl1;
sSetters[(int)gTags.am_datch_kisl2] =  sets_am_datch_kisl2;
sSetters[(int)gTags.am_kar_praw_tek_poz] =  sets_am_kar_praw_tek_poz;
sSetters[(int)gTags.am_dawl_w_kamere] =  sets_am_dawl_w_kamere;
sSetters[(int)gTags.am_ohl_skan1] =  sets_am_ohl_skan1;
sSetters[(int)gTags.am_ohl_skan2] =  sets_am_ohl_skan2;
sSetters[(int)gTags.wyhd_stol_abs] =  sets_wyhd_stol_abs;
sSetters[(int)gTags.wyhd_tjen1_pit] =  sets_wyhd_tjen1_pit;
sSetters[(int)gTags.wyhd_tjen2_pit] =  sets_wyhd_tjen2_pit;
sSetters[(int)gTags.wyhd_tjen3_pit] =  sets_wyhd_tjen3_pit;
sSetters[(int)gTags.wyhd_stol_otn_wniz] =  sets_wyhd_stol_otn_wniz;
sSetters[(int)gTags.wyhd_stol_otn_wwerh] =  sets_wyhd_stol_otn_wwerh;
sSetters[(int)gTags.wyhd_laz_pit1] =  sets_wyhd_laz_pit1;
sSetters[(int)gTags.wyhd_pitchil1] =  sets_wyhd_pitchil1;
sSetters[(int)gTags.wyhd_pitchil2] =  sets_wyhd_pitchil2;
sSetters[(int)gTags.wyhd_klchil1] =  sets_wyhd_klchil1;
sSetters[(int)gTags.wyhd_klchil2] =  sets_wyhd_klchil2;
sSetters[(int)gTags.wyhd_pitmps] =  sets_wyhd_pitmps;
sSetters[(int)gTags.wyhd_pitrec] =  sets_wyhd_pitrec;
sSetters[(int)gTags.wyhd_kv1] =  sets_wyhd_kv1;
sSetters[(int)gTags.wyhd_kv2] =  sets_wyhd_kv2;
sSetters[(int)gTags.wyhd_kje9] =  sets_wyhd_kje9;
sSetters[(int)gTags.wyhd_kje10] =  sets_wyhd_kje10;
sSetters[(int)gTags.wyhd_karpraw_abs] =  sets_wyhd_karpraw_abs;
sSetters[(int)gTags.wyhd_karlew_abs] =  sets_wyhd_karlew_abs;
sSetters[(int)gTags.wyhd_dozpraw_wper] =  sets_wyhd_dozpraw_wper;
sSetters[(int)gTags.wyhd_dozlew_wper] =  sets_wyhd_dozlew_wper;
sSetters[(int)gTags.wyhd_dozpraw_nazad] =  sets_wyhd_dozpraw_nazad;
sSetters[(int)gTags.wyhd_dozlew_nazad] =  sets_wyhd_dozlew_nazad;
sSetters[(int)gTags.wyhd_stol_peresch_t] =  sets_wyhd_stol_peresch_t;
sSetters[(int)gTags.wyhd_barlew_wper_d] =  sets_wyhd_barlew_wper_d;
sSetters[(int)gTags.wyhd_barpraw_wper_d] =  sets_wyhd_barpraw_wper_d;
sSetters[(int)gTags.wyhd_barlew_nazad] =  sets_wyhd_barlew_nazad;
sSetters[(int)gTags.wyhd_barpraw_nazad] =  sets_wyhd_barpraw_nazad;
sSetters[(int)gTags.wyhd_tolklew_wper_d] =  sets_wyhd_tolklew_wper_d;
sSetters[(int)gTags.wyhd_tolkpraw_wper_d] =  sets_wyhd_tolkpraw_wper_d;
sSetters[(int)gTags.wyhd_tolklew_nazad] =  sets_wyhd_tolklew_nazad;
sSetters[(int)gTags.wyhd_tolkpraw_nazad] =  sets_wyhd_tolkpraw_nazad;
sSetters[(int)gTags.wyhd_karpraw_otn_wper_d] =  sets_wyhd_karpraw_otn_wper_d;
sSetters[(int)gTags.wyhd_karpraw_otn_nazad] =  sets_wyhd_karpraw_otn_nazad;
sSetters[(int)gTags.wyhd_karlew_otn_wper_d] =  sets_wyhd_karlew_otn_wper_d;
sSetters[(int)gTags.wyhd_karlew_otn_nazad] =  sets_wyhd_karlew_otn_nazad;
sSetters[(int)gTags.wyhd_klbarlew] =  sets_wyhd_klbarlew;
sSetters[(int)gTags.wyhd_klbarpraw] =  sets_wyhd_klbarpraw;
sSetters[(int)gTags.wyhd_nasotkgaza] =  sets_wyhd_nasotkgaza;
sSetters[(int)gTags.wyhd_tp_sloj] =  sets_wyhd_tp_sloj;
sSetters[(int)gTags.wyhd_tp_process] =  sets_wyhd_tp_process;
sSetters[(int)gTags.wyhd_laz_pit2] =  sets_wyhd_laz_pit2;
sSetters[(int)gTags.dm_stol_abs_domgot] =  sets_dm_stol_abs_domgot;
sSetters[(int)gTags.dm_rashod1_1] =  sets_dm_rashod1_1;
sSetters[(int)gTags.dm_rashod1_2] =  sets_dm_rashod1_2;
sSetters[(int)gTags.dm_rashod2_1] =  sets_dm_rashod2_1;
sSetters[(int)gTags.dm_rashod2_2] =  sets_dm_rashod2_2;
sSetters[(int)gTags.dm_prot1] =  sets_dm_prot1;
sSetters[(int)gTags.dm_prot2] =  sets_dm_prot2;
sSetters[(int)gTags.dm_prot3] =  sets_dm_prot3;
sSetters[(int)gTags.dm_prot4] =  sets_dm_prot4;
sSetters[(int)gTags.dm_prot5] =  sets_dm_prot5;
sSetters[(int)gTags.dm_prot6] =  sets_dm_prot6;
sSetters[(int)gTags.dm_karpraw_konc] =  sets_dm_karpraw_konc;
sSetters[(int)gTags.dm_karlew_konc] =  sets_dm_karlew_konc;
sSetters[(int)gTags.kom_stol_abs] =  sets_kom_stol_abs;
sSetters[(int)gTags.kom_tp_prer] =  sets_kom_tp_prer;
sSetters[(int)gTags.kom_stol_stop] =  sets_kom_stol_stop;
sSetters[(int)gTags.kom_stol_ustnulq] =  sets_kom_stol_ustnulq;
sSetters[(int)gTags.kom_stol_otn_wniz] =  sets_kom_stol_otn_wniz;
sSetters[(int)gTags.kom_stol_otn_wwerh] =  sets_kom_stol_otn_wwerh;
sSetters[(int)gTags.kom_tp_sloj] =  sets_kom_tp_sloj;
sSetters[(int)gTags.kom_stol_obnulit_linejku] =  sets_kom_stol_obnulit_linejku;
sSetters[(int)gTags.kom_tjen3] =  sets_kom_tjen3;
sSetters[(int)gTags.kom_tjen1] =  sets_kom_tjen1;
sSetters[(int)gTags.kom_tjen2] =  sets_kom_tjen2;
sSetters[(int)gTags.kom_tp_process] =  sets_kom_tp_process;
sSetters[(int)gTags.kom_stol_peresch_t] =  sets_kom_stol_peresch_t;
sSetters[(int)gTags.kom_laz_pit1] =  sets_kom_laz_pit1;
sSetters[(int)gTags.kom_laz_got1] =  sets_kom_laz_got1;
sSetters[(int)gTags.kom_tp_pauza] =  sets_kom_tp_pauza;
sSetters[(int)gTags.kom_pitchil1] =  sets_kom_pitchil1;
sSetters[(int)gTags.kom_pitchil2] =  sets_kom_pitchil2;
sSetters[(int)gTags.kom_klchil1] =  sets_kom_klchil1;
sSetters[(int)gTags.kom_klchil2] =  sets_kom_klchil2;
sSetters[(int)gTags.kom_pitrec] =  sets_kom_pitrec;
sSetters[(int)gTags.kom_pitmps] =  sets_kom_pitmps;
sSetters[(int)gTags.kom_karlew_otn_wper_d] =  sets_kom_karlew_otn_wper_d;
sSetters[(int)gTags.kom_karlew_otn_nazad] =  sets_kom_karlew_otn_nazad;
sSetters[(int)gTags.kom_karlew_abs] =  sets_kom_karlew_abs;
sSetters[(int)gTags.kom_karpraw_otn_wper_d] =  sets_kom_karpraw_otn_wper_d;
sSetters[(int)gTags.kom_karpraw_otn_nazad] =  sets_kom_karpraw_otn_nazad;
sSetters[(int)gTags.kom_karpraw_abs] =  sets_kom_karpraw_abs;
sSetters[(int)gTags.kom_barpraw_wper_d] =  sets_kom_barpraw_wper_d;
sSetters[(int)gTags.kom_barpraw_nazad] =  sets_kom_barpraw_nazad;
sSetters[(int)gTags.kom_barlew_wper_d] =  sets_kom_barlew_wper_d;
sSetters[(int)gTags.kom_barlew_nazad] =  sets_kom_barlew_nazad;
sSetters[(int)gTags.kom_dozlew_wper] =  sets_kom_dozlew_wper;
sSetters[(int)gTags.kom_dozpraw_wper] =  sets_kom_dozpraw_wper;
sSetters[(int)gTags.kom_tolklew_wper_d] =  sets_kom_tolklew_wper_d;
sSetters[(int)gTags.kom_tolklew_nazad] =  sets_kom_tolklew_nazad;
sSetters[(int)gTags.kom_tolkpraw_wper_d] =  sets_kom_tolkpraw_wper_d;
sSetters[(int)gTags.kom_tolkpraw_nazad] =  sets_kom_tolkpraw_nazad;
sSetters[(int)gTags.kom_dozlew_nazad] =  sets_kom_dozlew_nazad;
sSetters[(int)gTags.kom_dozpraw_nazad] =  sets_kom_dozpraw_nazad;
sSetters[(int)gTags.kom_kje9_ohl_skan1] =  sets_kom_kje9_ohl_skan1;
sSetters[(int)gTags.kom_kje10_ohl_skan2] =  sets_kom_kje10_ohl_skan2;
sSetters[(int)gTags.kom_kv1] =  sets_kom_kv1;
sSetters[(int)gTags.kom_kv2] =  sets_kom_kv2;
sSetters[(int)gTags.kom_klbarlew] =  sets_kom_klbarlew;
sSetters[(int)gTags.kom_klbarpraw] =  sets_kom_klbarpraw;
sSetters[(int)gTags.kom_nasotkgaza] =  sets_kom_nasotkgaza;
sSetters[(int)gTags.kom_barlew_stop] =  sets_kom_barlew_stop;
sSetters[(int)gTags.kom_barpraw_stop] =  sets_kom_barpraw_stop;
sSetters[(int)gTags.kom_dozlew_stop] =  sets_kom_dozlew_stop;
sSetters[(int)gTags.kom_dozpraw_stop] =  sets_kom_dozpraw_stop;
sSetters[(int)gTags.kom_karlew_stop] =  sets_kom_karlew_stop;
sSetters[(int)gTags.kom_karpraw_stop] =  sets_kom_karpraw_stop;
sSetters[(int)gTags.kom_laz_got2] =  sets_kom_laz_got2;
sSetters[(int)gTags.kom_laz_pit2] =  sets_kom_laz_pit2;
sSetters[(int)gTags.ust_stol_abs_poz] =  sets_ust_stol_abs_poz;
sSetters[(int)gTags.ust_stol_skor] =  sets_ust_stol_skor;
sSetters[(int)gTags.ust_stol_otn_rasst] =  sets_ust_stol_otn_rasst;
sSetters[(int)gTags.ust_tp_karlew_nachalo] =  sets_ust_tp_karlew_nachalo;
sSetters[(int)gTags.ust_tp_karlew_konec] =  sets_ust_tp_karlew_konec;
sSetters[(int)gTags.ust_tp_tolschsloq] =  sets_ust_tp_tolschsloq;
sSetters[(int)gTags.ust_tjen1_moschn] =  sets_ust_tjen1_moschn;
sSetters[(int)gTags.ust_tjen2_moschn] =  sets_ust_tjen2_moschn;
sSetters[(int)gTags.ust_tjen3_moschn] =  sets_ust_tjen3_moschn;
sSetters[(int)gTags.ust_tjen1_temp] =  sets_ust_tjen1_temp;
sSetters[(int)gTags.ust_tjen2_temp] =  sets_ust_tjen2_temp;
sSetters[(int)gTags.ust_tjen3_temp] =  sets_ust_tjen3_temp;
sSetters[(int)gTags.ust_karlew_skor] =  sets_ust_karlew_skor;
sSetters[(int)gTags.ust_karlew_otn_rast] =  sets_ust_karlew_otn_rast;
sSetters[(int)gTags.ust_karlew_abs_poz] =  sets_ust_karlew_abs_poz;
sSetters[(int)gTags.ust_karpraw_skor] =  sets_ust_karpraw_skor;
sSetters[(int)gTags.ust_karpraw_otn_rast] =  sets_ust_karpraw_otn_rast;
sSetters[(int)gTags.ust_karpraw_abs_poz] =  sets_ust_karpraw_abs_poz;
sSetters[(int)gTags.ust_barpraw_skor] =  sets_ust_barpraw_skor;
sSetters[(int)gTags.ust_barlew_skor] =  sets_ust_barlew_skor;
sSetters[(int)gTags.ust_dozlew_wremq] =  sets_ust_dozlew_wremq;
sSetters[(int)gTags.ust_dozpraw_wremq] =  sets_ust_dozpraw_wremq;
sSetters[(int)gTags.ust_tolklew_rasst] =  sets_ust_tolklew_rasst;
sSetters[(int)gTags.ust_tolkpraw_rasst] =  sets_ust_tolkpraw_rasst;
sSetters[(int)gTags.ust_dozpraw_skor] =  sets_ust_dozpraw_skor;
sSetters[(int)gTags.ust_dozlew_skor] =  sets_ust_dozlew_skor;
sSetters[(int)gTags.ust_tolklew_skor] =  sets_ust_tolklew_skor;
sSetters[(int)gTags.ust_tolkpraw_skor] =  sets_ust_tolkpraw_skor;
sSetters[(int)gTags.ust_tp_karpraw_nachalo] =  sets_ust_tp_karpraw_nachalo;
sSetters[(int)gTags.ust_tp_karpraw_konec] =  sets_ust_tp_karpraw_konec;
}

public Dictionary<string, gTags[]> groupingDict = new Dictionary<string, gTags[]> {
{ "Нагреватели" ,new gTags [] {
gTags.separator,
gTags.am_tjen1_tek_moschn,
gTags.kom_tjen1,
gTags.ust_tjen1_moschn,
gTags.ust_tjen1_temp,
gTags.wyhd_tjen1_pit,
gTags.separator,
gTags.kom_tjen2,
gTags.ust_tjen2_moschn,
gTags.ust_tjen2_temp,
gTags.wyhd_tjen2_pit,
gTags.separator,
gTags.kom_tjen3,
gTags.ust_tjen3_moschn,
gTags.ust_tjen3_temp,
gTags.wyhd_tjen3_pit,
gTags.separator,
gTags.am_termopara1,
}},
{ "Рецеркуляция" ,new gTags [] {
gTags.separator,
gTags.kom_kv1,
gTags.wyhd_kv1,
gTags.separator,
gTags.kom_kv2,
gTags.wyhd_kv2,
gTags.separator,
gTags.kom_pitrec,
gTags.wyhd_pitrec,
gTags.separator,
gTags.am_datch_kisl1,
gTags.am_datch_kisl2,
gTags.separator,
gTags.am_dawl_lew_fil_tr,
gTags.am_dawl_praw_fil_tr,
gTags.separator,
gTags.am_dawl_w_kamere,
gTags.am_dif_datch_rash,
}},
{ "Стол" ,new gTags [] {
gTags.separator,
gTags.kom_stol_abs,
gTags.ust_stol_abs_poz,
gTags.wyhd_stol_abs,
gTags.separator,
gTags.kom_stol_otn_wniz,
gTags.wyhd_stol_otn_wniz,
gTags.separator,
gTags.kom_stol_otn_wwerh,
gTags.wyhd_stol_otn_wwerh,
gTags.separator,
gTags.kom_stol_peresch_t,
gTags.wyhd_stol_peresch_t,
gTags.separator,
gTags.am_linejka,
gTags.am_stol_tek_poz,
gTags.dm_stol_abs_domgot,
gTags.separator,
gTags.kom_stol_obnulit_linejku,
gTags.kom_stol_stop,
gTags.kom_stol_ustnulq,
gTags.separator,
gTags.ust_stol_otn_rasst,
gTags.ust_stol_skor,
}},
{ "Каретки" ,new gTags [] {
gTags.separator,
gTags.kom_karlew_abs,
gTags.ust_karlew_abs_poz,
gTags.wyhd_karlew_abs,
gTags.separator,
gTags.kom_karlew_otn_nazad,
gTags.wyhd_karlew_otn_nazad,
gTags.separator,
gTags.kom_karlew_otn_wper_d,
gTags.wyhd_karlew_otn_wper_d,
gTags.separator,
gTags.kom_karpraw_abs,
gTags.ust_karpraw_abs_poz,
gTags.wyhd_karpraw_abs,
gTags.separator,
gTags.kom_karpraw_otn_nazad,
gTags.wyhd_karpraw_otn_nazad,
gTags.separator,
gTags.kom_karpraw_otn_wper_d,
gTags.wyhd_karpraw_otn_wper_d,
gTags.separator,
gTags.kom_pitmps,
gTags.wyhd_pitmps,
gTags.separator,
gTags.am_kar_lew_tek_poz,
gTags.am_kar_praw_tek_poz,
gTags.dm_karlew_konc,
gTags.separator,
gTags.dm_karpraw_konc,
gTags.kom_karlew_stop,
gTags.kom_karpraw_stop,
gTags.separator,
gTags.ust_karlew_otn_rast,
gTags.ust_karlew_skor,
gTags.ust_karpraw_otn_rast,
gTags.separator,
gTags.ust_karpraw_skor,
}},
{ "Чиллеры" ,new gTags [] {
gTags.separator,
gTags.kom_klchil1,
gTags.wyhd_klchil1,
gTags.separator,
gTags.kom_klchil2,
gTags.wyhd_klchil2,
gTags.separator,
gTags.kom_pitchil1,
gTags.wyhd_pitchil1,
gTags.separator,
gTags.kom_pitchil2,
gTags.wyhd_pitchil2,
gTags.separator,
gTags.am_temp1,
gTags.am_temp2,
gTags.separator,
gTags.am_temp3,
gTags.am_temp4,
gTags.separator,
gTags.am_temp5,
gTags.am_temp6,
gTags.separator,
gTags.dm_prot1,
gTags.dm_prot2,
gTags.separator,
gTags.dm_prot3,
gTags.dm_prot4,
gTags.separator,
gTags.dm_prot5,
gTags.dm_prot6,
}},
{ "Лазеры" ,new gTags [] {
gTags.separator,
gTags.kom_laz_pit1,
gTags.wyhd_laz_pit1,
gTags.separator,
gTags.kom_laz_pit2,
gTags.wyhd_laz_pit2,
gTags.separator,
gTags.kom_kje10_ohl_skan2,
gTags.wyhd_kje10,
gTags.separator,
gTags.kom_kje9_ohl_skan1,
gTags.wyhd_kje9,
gTags.separator,
gTags.am_ohl_skan1,
gTags.am_ohl_skan2,
gTags.separator,
gTags.dm_rashod1_1,
gTags.dm_rashod1_2,
gTags.separator,
gTags.dm_rashod2_1,
gTags.dm_rashod2_2,
gTags.separator,
gTags.kom_laz_got1,
gTags.kom_laz_got2,
}},
{ "Дозаторы" ,new gTags [] {
gTags.separator,
gTags.kom_dozlew_nazad,
gTags.wyhd_dozlew_nazad,
gTags.separator,
gTags.kom_dozlew_wper,
gTags.wyhd_dozlew_wper,
gTags.separator,
gTags.kom_dozpraw_nazad,
gTags.wyhd_dozpraw_nazad,
gTags.separator,
gTags.kom_dozpraw_wper,
gTags.wyhd_dozpraw_wper,
gTags.separator,
gTags.kom_dozlew_stop,
gTags.kom_dozpraw_stop,
gTags.separator,
gTags.ust_dozlew_skor,
gTags.ust_dozlew_wremq,
gTags.separator,
gTags.ust_dozpraw_skor,
gTags.ust_dozpraw_wremq,
}},
{ "Барабаны" ,new gTags [] {
gTags.separator,
gTags.kom_barlew_nazad,
gTags.wyhd_barlew_nazad,
gTags.separator,
gTags.kom_barlew_wper_d,
gTags.wyhd_barlew_wper_d,
gTags.separator,
gTags.kom_barpraw_nazad,
gTags.wyhd_barpraw_nazad,
gTags.separator,
gTags.kom_barpraw_wper_d,
gTags.wyhd_barpraw_wper_d,
gTags.separator,
gTags.kom_klbarlew,
gTags.wyhd_klbarlew,
gTags.separator,
gTags.kom_klbarpraw,
gTags.wyhd_klbarpraw,
gTags.separator,
gTags.kom_nasotkgaza,
gTags.wyhd_nasotkgaza,
gTags.separator,
gTags.kom_barlew_stop,
gTags.kom_barpraw_stop,
gTags.separator,
gTags.ust_barlew_skor,
gTags.ust_barpraw_skor,
}},
{ "Толкатели" ,new gTags [] {
gTags.separator,
gTags.kom_tolklew_nazad,
gTags.wyhd_tolklew_nazad,
gTags.separator,
gTags.kom_tolklew_wper_d,
gTags.wyhd_tolklew_wper_d,
gTags.separator,
gTags.kom_tolkpraw_nazad,
gTags.wyhd_tolkpraw_nazad,
gTags.separator,
gTags.kom_tolkpraw_wper_d,
gTags.wyhd_tolkpraw_wper_d,
gTags.separator,
gTags.ust_tolklew_rasst,
gTags.ust_tolklew_skor,
gTags.separator,
gTags.ust_tolkpraw_rasst,
gTags.ust_tolkpraw_skor,
}},
{ "Автоматический процесс" ,new gTags [] {
gTags.separator,
gTags.kom_tp_process,
gTags.wyhd_tp_process,
gTags.separator,
gTags.kom_tp_sloj,
gTags.wyhd_tp_sloj,
gTags.separator,
gTags.kom_tp_pauza,
gTags.kom_tp_prer,
gTags.separator,
gTags.ust_tp_karlew_konec,
gTags.ust_tp_karlew_nachalo,
gTags.separator,
gTags.ust_tp_karpraw_konec,
gTags.ust_tp_karpraw_nachalo,
gTags.separator,
gTags.ust_tp_tolschsloq,
}},
};
    public string get_by_name(string str) {
    switch (str){case "am_termopara1":
   return gets_am_termopara1();
case "am_dif_datch_rash":
   return gets_am_dif_datch_rash();
case "am_dawl_lew_fil_tr":
   return gets_am_dawl_lew_fil_tr();
case "am_dawl_praw_fil_tr":
   return gets_am_dawl_praw_fil_tr();
case "am_linejka":
   return gets_am_linejka();
case "am_tjen1_tek_moschn":
   return gets_am_tjen1_tek_moschn();
case "am_kar_lew_tek_poz":
   return gets_am_kar_lew_tek_poz();
case "am_stol_tek_poz":
   return gets_am_stol_tek_poz();
case "am_temp1":
   return gets_am_temp1();
case "am_temp2":
   return gets_am_temp2();
case "am_temp3":
   return gets_am_temp3();
case "am_temp4":
   return gets_am_temp4();
case "am_temp5":
   return gets_am_temp5();
case "am_temp6":
   return gets_am_temp6();
case "am_datch_kisl1":
   return gets_am_datch_kisl1();
case "am_datch_kisl2":
   return gets_am_datch_kisl2();
case "am_kar_praw_tek_poz":
   return gets_am_kar_praw_tek_poz();
case "am_dawl_w_kamere":
   return gets_am_dawl_w_kamere();
case "am_ohl_skan1":
   return gets_am_ohl_skan1();
case "am_ohl_skan2":
   return gets_am_ohl_skan2();
case "wyhd_stol_abs":
   return gets_wyhd_stol_abs();
case "wyhd_tjen1_pit":
   return gets_wyhd_tjen1_pit();
case "wyhd_tjen2_pit":
   return gets_wyhd_tjen2_pit();
case "wyhd_tjen3_pit":
   return gets_wyhd_tjen3_pit();
case "wyhd_stol_otn_wniz":
   return gets_wyhd_stol_otn_wniz();
case "wyhd_stol_otn_wwerh":
   return gets_wyhd_stol_otn_wwerh();
case "wyhd_laz_pit1":
   return gets_wyhd_laz_pit1();
case "wyhd_pitchil1":
   return gets_wyhd_pitchil1();
case "wyhd_pitchil2":
   return gets_wyhd_pitchil2();
case "wyhd_klchil1":
   return gets_wyhd_klchil1();
case "wyhd_klchil2":
   return gets_wyhd_klchil2();
case "wyhd_pitmps":
   return gets_wyhd_pitmps();
case "wyhd_pitrec":
   return gets_wyhd_pitrec();
case "wyhd_kv1":
   return gets_wyhd_kv1();
case "wyhd_kv2":
   return gets_wyhd_kv2();
case "wyhd_kje9":
   return gets_wyhd_kje9();
case "wyhd_kje10":
   return gets_wyhd_kje10();
case "wyhd_karpraw_abs":
   return gets_wyhd_karpraw_abs();
case "wyhd_karlew_abs":
   return gets_wyhd_karlew_abs();
case "wyhd_dozpraw_wper":
   return gets_wyhd_dozpraw_wper();
case "wyhd_dozlew_wper":
   return gets_wyhd_dozlew_wper();
case "wyhd_dozpraw_nazad":
   return gets_wyhd_dozpraw_nazad();
case "wyhd_dozlew_nazad":
   return gets_wyhd_dozlew_nazad();
case "wyhd_stol_peresch_t":
   return gets_wyhd_stol_peresch_t();
case "wyhd_barlew_wper_d":
   return gets_wyhd_barlew_wper_d();
case "wyhd_barpraw_wper_d":
   return gets_wyhd_barpraw_wper_d();
case "wyhd_barlew_nazad":
   return gets_wyhd_barlew_nazad();
case "wyhd_barpraw_nazad":
   return gets_wyhd_barpraw_nazad();
case "wyhd_tolklew_wper_d":
   return gets_wyhd_tolklew_wper_d();
case "wyhd_tolkpraw_wper_d":
   return gets_wyhd_tolkpraw_wper_d();
case "wyhd_tolklew_nazad":
   return gets_wyhd_tolklew_nazad();
case "wyhd_tolkpraw_nazad":
   return gets_wyhd_tolkpraw_nazad();
case "wyhd_karpraw_otn_wper_d":
   return gets_wyhd_karpraw_otn_wper_d();
case "wyhd_karpraw_otn_nazad":
   return gets_wyhd_karpraw_otn_nazad();
case "wyhd_karlew_otn_wper_d":
   return gets_wyhd_karlew_otn_wper_d();
case "wyhd_karlew_otn_nazad":
   return gets_wyhd_karlew_otn_nazad();
case "wyhd_klbarlew":
   return gets_wyhd_klbarlew();
case "wyhd_klbarpraw":
   return gets_wyhd_klbarpraw();
case "wyhd_nasotkgaza":
   return gets_wyhd_nasotkgaza();
case "wyhd_tp_sloj":
   return gets_wyhd_tp_sloj();
case "wyhd_tp_process":
   return gets_wyhd_tp_process();
case "wyhd_laz_pit2":
   return gets_wyhd_laz_pit2();
case "dm_stol_abs_domgot":
   return gets_dm_stol_abs_domgot();
case "dm_rashod1_1":
   return gets_dm_rashod1_1();
case "dm_rashod1_2":
   return gets_dm_rashod1_2();
case "dm_rashod2_1":
   return gets_dm_rashod2_1();
case "dm_rashod2_2":
   return gets_dm_rashod2_2();
case "dm_prot1":
   return gets_dm_prot1();
case "dm_prot2":
   return gets_dm_prot2();
case "dm_prot3":
   return gets_dm_prot3();
case "dm_prot4":
   return gets_dm_prot4();
case "dm_prot5":
   return gets_dm_prot5();
case "dm_prot6":
   return gets_dm_prot6();
case "dm_karpraw_konc":
   return gets_dm_karpraw_konc();
case "dm_karlew_konc":
   return gets_dm_karlew_konc();
case "kom_stol_abs":
   return gets_kom_stol_abs();
case "kom_tp_prer":
   return gets_kom_tp_prer();
case "kom_stol_stop":
   return gets_kom_stol_stop();
case "kom_stol_ustnulq":
   return gets_kom_stol_ustnulq();
case "kom_stol_otn_wniz":
   return gets_kom_stol_otn_wniz();
case "kom_stol_otn_wwerh":
   return gets_kom_stol_otn_wwerh();
case "kom_tp_sloj":
   return gets_kom_tp_sloj();
case "kom_stol_obnulit_linejku":
   return gets_kom_stol_obnulit_linejku();
case "kom_tjen3":
   return gets_kom_tjen3();
case "kom_tjen1":
   return gets_kom_tjen1();
case "kom_tjen2":
   return gets_kom_tjen2();
case "kom_tp_process":
   return gets_kom_tp_process();
case "kom_stol_peresch_t":
   return gets_kom_stol_peresch_t();
case "kom_laz_pit1":
   return gets_kom_laz_pit1();
case "kom_laz_got1":
   return gets_kom_laz_got1();
case "kom_tp_pauza":
   return gets_kom_tp_pauza();
case "kom_pitchil1":
   return gets_kom_pitchil1();
case "kom_pitchil2":
   return gets_kom_pitchil2();
case "kom_klchil1":
   return gets_kom_klchil1();
case "kom_klchil2":
   return gets_kom_klchil2();
case "kom_pitrec":
   return gets_kom_pitrec();
case "kom_pitmps":
   return gets_kom_pitmps();
case "kom_karlew_otn_wper_d":
   return gets_kom_karlew_otn_wper_d();
case "kom_karlew_otn_nazad":
   return gets_kom_karlew_otn_nazad();
case "kom_karlew_abs":
   return gets_kom_karlew_abs();
case "kom_karpraw_otn_wper_d":
   return gets_kom_karpraw_otn_wper_d();
case "kom_karpraw_otn_nazad":
   return gets_kom_karpraw_otn_nazad();
case "kom_karpraw_abs":
   return gets_kom_karpraw_abs();
case "kom_barpraw_wper_d":
   return gets_kom_barpraw_wper_d();
case "kom_barpraw_nazad":
   return gets_kom_barpraw_nazad();
case "kom_barlew_wper_d":
   return gets_kom_barlew_wper_d();
case "kom_barlew_nazad":
   return gets_kom_barlew_nazad();
case "kom_dozlew_wper":
   return gets_kom_dozlew_wper();
case "kom_dozpraw_wper":
   return gets_kom_dozpraw_wper();
case "kom_tolklew_wper_d":
   return gets_kom_tolklew_wper_d();
case "kom_tolklew_nazad":
   return gets_kom_tolklew_nazad();
case "kom_tolkpraw_wper_d":
   return gets_kom_tolkpraw_wper_d();
case "kom_tolkpraw_nazad":
   return gets_kom_tolkpraw_nazad();
case "kom_dozlew_nazad":
   return gets_kom_dozlew_nazad();
case "kom_dozpraw_nazad":
   return gets_kom_dozpraw_nazad();
case "kom_kje9_ohl_skan1":
   return gets_kom_kje9_ohl_skan1();
case "kom_kje10_ohl_skan2":
   return gets_kom_kje10_ohl_skan2();
case "kom_kv1":
   return gets_kom_kv1();
case "kom_kv2":
   return gets_kom_kv2();
case "kom_klbarlew":
   return gets_kom_klbarlew();
case "kom_klbarpraw":
   return gets_kom_klbarpraw();
case "kom_nasotkgaza":
   return gets_kom_nasotkgaza();
case "kom_barlew_stop":
   return gets_kom_barlew_stop();
case "kom_barpraw_stop":
   return gets_kom_barpraw_stop();
case "kom_dozlew_stop":
   return gets_kom_dozlew_stop();
case "kom_dozpraw_stop":
   return gets_kom_dozpraw_stop();
case "kom_karlew_stop":
   return gets_kom_karlew_stop();
case "kom_karpraw_stop":
   return gets_kom_karpraw_stop();
case "kom_laz_got2":
   return gets_kom_laz_got2();
case "kom_laz_pit2":
   return gets_kom_laz_pit2();
case "ust_stol_abs_poz":
   return gets_ust_stol_abs_poz();
case "ust_stol_skor":
   return gets_ust_stol_skor();
case "ust_stol_otn_rasst":
   return gets_ust_stol_otn_rasst();
case "ust_tp_karlew_nachalo":
   return gets_ust_tp_karlew_nachalo();
case "ust_tp_karlew_konec":
   return gets_ust_tp_karlew_konec();
case "ust_tp_tolschsloq":
   return gets_ust_tp_tolschsloq();
case "ust_tjen1_moschn":
   return gets_ust_tjen1_moschn();
case "ust_tjen2_moschn":
   return gets_ust_tjen2_moschn();
case "ust_tjen3_moschn":
   return gets_ust_tjen3_moschn();
case "ust_tjen1_temp":
   return gets_ust_tjen1_temp();
case "ust_tjen2_temp":
   return gets_ust_tjen2_temp();
case "ust_tjen3_temp":
   return gets_ust_tjen3_temp();
case "ust_karlew_skor":
   return gets_ust_karlew_skor();
case "ust_karlew_otn_rast":
   return gets_ust_karlew_otn_rast();
case "ust_karlew_abs_poz":
   return gets_ust_karlew_abs_poz();
case "ust_karpraw_skor":
   return gets_ust_karpraw_skor();
case "ust_karpraw_otn_rast":
   return gets_ust_karpraw_otn_rast();
case "ust_karpraw_abs_poz":
   return gets_ust_karpraw_abs_poz();
case "ust_barpraw_skor":
   return gets_ust_barpraw_skor();
case "ust_barlew_skor":
   return gets_ust_barlew_skor();
case "ust_dozlew_wremq":
   return gets_ust_dozlew_wremq();
case "ust_dozpraw_wremq":
   return gets_ust_dozpraw_wremq();
case "ust_tolklew_rasst":
   return gets_ust_tolklew_rasst();
case "ust_tolkpraw_rasst":
   return gets_ust_tolkpraw_rasst();
case "ust_dozpraw_skor":
   return gets_ust_dozpraw_skor();
case "ust_dozlew_skor":
   return gets_ust_dozlew_skor();
case "ust_tolklew_skor":
   return gets_ust_tolklew_skor();
case "ust_tolkpraw_skor":
   return gets_ust_tolkpraw_skor();
case "ust_tp_karpraw_nachalo":
   return gets_ust_tp_karpraw_nachalo();
case "ust_tp_karpraw_konec":
   return gets_ust_tp_karpraw_konec();
default: 
   return "NAN";
} 
 }
    public bool set_by_name(string str, string val) {
    switch (str){case "am_termopara1":
   return sets_am_termopara1(val);
case "am_dif_datch_rash":
   return sets_am_dif_datch_rash(val);
case "am_dawl_lew_fil_tr":
   return sets_am_dawl_lew_fil_tr(val);
case "am_dawl_praw_fil_tr":
   return sets_am_dawl_praw_fil_tr(val);
case "am_linejka":
   return sets_am_linejka(val);
case "am_tjen1_tek_moschn":
   return sets_am_tjen1_tek_moschn(val);
case "am_kar_lew_tek_poz":
   return sets_am_kar_lew_tek_poz(val);
case "am_stol_tek_poz":
   return sets_am_stol_tek_poz(val);
case "am_temp1":
   return sets_am_temp1(val);
case "am_temp2":
   return sets_am_temp2(val);
case "am_temp3":
   return sets_am_temp3(val);
case "am_temp4":
   return sets_am_temp4(val);
case "am_temp5":
   return sets_am_temp5(val);
case "am_temp6":
   return sets_am_temp6(val);
case "am_datch_kisl1":
   return sets_am_datch_kisl1(val);
case "am_datch_kisl2":
   return sets_am_datch_kisl2(val);
case "am_kar_praw_tek_poz":
   return sets_am_kar_praw_tek_poz(val);
case "am_dawl_w_kamere":
   return sets_am_dawl_w_kamere(val);
case "am_ohl_skan1":
   return sets_am_ohl_skan1(val);
case "am_ohl_skan2":
   return sets_am_ohl_skan2(val);
case "wyhd_stol_abs":
   return sets_wyhd_stol_abs(val);
case "wyhd_tjen1_pit":
   return sets_wyhd_tjen1_pit(val);
case "wyhd_tjen2_pit":
   return sets_wyhd_tjen2_pit(val);
case "wyhd_tjen3_pit":
   return sets_wyhd_tjen3_pit(val);
case "wyhd_stol_otn_wniz":
   return sets_wyhd_stol_otn_wniz(val);
case "wyhd_stol_otn_wwerh":
   return sets_wyhd_stol_otn_wwerh(val);
case "wyhd_laz_pit1":
   return sets_wyhd_laz_pit1(val);
case "wyhd_pitchil1":
   return sets_wyhd_pitchil1(val);
case "wyhd_pitchil2":
   return sets_wyhd_pitchil2(val);
case "wyhd_klchil1":
   return sets_wyhd_klchil1(val);
case "wyhd_klchil2":
   return sets_wyhd_klchil2(val);
case "wyhd_pitmps":
   return sets_wyhd_pitmps(val);
case "wyhd_pitrec":
   return sets_wyhd_pitrec(val);
case "wyhd_kv1":
   return sets_wyhd_kv1(val);
case "wyhd_kv2":
   return sets_wyhd_kv2(val);
case "wyhd_kje9":
   return sets_wyhd_kje9(val);
case "wyhd_kje10":
   return sets_wyhd_kje10(val);
case "wyhd_karpraw_abs":
   return sets_wyhd_karpraw_abs(val);
case "wyhd_karlew_abs":
   return sets_wyhd_karlew_abs(val);
case "wyhd_dozpraw_wper":
   return sets_wyhd_dozpraw_wper(val);
case "wyhd_dozlew_wper":
   return sets_wyhd_dozlew_wper(val);
case "wyhd_dozpraw_nazad":
   return sets_wyhd_dozpraw_nazad(val);
case "wyhd_dozlew_nazad":
   return sets_wyhd_dozlew_nazad(val);
case "wyhd_stol_peresch_t":
   return sets_wyhd_stol_peresch_t(val);
case "wyhd_barlew_wper_d":
   return sets_wyhd_barlew_wper_d(val);
case "wyhd_barpraw_wper_d":
   return sets_wyhd_barpraw_wper_d(val);
case "wyhd_barlew_nazad":
   return sets_wyhd_barlew_nazad(val);
case "wyhd_barpraw_nazad":
   return sets_wyhd_barpraw_nazad(val);
case "wyhd_tolklew_wper_d":
   return sets_wyhd_tolklew_wper_d(val);
case "wyhd_tolkpraw_wper_d":
   return sets_wyhd_tolkpraw_wper_d(val);
case "wyhd_tolklew_nazad":
   return sets_wyhd_tolklew_nazad(val);
case "wyhd_tolkpraw_nazad":
   return sets_wyhd_tolkpraw_nazad(val);
case "wyhd_karpraw_otn_wper_d":
   return sets_wyhd_karpraw_otn_wper_d(val);
case "wyhd_karpraw_otn_nazad":
   return sets_wyhd_karpraw_otn_nazad(val);
case "wyhd_karlew_otn_wper_d":
   return sets_wyhd_karlew_otn_wper_d(val);
case "wyhd_karlew_otn_nazad":
   return sets_wyhd_karlew_otn_nazad(val);
case "wyhd_klbarlew":
   return sets_wyhd_klbarlew(val);
case "wyhd_klbarpraw":
   return sets_wyhd_klbarpraw(val);
case "wyhd_nasotkgaza":
   return sets_wyhd_nasotkgaza(val);
case "wyhd_tp_sloj":
   return sets_wyhd_tp_sloj(val);
case "wyhd_tp_process":
   return sets_wyhd_tp_process(val);
case "wyhd_laz_pit2":
   return sets_wyhd_laz_pit2(val);
case "dm_stol_abs_domgot":
   return sets_dm_stol_abs_domgot(val);
case "dm_rashod1_1":
   return sets_dm_rashod1_1(val);
case "dm_rashod1_2":
   return sets_dm_rashod1_2(val);
case "dm_rashod2_1":
   return sets_dm_rashod2_1(val);
case "dm_rashod2_2":
   return sets_dm_rashod2_2(val);
case "dm_prot1":
   return sets_dm_prot1(val);
case "dm_prot2":
   return sets_dm_prot2(val);
case "dm_prot3":
   return sets_dm_prot3(val);
case "dm_prot4":
   return sets_dm_prot4(val);
case "dm_prot5":
   return sets_dm_prot5(val);
case "dm_prot6":
   return sets_dm_prot6(val);
case "dm_karpraw_konc":
   return sets_dm_karpraw_konc(val);
case "dm_karlew_konc":
   return sets_dm_karlew_konc(val);
case "kom_stol_abs":
   return sets_kom_stol_abs(val);
case "kom_tp_prer":
   return sets_kom_tp_prer(val);
case "kom_stol_stop":
   return sets_kom_stol_stop(val);
case "kom_stol_ustnulq":
   return sets_kom_stol_ustnulq(val);
case "kom_stol_otn_wniz":
   return sets_kom_stol_otn_wniz(val);
case "kom_stol_otn_wwerh":
   return sets_kom_stol_otn_wwerh(val);
case "kom_tp_sloj":
   return sets_kom_tp_sloj(val);
case "kom_stol_obnulit_linejku":
   return sets_kom_stol_obnulit_linejku(val);
case "kom_tjen3":
   return sets_kom_tjen3(val);
case "kom_tjen1":
   return sets_kom_tjen1(val);
case "kom_tjen2":
   return sets_kom_tjen2(val);
case "kom_tp_process":
   return sets_kom_tp_process(val);
case "kom_stol_peresch_t":
   return sets_kom_stol_peresch_t(val);
case "kom_laz_pit1":
   return sets_kom_laz_pit1(val);
case "kom_laz_got1":
   return sets_kom_laz_got1(val);
case "kom_tp_pauza":
   return sets_kom_tp_pauza(val);
case "kom_pitchil1":
   return sets_kom_pitchil1(val);
case "kom_pitchil2":
   return sets_kom_pitchil2(val);
case "kom_klchil1":
   return sets_kom_klchil1(val);
case "kom_klchil2":
   return sets_kom_klchil2(val);
case "kom_pitrec":
   return sets_kom_pitrec(val);
case "kom_pitmps":
   return sets_kom_pitmps(val);
case "kom_karlew_otn_wper_d":
   return sets_kom_karlew_otn_wper_d(val);
case "kom_karlew_otn_nazad":
   return sets_kom_karlew_otn_nazad(val);
case "kom_karlew_abs":
   return sets_kom_karlew_abs(val);
case "kom_karpraw_otn_wper_d":
   return sets_kom_karpraw_otn_wper_d(val);
case "kom_karpraw_otn_nazad":
   return sets_kom_karpraw_otn_nazad(val);
case "kom_karpraw_abs":
   return sets_kom_karpraw_abs(val);
case "kom_barpraw_wper_d":
   return sets_kom_barpraw_wper_d(val);
case "kom_barpraw_nazad":
   return sets_kom_barpraw_nazad(val);
case "kom_barlew_wper_d":
   return sets_kom_barlew_wper_d(val);
case "kom_barlew_nazad":
   return sets_kom_barlew_nazad(val);
case "kom_dozlew_wper":
   return sets_kom_dozlew_wper(val);
case "kom_dozpraw_wper":
   return sets_kom_dozpraw_wper(val);
case "kom_tolklew_wper_d":
   return sets_kom_tolklew_wper_d(val);
case "kom_tolklew_nazad":
   return sets_kom_tolklew_nazad(val);
case "kom_tolkpraw_wper_d":
   return sets_kom_tolkpraw_wper_d(val);
case "kom_tolkpraw_nazad":
   return sets_kom_tolkpraw_nazad(val);
case "kom_dozlew_nazad":
   return sets_kom_dozlew_nazad(val);
case "kom_dozpraw_nazad":
   return sets_kom_dozpraw_nazad(val);
case "kom_kje9_ohl_skan1":
   return sets_kom_kje9_ohl_skan1(val);
case "kom_kje10_ohl_skan2":
   return sets_kom_kje10_ohl_skan2(val);
case "kom_kv1":
   return sets_kom_kv1(val);
case "kom_kv2":
   return sets_kom_kv2(val);
case "kom_klbarlew":
   return sets_kom_klbarlew(val);
case "kom_klbarpraw":
   return sets_kom_klbarpraw(val);
case "kom_nasotkgaza":
   return sets_kom_nasotkgaza(val);
case "kom_barlew_stop":
   return sets_kom_barlew_stop(val);
case "kom_barpraw_stop":
   return sets_kom_barpraw_stop(val);
case "kom_dozlew_stop":
   return sets_kom_dozlew_stop(val);
case "kom_dozpraw_stop":
   return sets_kom_dozpraw_stop(val);
case "kom_karlew_stop":
   return sets_kom_karlew_stop(val);
case "kom_karpraw_stop":
   return sets_kom_karpraw_stop(val);
case "kom_laz_got2":
   return sets_kom_laz_got2(val);
case "kom_laz_pit2":
   return sets_kom_laz_pit2(val);
case "ust_stol_abs_poz":
   return sets_ust_stol_abs_poz(val);
case "ust_stol_skor":
   return sets_ust_stol_skor(val);
case "ust_stol_otn_rasst":
   return sets_ust_stol_otn_rasst(val);
case "ust_tp_karlew_nachalo":
   return sets_ust_tp_karlew_nachalo(val);
case "ust_tp_karlew_konec":
   return sets_ust_tp_karlew_konec(val);
case "ust_tp_tolschsloq":
   return sets_ust_tp_tolschsloq(val);
case "ust_tjen1_moschn":
   return sets_ust_tjen1_moschn(val);
case "ust_tjen2_moschn":
   return sets_ust_tjen2_moschn(val);
case "ust_tjen3_moschn":
   return sets_ust_tjen3_moschn(val);
case "ust_tjen1_temp":
   return sets_ust_tjen1_temp(val);
case "ust_tjen2_temp":
   return sets_ust_tjen2_temp(val);
case "ust_tjen3_temp":
   return sets_ust_tjen3_temp(val);
case "ust_karlew_skor":
   return sets_ust_karlew_skor(val);
case "ust_karlew_otn_rast":
   return sets_ust_karlew_otn_rast(val);
case "ust_karlew_abs_poz":
   return sets_ust_karlew_abs_poz(val);
case "ust_karpraw_skor":
   return sets_ust_karpraw_skor(val);
case "ust_karpraw_otn_rast":
   return sets_ust_karpraw_otn_rast(val);
case "ust_karpraw_abs_poz":
   return sets_ust_karpraw_abs_poz(val);
case "ust_barpraw_skor":
   return sets_ust_barpraw_skor(val);
case "ust_barlew_skor":
   return sets_ust_barlew_skor(val);
case "ust_dozlew_wremq":
   return sets_ust_dozlew_wremq(val);
case "ust_dozpraw_wremq":
   return sets_ust_dozpraw_wremq(val);
case "ust_tolklew_rasst":
   return sets_ust_tolklew_rasst(val);
case "ust_tolkpraw_rasst":
   return sets_ust_tolkpraw_rasst(val);
case "ust_dozpraw_skor":
   return sets_ust_dozpraw_skor(val);
case "ust_dozlew_skor":
   return sets_ust_dozlew_skor(val);
case "ust_tolklew_skor":
   return sets_ust_tolklew_skor(val);
case "ust_tolkpraw_skor":
   return sets_ust_tolkpraw_skor(val);
case "ust_tp_karpraw_nachalo":
   return sets_ust_tp_karpraw_nachalo(val);
case "ust_tp_karpraw_konec":
   return sets_ust_tp_karpraw_konec(val);
default: 
   return false;
} 
 }
    public string get_debug_by_name(string str) {
    switch (str){case "am_termopara1":
   return debug_name_am_termopara1();
case "am_dif_datch_rash":
   return debug_name_am_dif_datch_rash();
case "am_dawl_lew_fil_tr":
   return debug_name_am_dawl_lew_fil_tr();
case "am_dawl_praw_fil_tr":
   return debug_name_am_dawl_praw_fil_tr();
case "am_linejka":
   return debug_name_am_linejka();
case "am_tjen1_tek_moschn":
   return debug_name_am_tjen1_tek_moschn();
case "am_kar_lew_tek_poz":
   return debug_name_am_kar_lew_tek_poz();
case "am_stol_tek_poz":
   return debug_name_am_stol_tek_poz();
case "am_temp1":
   return debug_name_am_temp1();
case "am_temp2":
   return debug_name_am_temp2();
case "am_temp3":
   return debug_name_am_temp3();
case "am_temp4":
   return debug_name_am_temp4();
case "am_temp5":
   return debug_name_am_temp5();
case "am_temp6":
   return debug_name_am_temp6();
case "am_datch_kisl1":
   return debug_name_am_datch_kisl1();
case "am_datch_kisl2":
   return debug_name_am_datch_kisl2();
case "am_kar_praw_tek_poz":
   return debug_name_am_kar_praw_tek_poz();
case "am_dawl_w_kamere":
   return debug_name_am_dawl_w_kamere();
case "am_ohl_skan1":
   return debug_name_am_ohl_skan1();
case "am_ohl_skan2":
   return debug_name_am_ohl_skan2();
case "wyhd_stol_abs":
   return debug_name_wyhd_stol_abs();
case "wyhd_tjen1_pit":
   return debug_name_wyhd_tjen1_pit();
case "wyhd_tjen2_pit":
   return debug_name_wyhd_tjen2_pit();
case "wyhd_tjen3_pit":
   return debug_name_wyhd_tjen3_pit();
case "wyhd_stol_otn_wniz":
   return debug_name_wyhd_stol_otn_wniz();
case "wyhd_stol_otn_wwerh":
   return debug_name_wyhd_stol_otn_wwerh();
case "wyhd_laz_pit1":
   return debug_name_wyhd_laz_pit1();
case "wyhd_pitchil1":
   return debug_name_wyhd_pitchil1();
case "wyhd_pitchil2":
   return debug_name_wyhd_pitchil2();
case "wyhd_klchil1":
   return debug_name_wyhd_klchil1();
case "wyhd_klchil2":
   return debug_name_wyhd_klchil2();
case "wyhd_pitmps":
   return debug_name_wyhd_pitmps();
case "wyhd_pitrec":
   return debug_name_wyhd_pitrec();
case "wyhd_kv1":
   return debug_name_wyhd_kv1();
case "wyhd_kv2":
   return debug_name_wyhd_kv2();
case "wyhd_kje9":
   return debug_name_wyhd_kje9();
case "wyhd_kje10":
   return debug_name_wyhd_kje10();
case "wyhd_karpraw_abs":
   return debug_name_wyhd_karpraw_abs();
case "wyhd_karlew_abs":
   return debug_name_wyhd_karlew_abs();
case "wyhd_dozpraw_wper":
   return debug_name_wyhd_dozpraw_wper();
case "wyhd_dozlew_wper":
   return debug_name_wyhd_dozlew_wper();
case "wyhd_dozpraw_nazad":
   return debug_name_wyhd_dozpraw_nazad();
case "wyhd_dozlew_nazad":
   return debug_name_wyhd_dozlew_nazad();
case "wyhd_stol_peresch_t":
   return debug_name_wyhd_stol_peresch_t();
case "wyhd_barlew_wper_d":
   return debug_name_wyhd_barlew_wper_d();
case "wyhd_barpraw_wper_d":
   return debug_name_wyhd_barpraw_wper_d();
case "wyhd_barlew_nazad":
   return debug_name_wyhd_barlew_nazad();
case "wyhd_barpraw_nazad":
   return debug_name_wyhd_barpraw_nazad();
case "wyhd_tolklew_wper_d":
   return debug_name_wyhd_tolklew_wper_d();
case "wyhd_tolkpraw_wper_d":
   return debug_name_wyhd_tolkpraw_wper_d();
case "wyhd_tolklew_nazad":
   return debug_name_wyhd_tolklew_nazad();
case "wyhd_tolkpraw_nazad":
   return debug_name_wyhd_tolkpraw_nazad();
case "wyhd_karpraw_otn_wper_d":
   return debug_name_wyhd_karpraw_otn_wper_d();
case "wyhd_karpraw_otn_nazad":
   return debug_name_wyhd_karpraw_otn_nazad();
case "wyhd_karlew_otn_wper_d":
   return debug_name_wyhd_karlew_otn_wper_d();
case "wyhd_karlew_otn_nazad":
   return debug_name_wyhd_karlew_otn_nazad();
case "wyhd_klbarlew":
   return debug_name_wyhd_klbarlew();
case "wyhd_klbarpraw":
   return debug_name_wyhd_klbarpraw();
case "wyhd_nasotkgaza":
   return debug_name_wyhd_nasotkgaza();
case "wyhd_tp_sloj":
   return debug_name_wyhd_tp_sloj();
case "wyhd_tp_process":
   return debug_name_wyhd_tp_process();
case "wyhd_laz_pit2":
   return debug_name_wyhd_laz_pit2();
case "dm_stol_abs_domgot":
   return debug_name_dm_stol_abs_domgot();
case "dm_rashod1_1":
   return debug_name_dm_rashod1_1();
case "dm_rashod1_2":
   return debug_name_dm_rashod1_2();
case "dm_rashod2_1":
   return debug_name_dm_rashod2_1();
case "dm_rashod2_2":
   return debug_name_dm_rashod2_2();
case "dm_prot1":
   return debug_name_dm_prot1();
case "dm_prot2":
   return debug_name_dm_prot2();
case "dm_prot3":
   return debug_name_dm_prot3();
case "dm_prot4":
   return debug_name_dm_prot4();
case "dm_prot5":
   return debug_name_dm_prot5();
case "dm_prot6":
   return debug_name_dm_prot6();
case "dm_karpraw_konc":
   return debug_name_dm_karpraw_konc();
case "dm_karlew_konc":
   return debug_name_dm_karlew_konc();
case "kom_stol_abs":
   return debug_name_kom_stol_abs();
case "kom_tp_prer":
   return debug_name_kom_tp_prer();
case "kom_stol_stop":
   return debug_name_kom_stol_stop();
case "kom_stol_ustnulq":
   return debug_name_kom_stol_ustnulq();
case "kom_stol_otn_wniz":
   return debug_name_kom_stol_otn_wniz();
case "kom_stol_otn_wwerh":
   return debug_name_kom_stol_otn_wwerh();
case "kom_tp_sloj":
   return debug_name_kom_tp_sloj();
case "kom_stol_obnulit_linejku":
   return debug_name_kom_stol_obnulit_linejku();
case "kom_tjen3":
   return debug_name_kom_tjen3();
case "kom_tjen1":
   return debug_name_kom_tjen1();
case "kom_tjen2":
   return debug_name_kom_tjen2();
case "kom_tp_process":
   return debug_name_kom_tp_process();
case "kom_stol_peresch_t":
   return debug_name_kom_stol_peresch_t();
case "kom_laz_pit1":
   return debug_name_kom_laz_pit1();
case "kom_laz_got1":
   return debug_name_kom_laz_got1();
case "kom_tp_pauza":
   return debug_name_kom_tp_pauza();
case "kom_pitchil1":
   return debug_name_kom_pitchil1();
case "kom_pitchil2":
   return debug_name_kom_pitchil2();
case "kom_klchil1":
   return debug_name_kom_klchil1();
case "kom_klchil2":
   return debug_name_kom_klchil2();
case "kom_pitrec":
   return debug_name_kom_pitrec();
case "kom_pitmps":
   return debug_name_kom_pitmps();
case "kom_karlew_otn_wper_d":
   return debug_name_kom_karlew_otn_wper_d();
case "kom_karlew_otn_nazad":
   return debug_name_kom_karlew_otn_nazad();
case "kom_karlew_abs":
   return debug_name_kom_karlew_abs();
case "kom_karpraw_otn_wper_d":
   return debug_name_kom_karpraw_otn_wper_d();
case "kom_karpraw_otn_nazad":
   return debug_name_kom_karpraw_otn_nazad();
case "kom_karpraw_abs":
   return debug_name_kom_karpraw_abs();
case "kom_barpraw_wper_d":
   return debug_name_kom_barpraw_wper_d();
case "kom_barpraw_nazad":
   return debug_name_kom_barpraw_nazad();
case "kom_barlew_wper_d":
   return debug_name_kom_barlew_wper_d();
case "kom_barlew_nazad":
   return debug_name_kom_barlew_nazad();
case "kom_dozlew_wper":
   return debug_name_kom_dozlew_wper();
case "kom_dozpraw_wper":
   return debug_name_kom_dozpraw_wper();
case "kom_tolklew_wper_d":
   return debug_name_kom_tolklew_wper_d();
case "kom_tolklew_nazad":
   return debug_name_kom_tolklew_nazad();
case "kom_tolkpraw_wper_d":
   return debug_name_kom_tolkpraw_wper_d();
case "kom_tolkpraw_nazad":
   return debug_name_kom_tolkpraw_nazad();
case "kom_dozlew_nazad":
   return debug_name_kom_dozlew_nazad();
case "kom_dozpraw_nazad":
   return debug_name_kom_dozpraw_nazad();
case "kom_kje9_ohl_skan1":
   return debug_name_kom_kje9_ohl_skan1();
case "kom_kje10_ohl_skan2":
   return debug_name_kom_kje10_ohl_skan2();
case "kom_kv1":
   return debug_name_kom_kv1();
case "kom_kv2":
   return debug_name_kom_kv2();
case "kom_klbarlew":
   return debug_name_kom_klbarlew();
case "kom_klbarpraw":
   return debug_name_kom_klbarpraw();
case "kom_nasotkgaza":
   return debug_name_kom_nasotkgaza();
case "kom_barlew_stop":
   return debug_name_kom_barlew_stop();
case "kom_barpraw_stop":
   return debug_name_kom_barpraw_stop();
case "kom_dozlew_stop":
   return debug_name_kom_dozlew_stop();
case "kom_dozpraw_stop":
   return debug_name_kom_dozpraw_stop();
case "kom_karlew_stop":
   return debug_name_kom_karlew_stop();
case "kom_karpraw_stop":
   return debug_name_kom_karpraw_stop();
case "kom_laz_got2":
   return debug_name_kom_laz_got2();
case "kom_laz_pit2":
   return debug_name_kom_laz_pit2();
case "ust_stol_abs_poz":
   return debug_name_ust_stol_abs_poz();
case "ust_stol_skor":
   return debug_name_ust_stol_skor();
case "ust_stol_otn_rasst":
   return debug_name_ust_stol_otn_rasst();
case "ust_tp_karlew_nachalo":
   return debug_name_ust_tp_karlew_nachalo();
case "ust_tp_karlew_konec":
   return debug_name_ust_tp_karlew_konec();
case "ust_tp_tolschsloq":
   return debug_name_ust_tp_tolschsloq();
case "ust_tjen1_moschn":
   return debug_name_ust_tjen1_moschn();
case "ust_tjen2_moschn":
   return debug_name_ust_tjen2_moschn();
case "ust_tjen3_moschn":
   return debug_name_ust_tjen3_moschn();
case "ust_tjen1_temp":
   return debug_name_ust_tjen1_temp();
case "ust_tjen2_temp":
   return debug_name_ust_tjen2_temp();
case "ust_tjen3_temp":
   return debug_name_ust_tjen3_temp();
case "ust_karlew_skor":
   return debug_name_ust_karlew_skor();
case "ust_karlew_otn_rast":
   return debug_name_ust_karlew_otn_rast();
case "ust_karlew_abs_poz":
   return debug_name_ust_karlew_abs_poz();
case "ust_karpraw_skor":
   return debug_name_ust_karpraw_skor();
case "ust_karpraw_otn_rast":
   return debug_name_ust_karpraw_otn_rast();
case "ust_karpraw_abs_poz":
   return debug_name_ust_karpraw_abs_poz();
case "ust_barpraw_skor":
   return debug_name_ust_barpraw_skor();
case "ust_barlew_skor":
   return debug_name_ust_barlew_skor();
case "ust_dozlew_wremq":
   return debug_name_ust_dozlew_wremq();
case "ust_dozpraw_wremq":
   return debug_name_ust_dozpraw_wremq();
case "ust_tolklew_rasst":
   return debug_name_ust_tolklew_rasst();
case "ust_tolkpraw_rasst":
   return debug_name_ust_tolkpraw_rasst();
case "ust_dozpraw_skor":
   return debug_name_ust_dozpraw_skor();
case "ust_dozlew_skor":
   return debug_name_ust_dozlew_skor();
case "ust_tolklew_skor":
   return debug_name_ust_tolklew_skor();
case "ust_tolkpraw_skor":
   return debug_name_ust_tolkpraw_skor();
case "ust_tp_karpraw_nachalo":
   return debug_name_ust_tp_karpraw_nachalo();
case "ust_tp_karpraw_konec":
   return debug_name_ust_tp_karpraw_konec();
default: 
   return "NAN";
} 
 }
    }
 }
//____________________________________________________________________________________________________
//____________________________________________________________________________________________________
//________________________________________________________________________________+_______________++++
//++++++++++++++++++++++++++++++++________++++________++++++++++++++++++++++++++++++++________________
//________________________++++++++++++++++____++++++++++++++++________________++++++++++++++++________
//+__+_++++++_______++_++_+_++++++++++________________________________________________________________
//____++++________++++++++++++++++++++++++__++++++++++++++++++++++++++++++++++++++++__________________
//__________________________________++++++++++++______________________________________________________
//____________________________________________________________________________________________________
//____________________________________________________________________________________________________
