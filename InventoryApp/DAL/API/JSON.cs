using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp.DAL.API
{
    public class Rootobject
    {
        public string code { get; set; }
        public string status_verbose { get; set; }
        public int status { get; set; }
        public Product product { get; set; }
    }

    public class Product
    {
        public int rev { get; set; }
        public string no_nutrition_data { get; set; }
        public string[] categories_hierarchy { get; set; }
        public string[] nutrition_grades_tags { get; set; }
        public string last_editor { get; set; }
        public string stores { get; set; }
        public string[] codes_tags { get; set; }
        public string nutriscore_grade { get; set; }
        public string lang { get; set; }
        public string last_modified_by { get; set; }
        public int last_image_t { get; set; }
        public int completed_t { get; set; }
        public string purchase_places { get; set; }
        public long sortkey { get; set; }
        public Nutriscore_Data nutriscore_data { get; set; }
        public string categories { get; set; }
        public string[] additives_prev_original_tags { get; set; }
        public string ingredients_text_with_allergens_fr { get; set; }
        public object[] origins_hierarchy { get; set; }
        public string[] editors_tags { get; set; }
        public string[] languages_hierarchy { get; set; }
        public string update_key { get; set; }
        public string traces_lc { get; set; }
        public object[] amino_acids_tags { get; set; }
        public int nova_group { get; set; }
        public Categories_Properties categories_properties { get; set; }
        public int unique_scans_n { get; set; }
        public string[] countries_tags { get; set; }
        public string ingredients_text_fr { get; set; }
        public int nutriscore_score { get; set; }
        public string origins { get; set; }
        public string[] pnns_groups_1_tags { get; set; }
        public string[] states_tags { get; set; }
        public string[] data_sources_tags { get; set; }
        public object[] minerals_prev_tags { get; set; }
        public object[] minerals_tags { get; set; }
        public int created_t { get; set; }
        public string[] last_image_dates_tags { get; set; }
        public int additives_n { get; set; }
        public string image_nutrition_small_url { get; set; }
        public object[] vitamins_prev_tags { get; set; }
        public string traces { get; set; }
        public object[] unknown_nutrients_tags { get; set; }
        public string emb_codes_orig { get; set; }
        public object[] additives_debug_tags { get; set; }
        public string[] pnns_groups_2_tags { get; set; }
        public string[] countries_hierarchy { get; set; }
        public string[] ciqual_food_name_tags { get; set; }
        public string[] states_hierarchy { get; set; }
        public string image_nutrition_url { get; set; }
        public string[] data_quality_tags { get; set; }
        public string lc { get; set; }
        public string[] editors { get; set; }
        public string image_ingredients_url { get; set; }
        public string generic_name { get; set; }
        public string[] nutrient_levels_tags { get; set; }
        public int ingredients_n { get; set; }
        public string product_name_en { get; set; }
        public string[] entry_dates_tags { get; set; }
        public int ingredients_percent_analysis { get; set; }
        public string creator { get; set; }
        public object[] checkers { get; set; }
        public string allergens_from_user { get; set; }
        public string categories_lc { get; set; }
        public string id { get; set; }
        public string origins_lc { get; set; }
        public int complete { get; set; }
        public string[] informers_tags { get; set; }
        public object[] cities_tags { get; set; }
        public object[] origins_tags { get; set; }
        public string ingredients_text_debug { get; set; }
        public string[] nova_groups_tags { get; set; }
        public string link { get; set; }
        public string[] popularity_tags { get; set; }
        public string[] data_quality_info_tags { get; set; }
        public string traces_from_user { get; set; }
        public Source[] sources { get; set; }
        public string[] additives_old_tags { get; set; }
        public string[] allergens_tags { get; set; }
        public string countries { get; set; }
        public string image_thumb_url { get; set; }
        public object[] nucleotides_tags { get; set; }
        public string nova_group_debug { get; set; }
        public string image_url { get; set; }
        public object[] emb_codes_tags { get; set; }
        public int additives_old_n { get; set; }
        public string brands { get; set; }
        public float completeness { get; set; }
        public string allergens_from_ingredients { get; set; }
        public int known_ingredients_n { get; set; }
        public string pnns_groups_1 { get; set; }
        public string serving_size { get; set; }
        public string image_ingredients_thumb_url { get; set; }
        public string nova_groups { get; set; }
        public string[] ingredients_ids_debug { get; set; }
        public object[] labels_tags { get; set; }
        public string compared_to_category { get; set; }
        public string pnns_groups_2 { get; set; }
        public string image_front_small_url { get; set; }
        public string[] ingredients_original_tags { get; set; }
        public Languages_Codes languages_codes { get; set; }
        public string allergens { get; set; }
        public long popularity_key { get; set; }
        public Images images { get; set; }
        public object[] nucleotides_prev_tags { get; set; }
        public int nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients_value { get; set; }
        public string serving_quantity { get; set; }
        public Languages languages { get; set; }
        public string code { get; set; }
        public object[] vitamins_tags { get; set; }
        public string image_nutrition_thumb_url { get; set; }
        public string product_name { get; set; }
        public string[] purchase_places_tags { get; set; }
        public int new_additives_n { get; set; }
        public string traces_from_ingredients { get; set; }
        public object[] informers { get; set; }
        public object[] other_nutritional_substances_tags { get; set; }
        public string generic_name_fr { get; set; }
        public string countries_lc { get; set; }
        public string[] ingredients_tags { get; set; }
        public string[] categories_tags { get; set; }
        public string[] allergens_hierarchy { get; set; }
        public int unknown_ingredients_n { get; set; }
        public object[] correctors { get; set; }
        public int fruitsvegetablesnuts_100g_estimate { get; set; }
        public string[] packaging_tags { get; set; }
        public string ingredients_text_with_allergens { get; set; }
        public string image_front_url { get; set; }
        public int scans_n { get; set; }
        public string labels_lc { get; set; }
        public string labels { get; set; }
        public string max_imgid { get; set; }
        public string[] data_quality_warnings_tags { get; set; }
        public object[] manufacturing_places_tags { get; set; }
        public int nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients { get; set; }
        public string categories_old { get; set; }
        public string states { get; set; }
        public Nutriments nutriments { get; set; }
        public string nutrition_grades { get; set; }
        public string image_small_url { get; set; }
        public string emb_codes_20141016 { get; set; }
        public string[] additives_original_tags { get; set; }
        public Nutrient_Levels nutrient_levels { get; set; }
        public string image_front_thumb_url { get; set; }
        public string[] stores_tags { get; set; }
        public string[] misc_tags { get; set; }
        public object[] checkers_tags { get; set; }
        public string _id { get; set; }
        public string image_ingredients_small_url { get; set; }
        public int ingredients_from_or_that_may_be_from_palm_oil_n { get; set; }
        public string ingredients_text { get; set; }
        public object[] traces_tags { get; set; }
        public Selected_Images selected_images { get; set; }
        public string interface_version_modified { get; set; }
        public int last_modified_t { get; set; }
        public object[] data_quality_errors_tags { get; set; }
        public string nutrition_data { get; set; }
        public string[] last_edit_dates_tags { get; set; }
        public string data_sources { get; set; }
        public string[] ingredients_analysis_tags { get; set; }
        public string product_quantity { get; set; }
        public string nutrition_data_per { get; set; }
        public string expiration_date { get; set; }
        public Category_Properties category_properties { get; set; }
        public string[] ingredients_n_tags { get; set; }
        public string[] ingredients_debug { get; set; }
        public string[] additives_tags { get; set; }
        public string[] ingredients_hierarchy { get; set; }
        public string[] _keywords { get; set; }
        public string product_name_fr { get; set; }
        public string nutrition_data_prepared_per { get; set; }
        public string packaging { get; set; }
        public Ingredient[] ingredients { get; set; }
        public string nutrition_grade_fr { get; set; }
        public string manufacturing_places { get; set; }
        public string origins_old { get; set; }
        public string[] categories_properties_tags { get; set; }
        public object[] ingredients_that_may_be_from_palm_oil_tags { get; set; }
        public object[] traces_hierarchy { get; set; }
        public string[] languages_tags { get; set; }
        public string ingredients_text_with_allergens_en { get; set; }
        public int nutrition_score_beverage { get; set; }
        public object[] photographers { get; set; }
        public string[] photographers_tags { get; set; }
        public string emb_codes { get; set; }
        public object[] amino_acids_prev_tags { get; set; }
        public object[] data_quality_bugs_tags { get; set; }
        public string[] brands_tags { get; set; }
        public string ingredients_text_en { get; set; }
        public int ingredients_from_palm_oil_n { get; set; }
        public string quantity { get; set; }
        public string[] correctors_tags { get; set; }
        public object[] ingredients_from_palm_oil_tags { get; set; }
        public object[] labels_hierarchy { get; set; }
        public int ingredients_that_may_be_from_palm_oil_n { get; set; }
    }

    public class Nutriscore_Data
    {
        public int sodium { get; set; }
        public int proteins { get; set; }
        public int saturated_fat { get; set; }
        public int sugars_points { get; set; }
        public int positive_points { get; set; }
        public int energy { get; set; }
        public int sodium_points { get; set; }
        public int is_water { get; set; }
        public int fiber { get; set; }
        public int is_cheese { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils { get; set; }
        public int score { get; set; }
        public int saturated_fat_ratio_value { get; set; }
        public int proteins_points { get; set; }
        public int is_beverage { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils_points { get; set; }
        public float sugars_value { get; set; }
        public float sugars { get; set; }
        public int saturated_fat_ratio { get; set; }
        public int fiber_value { get; set; }
        public int energy_value { get; set; }
        public int energy_points { get; set; }
        public int sodium_value { get; set; }
        public int saturated_fat_ratio_points { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils_value { get; set; }
        public int fiber_points { get; set; }
        public string grade { get; set; }
        public int proteins_value { get; set; }
        public int negative_points { get; set; }
        public int is_fat { get; set; }
        public int saturated_fat_points { get; set; }
        public int saturated_fat_value { get; set; }
    }

    public class Categories_Properties
    {
        public string ciqual_food_codeen { get; set; }
        public string agribalyse_proxy_food_codeen { get; set; }
    }

    public class Languages_Codes
    {
        public int en { get; set; }
        public int fr { get; set; }
    }

    public class Images
    {
        public _25 _25 { get; set; }
        public _1 _1 { get; set; }
        public _4 _4 { get; set; }
        public _26 _26 { get; set; }
        public _15 _15 { get; set; }
        public _10 _10 { get; set; }
        public Ingredients ingredients { get; set; }
        public Front front { get; set; }
        public Nutrition nutrition { get; set; }
        public _3 _3 { get; set; }
        public _14 _14 { get; set; }
        public _18 _18 { get; set; }
        public _5 _5 { get; set; }
        public _22 _22 { get; set; }
        public _8 _8 { get; set; }
        public _2 _2 { get; set; }
        public _13 _13 { get; set; }
        public _11 _11 { get; set; }
        public _19 _19 { get; set; }
        public Nutrition_Fr nutrition_fr { get; set; }
        public _20 _20 { get; set; }
        public _21 _21 { get; set; }
        public _12 _12 { get; set; }
        public _6 _6 { get; set; }
        public Front_Fr front_fr { get; set; }
        public Ingredients_Fr ingredients_fr { get; set; }
        public _27 _27 { get; set; }
        public _7 _7 { get; set; }
        public _17 _17 { get; set; }
        public _9 _9 { get; set; }
        public _23 _23 { get; set; }
        public _16 _16 { get; set; }
        public _24 _24 { get; set; }
    }

    public class _25
    {
        public int uploaded_t { get; set; }
        public Sizes sizes { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes
    {
        public _100 _100 { get; set; }
        public Full full { get; set; }
        public _400 _400 { get; set; }
    }

    public class _100
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _400
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _1
    {
        public int uploaded_t { get; set; }
        public Sizes1 sizes { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes1
    {
        public _1001 _100 { get; set; }
        public _4001 _400 { get; set; }
        public Full1 full { get; set; }
    }

    public class _1001
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _4001
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full1
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _4
    {
        public Sizes2 sizes { get; set; }
        public string uploader { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes2
    {
        public _1002 _100 { get; set; }
        public _4002 _400 { get; set; }
        public Full2 full { get; set; }
    }

    public class _1002
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4002
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full2
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _26
    {
        public string uploader { get; set; }
        public Sizes3 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes3
    {
        public Full3 full { get; set; }
        public _4003 _400 { get; set; }
        public _1003 _100 { get; set; }
    }

    public class Full3
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _4003
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _1003
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _15
    {
        public string uploader { get; set; }
        public Sizes4 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes4
    {
        public Full4 full { get; set; }
        public _4004 _400 { get; set; }
        public _1004 _100 { get; set; }
    }

    public class Full4
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4004
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _1004
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10
    {
        public string uploaded_t { get; set; }
        public Sizes5 sizes { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes5
    {
        public _4005 _400 { get; set; }
        public Full5 full { get; set; }
        public _1005 _100 { get; set; }
    }

    public class _4005
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full5
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _1005
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Ingredients
    {
        public Sizes6 sizes { get; set; }
        public string rev { get; set; }
        public string geometry { get; set; }
        public string normalize { get; set; }
        public object white_magic { get; set; }
        public string imgid { get; set; }
    }

    public class Sizes6
    {
        public Full6 full { get; set; }
        public _4006 _400 { get; set; }
        public _1006 _100 { get; set; }
        public _200 _200 { get; set; }
    }

    public class Full6
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4006
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _1006
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _200
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Front
    {
        public string imgid { get; set; }
        public string normalize { get; set; }
        public string white_magic { get; set; }
        public string rev { get; set; }
        public string geometry { get; set; }
        public Sizes7 sizes { get; set; }
    }

    public class Sizes7
    {
        public Full7 full { get; set; }
        public _4007 _400 { get; set; }
        public _1007 _100 { get; set; }
        public _2001 _200 { get; set; }
    }

    public class Full7
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _4007
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _1007
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _2001
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Nutrition
    {
        public string imgid { get; set; }
        public string white_magic { get; set; }
        public string normalize { get; set; }
        public string geometry { get; set; }
        public string rev { get; set; }
        public Sizes8 sizes { get; set; }
    }

    public class Sizes8
    {
        public Full8 full { get; set; }
        public _4008 _400 { get; set; }
        public _2002 _200 { get; set; }
        public _1008 _100 { get; set; }
    }

    public class Full8
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _4008
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _2002
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _1008
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _3
    {
        public string uploader { get; set; }
        public Sizes9 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes9
    {
        public _1009 _100 { get; set; }
        public Full9 full { get; set; }
        public _4009 _400 { get; set; }
    }

    public class _1009
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full9
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _4009
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _14
    {
        public string uploader { get; set; }
        public Sizes10 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes10
    {
        public _10010 _100 { get; set; }
        public Full10 full { get; set; }
        public _40010 _400 { get; set; }
    }

    public class _10010
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full10
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40010
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _18
    {
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
        public Sizes11 sizes { get; set; }
    }

    public class Sizes11
    {
        public _10011 _100 { get; set; }
        public Full11 full { get; set; }
        public _40011 _400 { get; set; }
    }

    public class _10011
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full11
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40011
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _5
    {
        public string uploader { get; set; }
        public Sizes12 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes12
    {
        public _40012 _400 { get; set; }
        public Full12 full { get; set; }
        public _10012 _100 { get; set; }
    }

    public class _40012
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full12
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10012
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _22
    {
        public int uploaded_t { get; set; }
        public Sizes13 sizes { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes13
    {
        public _10013 _100 { get; set; }
        public _40013 _400 { get; set; }
        public Full13 full { get; set; }
    }

    public class _10013
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40013
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full13
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _8
    {
        public string uploaded_t { get; set; }
        public string uploader { get; set; }
        public Sizes14 sizes { get; set; }
    }

    public class Sizes14
    {
        public _10014 _100 { get; set; }
        public Full14 full { get; set; }
        public _40014 _400 { get; set; }
    }

    public class _10014
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full14
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40014
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _2
    {
        public string uploader { get; set; }
        public Sizes15 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes15
    {
        public Full15 full { get; set; }
        public _40015 _400 { get; set; }
        public _10015 _100 { get; set; }
    }

    public class Full15
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40015
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10015
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _13
    {
        public string uploader { get; set; }
        public Sizes16 sizes { get; set; }
        public string uploaded_t { get; set; }
    }

    public class Sizes16
    {
        public Full16 full { get; set; }
        public _40016 _400 { get; set; }
        public _10016 _100 { get; set; }
    }

    public class Full16
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40016
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10016
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _11
    {
        public string uploader { get; set; }
        public Sizes17 sizes { get; set; }
        public string uploaded_t { get; set; }
    }

    public class Sizes17
    {
        public _40017 _400 { get; set; }
        public Full17 full { get; set; }
        public _10017 _100 { get; set; }
    }

    public class _40017
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full17
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10017
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _19
    {
        public string uploader { get; set; }
        public Sizes18 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes18
    {
        public _40018 _400 { get; set; }
        public Full18 full { get; set; }
        public _10018 _100 { get; set; }
    }

    public class _40018
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full18
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10018
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Nutrition_Fr
    {
        public object x2 { get; set; }
        public Sizes19 sizes { get; set; }
        public object y1 { get; set; }
        public string rev { get; set; }
        public string imgid { get; set; }
        public object angle { get; set; }
        public object y2 { get; set; }
        public string geometry { get; set; }
        public object x1 { get; set; }
        public object white_magic { get; set; }
        public object normalize { get; set; }
    }

    public class Sizes19
    {
        public _2003 _200 { get; set; }
        public _10019 _100 { get; set; }
        public _40019 _400 { get; set; }
        public Full19 full { get; set; }
    }

    public class _2003
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10019
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40019
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full19
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _20
    {
        public Sizes20 sizes { get; set; }
        public string uploader { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes20
    {
        public _10020 _100 { get; set; }
        public _40020 _400 { get; set; }
        public Full20 full { get; set; }
    }

    public class _10020
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40020
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full20
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _21
    {
        public Sizes21 sizes { get; set; }
        public string uploader { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes21
    {
        public _40021 _400 { get; set; }
        public Full21 full { get; set; }
        public _10021 _100 { get; set; }
    }

    public class _40021
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full21
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10021
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _12
    {
        public Sizes22 sizes { get; set; }
        public string uploader { get; set; }
        public string uploaded_t { get; set; }
    }

    public class Sizes22
    {
        public Full22 full { get; set; }
        public _40022 _400 { get; set; }
        public _10022 _100 { get; set; }
    }

    public class Full22
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40022
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10022
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _6
    {
        public Sizes23 sizes { get; set; }
        public string uploader { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes23
    {
        public _40023 _400 { get; set; }
        public Full23 full { get; set; }
        public _10023 _100 { get; set; }
    }

    public class _40023
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full23
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10023
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Front_Fr
    {
        public string geometry { get; set; }
        public object x1 { get; set; }
        public object normalize { get; set; }
        public object white_magic { get; set; }
        public object x2 { get; set; }
        public Sizes24 sizes { get; set; }
        public string rev { get; set; }
        public object y1 { get; set; }
        public object angle { get; set; }
        public object y2 { get; set; }
        public string imgid { get; set; }
    }

    public class Sizes24
    {
        public _40024 _400 { get; set; }
        public Full24 full { get; set; }
        public _10024 _100 { get; set; }
        public _2004 _200 { get; set; }
    }

    public class _40024
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full24
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10024
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _2004
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Ingredients_Fr
    {
        public object y2 { get; set; }
        public object angle { get; set; }
        public string imgid { get; set; }
        public object x2 { get; set; }
        public Sizes25 sizes { get; set; }
        public object y1 { get; set; }
        public string rev { get; set; }
        public string orientation { get; set; }
        public object x1 { get; set; }
        public string normalize { get; set; }
        public string white_magic { get; set; }
        public int ocr { get; set; }
        public string geometry { get; set; }
    }

    public class Sizes25
    {
        public _2005 _200 { get; set; }
        public _10025 _100 { get; set; }
        public _40025 _400 { get; set; }
        public Full25 full { get; set; }
    }

    public class _2005
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10025
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40025
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full25
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _27
    {
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
        public Sizes26 sizes { get; set; }
    }

    public class Sizes26
    {
        public _10026 _100 { get; set; }
        public _40026 _400 { get; set; }
        public Full26 full { get; set; }
    }

    public class _10026
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40026
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full26
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _7
    {
        public string uploaded_t { get; set; }
        public Sizes27 sizes { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes27
    {
        public _10027 _100 { get; set; }
        public Full27 full { get; set; }
        public _40027 _400 { get; set; }
    }

    public class _10027
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full27
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40027
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _17
    {
        public int uploaded_t { get; set; }
        public Sizes28 sizes { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes28
    {
        public _10028 _100 { get; set; }
        public Full28 full { get; set; }
        public _40028 _400 { get; set; }
    }

    public class _10028
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full28
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40028
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _9
    {
        public string uploaded_t { get; set; }
        public string uploader { get; set; }
        public Sizes29 sizes { get; set; }
    }

    public class Sizes29
    {
        public Full29 full { get; set; }
        public _40029 _400 { get; set; }
        public _10029 _100 { get; set; }
    }

    public class Full29
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40029
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10029
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _23
    {
        public string uploader { get; set; }
        public Sizes30 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes30
    {
        public _40030 _400 { get; set; }
        public Full30 full { get; set; }
        public _10030 _100 { get; set; }
    }

    public class _40030
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full30
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10030
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _16
    {
        public string uploader { get; set; }
        public Sizes31 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes31
    {
        public _40031 _400 { get; set; }
        public Full31 full { get; set; }
        public _10031 _100 { get; set; }
    }

    public class _40031
    {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full31
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _10031
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _24
    {
        public string uploader { get; set; }
        public Sizes32 sizes { get; set; }
        public int uploaded_t { get; set; }
    }

    public class Sizes32
    {
        public _10032 _100 { get; set; }
        public _40032 _400 { get; set; }
        public Full32 full { get; set; }
    }

    public class _10032
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class _40032
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Full32
    {
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Languages
    {
        public int enfrench { get; set; }
        public int enenglish { get; set; }
    }

    public class Nutriments
    {
        public int nutritionscorefr_100g { get; set; }
        public int proteins_100g { get; set; }
        public float carbohydrates_value { get; set; }
        public int saturatedfat_100g { get; set; }
        public string sugars_unit { get; set; }
        public string energykcal_unit { get; set; }
        public float carbohydrates { get; set; }
        public int energy { get; set; }
        public float sugars_100g { get; set; }
        public int fat { get; set; }
        public int energy_100g { get; set; }
        public int fat_100g { get; set; }
        public string carbohydrates_unit { get; set; }
        public int energykcal_100g { get; set; }
        public int proteins { get; set; }
        public string energy_unit { get; set; }
        public string sodium_unit { get; set; }
        public int sodium { get; set; }
        public int fat_serving { get; set; }
        public int saturatedfat { get; set; }
        public string proteins_unit { get; set; }
        public int proteins_serving { get; set; }
        public int salt_100g { get; set; }
        public int energykcal { get; set; }
        public string saturatedfat_unit { get; set; }
        public int energy_serving { get; set; }
        public int sodium_100g { get; set; }
        public int fat_value { get; set; }
        public int saturatedfat_value { get; set; }
        public int salt_value { get; set; }
        public int sodium_serving { get; set; }
        public int proteins_value { get; set; }
        public int sugars_serving { get; set; }
        public int novagroup_serving { get; set; }
        public int energykcal_serving { get; set; }
        public int salt { get; set; }
        public int energy_value { get; set; }
        public int novagroup { get; set; }
        public int nutritionscorefr { get; set; }
        public int sodium_value { get; set; }
        public int novagroup_100g { get; set; }
        public int energykcal_value { get; set; }
        public string fat_unit { get; set; }
        public int fruitsvegetablesnutsestimatefromingredients_100g { get; set; }
        public int saturatedfat_serving { get; set; }
        public int carbohydrates_serving { get; set; }
        public string salt_unit { get; set; }
        public float sugars { get; set; }
        public float carbohydrates_100g { get; set; }
        public float sugars_value { get; set; }
        public int salt_serving { get; set; }
    }

    public class Nutrient_Levels
    {
        public string fat { get; set; }
        public string saturatedfat { get; set; }
        public string salt { get; set; }
        public string sugars { get; set; }
    }

    public class Selected_Images
    {
        public Front1 front { get; set; }
        public Ingredients1 ingredients { get; set; }
        public Nutrition1 nutrition { get; set; }
    }

    public class Front1
    {
        public Display display { get; set; }
        public Thumb thumb { get; set; }
        public Small small { get; set; }
    }

    public class Display
    {
        public string fr { get; set; }
    }

    public class Thumb
    {
        public string fr { get; set; }
    }

    public class Small
    {
        public string fr { get; set; }
    }

    public class Ingredients1
    {
        public Display1 display { get; set; }
        public Small1 small { get; set; }
        public Thumb1 thumb { get; set; }
    }

    public class Display1
    {
        public string fr { get; set; }
    }

    public class Small1
    {
        public string fr { get; set; }
    }

    public class Thumb1
    {
        public string fr { get; set; }
    }

    public class Nutrition1
    {
        public Small2 small { get; set; }
        public Thumb2 thumb { get; set; }
        public Display2 display { get; set; }
    }

    public class Small2
    {
        public string fr { get; set; }
    }

    public class Thumb2
    {
        public string fr { get; set; }
    }

    public class Display2
    {
        public string fr { get; set; }
    }

    public class Category_Properties
    {
        public string ciqual_food_namefr { get; set; }
        public string ciqual_food_nameen { get; set; }
    }

    public class Source
    {
        public string source_licence { get; set; }
        public object[] images { get; set; }
        public string source_licence_url { get; set; }
        public string[] fields { get; set; }
        public int import_t { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string manufacturer { get; set; }
        public string url { get; set; }
    }

    public class Ingredient
    {
        public int rank { get; set; }
        public float percent_max { get; set; }
        public string vegan { get; set; }
        public string vegetarian { get; set; }
        public string text { get; set; }
        public string id { get; set; }
        public int percent_min { get; set; }
        public int percent_estimate { get; set; }
        public string has_sub_ingredients { get; set; }
    }

}
