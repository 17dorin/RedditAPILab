﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPILab.Models
{

    public class Reddit
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string modhash { get; set; }
        public int dist { get; set; }
        public Child[] children { get; set; }
        public string after { get; set; }
        public object before { get; set; }
    }

    public class Child
    {
        public string kind { get; set; }
        public Data1 data { get; set; }
    }

    public class Data1
    {
        public object approved_at_utc { get; set; }
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public object mod_reason_title { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public Link_Flair_Richtext[] link_flair_richtext { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
        public int pwls { get; set; }
        public string link_flair_css_class { get; set; }
        public int downs { get; set; }
        public int? thumbnail_height { get; set; }
        public object top_awarded_type { get; set; }
        public bool hide_score { get; set; }
        public string name { get; set; }
        public bool quarantine { get; set; }
        public string link_flair_text_color { get; set; }
        public float upvote_ratio { get; set; }
        public string author_flair_background_color { get; set; }
        public string subreddit_type { get; set; }
        public int ups { get; set; }
        public int total_awards_received { get; set; }
        public Media_Embed media_embed { get; set; }
        public int? thumbnail_width { get; set; }
        public string author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public object[] user_reports { get; set; }
        public object secure_media { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        public object category { get; set; }
        public Secure_Media_Embed secure_media_embed { get; set; }
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public object approved_by { get; set; }
        public bool author_premium { get; set; }
        public string thumbnail { get; set; }
        public bool edited { get; set; }
        public string author_flair_css_class { get; set; }
        public Author_Flair_Richtext[] author_flair_richtext { get; set; }
        public Gildings gildings { get; set; }
        public object content_categories { get; set; }
        public bool is_self { get; set; }
        public object mod_note { get; set; }
        public float created { get; set; }
        public string link_flair_type { get; set; }
        public int wls { get; set; }
        public object removed_by_category { get; set; }
        public object banned_by { get; set; }
        public string author_flair_type { get; set; }
        public string domain { get; set; }
        public bool allow_live_comments { get; set; }
        public string selftext_html { get; set; }
        public object likes { get; set; }
        public string suggested_sort { get; set; }
        public object banned_at_utc { get; set; }
        public object view_count { get; set; }
        public bool archived { get; set; }
        public bool no_follow { get; set; }
        public bool is_crosspostable { get; set; }
        public bool pinned { get; set; }
        public bool over_18 { get; set; }
        public All_Awardings[] all_awardings { get; set; }
        public object[] awarders { get; set; }
        public bool media_only { get; set; }
        public string link_flair_template_id { get; set; }
        public bool can_gild { get; set; }
        public bool spoiler { get; set; }
        public bool locked { get; set; }
        public string author_flair_text { get; set; }
        public object[] treatment_tags { get; set; }
        public bool visited { get; set; }
        public object removed_by { get; set; }
        public object num_reports { get; set; }
        public string distinguished { get; set; }
        public string subreddit_id { get; set; }
        public object mod_reason_by { get; set; }
        public object removal_reason { get; set; }
        public string link_flair_background_color { get; set; }
        public string id { get; set; }
        public bool is_robot_indexable { get; set; }
        public object report_reasons { get; set; }
        public string author { get; set; }
        public object discussion_type { get; set; }
        public int num_comments { get; set; }
        public bool send_replies { get; set; }
        public string whitelist_status { get; set; }
        public bool contest_mode { get; set; }
        public object[] mod_reports { get; set; }
        public bool author_patreon_flair { get; set; }
        public string author_flair_text_color { get; set; }
        public string permalink { get; set; }
        public string parent_whitelist_status { get; set; }
        public bool stickied { get; set; }
        public string url { get; set; }
        public int subreddit_subscribers { get; set; }
        public float created_utc { get; set; }
        public int num_crossposts { get; set; }
        public object media { get; set; }
        public bool is_video { get; set; }
        public string post_hint { get; set; }
        public Preview preview { get; set; }
        public bool is_gallery { get; set; }
        public Media_Metadata media_metadata { get; set; }
        public Gallery_Data gallery_data { get; set; }
        public string url_overridden_by_dest { get; set; }
    }

    public class Media_Embed
    {
    }

    public class Secure_Media_Embed
    {
    }

    public class Gildings
    {
        public int gid_1 { get; set; }
        public int gid_2 { get; set; }
    }

    public class Preview
    {
        public Image[] images { get; set; }
        public bool enabled { get; set; }
    }

    public class Image
    {
        public Source source { get; set; }
        public Resolution[] resolutions { get; set; }
        public Variants variants { get; set; }
        public string id { get; set; }
    }

    public class Source
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Variants
    {
    }

    public class Resolution
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Media_Metadata
    {
        public _09Cgccu5gek61 _09cgccu5gek61 { get; set; }
        public _8W3l4sdagek61 _8w3l4sdagek61 { get; set; }
        public Rsx0bqb9gek61 rsx0bqb9gek61 { get; set; }
        public _6Ofw44m8gek61 _6ofw44m8gek61 { get; set; }
        public _5L0cu5jbgek61 _5l0cu5jbgek61 { get; set; }
        public J3vj87i6gek61 j3vj87i6gek61 { get; set; }
        public Icykd6a7gek61 icykd6a7gek61 { get; set; }
        public _4Sp8dck7gek61 _4sp8dck7gek61 { get; set; }
        public Thal5djy9ek61 thal5djy9ek61 { get; set; }
        public _513Ddnuy9ek61 _513ddnuy9ek61 { get; set; }
        public Sdst0rfbudk61 sdst0rfbudk61 { get; set; }
        public _29Yt86u8udk61 _29yt86u8udk61 { get; set; }
        public Qje82azaudk61 qje82azaudk61 { get; set; }
        public Kuwqbzhaudk61 kuwqbzhaudk61 { get; set; }
        public V3zeg54ihgk61 v3zeg54ihgk61 { get; set; }
        public Egmau6whhgk61 egmau6whhgk61 { get; set; }
        public Zbwymnvnqek61 zbwymnvnqek61 { get; set; }
        public _7Pctqovnqek61 _7pctqovnqek61 { get; set; }
        public Wftqpovnqek61 wftqpovnqek61 { get; set; }
        public Kfg2tovnqek61 kfg2tovnqek61 { get; set; }
        public L5iziovnqek61 l5iziovnqek61 { get; set; }
        public Xyzrdh2krek61 xyzrdh2krek61 { get; set; }
        public V0dehyrjrek61 v0dehyrjrek61 { get; set; }
        public _1Jn8gldkrek61 _1jn8gldkrek61 { get; set; }
        public A01sr6cirfk61 a01sr6cirfk61 { get; set; }
        public Pgifcf3irfk61 pgifcf3irfk61 { get; set; }
        public _81H434fxdak61 _81h434fxdak61 { get; set; }
        public Vttmmr4xdak61 vttmmr4xdak61 { get; set; }
        public _95Nytvoxdak61 _95nytvoxdak61 { get; set; }
        public J88k94axdak61 j88k94axdak61 { get; set; }
        public _3Os4hukxdak61 _3os4hukxdak61 { get; set; }
    }

    public class _09Cgccu5gek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P[] p { get; set; }
        public S s { get; set; }
        public string id { get; set; }
    }

    public class S
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _8W3l4sdagek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P1[] p { get; set; }
        public S1 s { get; set; }
        public string id { get; set; }
    }

    public class S1
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P1
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Rsx0bqb9gek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P2[] p { get; set; }
        public S2 s { get; set; }
        public string id { get; set; }
    }

    public class S2
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P2
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _6Ofw44m8gek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P3[] p { get; set; }
        public S3 s { get; set; }
        public string id { get; set; }
    }

    public class S3
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P3
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _5L0cu5jbgek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P4[] p { get; set; }
        public S4 s { get; set; }
        public string id { get; set; }
    }

    public class S4
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P4
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class J3vj87i6gek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P5[] p { get; set; }
        public S5 s { get; set; }
        public string id { get; set; }
    }

    public class S5
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P5
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Icykd6a7gek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P6[] p { get; set; }
        public S6 s { get; set; }
        public string id { get; set; }
    }

    public class S6
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P6
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _4Sp8dck7gek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P7[] p { get; set; }
        public S7 s { get; set; }
        public string id { get; set; }
    }

    public class S7
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P7
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Thal5djy9ek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P8[] p { get; set; }
        public S8 s { get; set; }
        public string id { get; set; }
    }

    public class S8
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P8
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _513Ddnuy9ek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P9[] p { get; set; }
        public S9 s { get; set; }
        public string id { get; set; }
    }

    public class S9
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P9
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Sdst0rfbudk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P10[] p { get; set; }
        public S10 s { get; set; }
        public string id { get; set; }
    }

    public class S10
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P10
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _29Yt86u8udk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P11[] p { get; set; }
        public S11 s { get; set; }
        public string id { get; set; }
    }

    public class S11
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P11
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Qje82azaudk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P12[] p { get; set; }
        public S12 s { get; set; }
        public string id { get; set; }
    }

    public class S12
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P12
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Kuwqbzhaudk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P13[] p { get; set; }
        public S13 s { get; set; }
        public string id { get; set; }
    }

    public class S13
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P13
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class V3zeg54ihgk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P14[] p { get; set; }
        public S14 s { get; set; }
        public string id { get; set; }
    }

    public class S14
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P14
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Egmau6whhgk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P15[] p { get; set; }
        public S15 s { get; set; }
        public string id { get; set; }
    }

    public class S15
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P15
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Zbwymnvnqek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P16[] p { get; set; }
        public S16 s { get; set; }
        public string id { get; set; }
    }

    public class S16
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P16
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _7Pctqovnqek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P17[] p { get; set; }
        public S17 s { get; set; }
        public string id { get; set; }
    }

    public class S17
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P17
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Wftqpovnqek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P18[] p { get; set; }
        public S18 s { get; set; }
        public string id { get; set; }
    }

    public class S18
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P18
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Kfg2tovnqek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P19[] p { get; set; }
        public S19 s { get; set; }
        public string id { get; set; }
    }

    public class S19
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P19
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class L5iziovnqek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P20[] p { get; set; }
        public S20 s { get; set; }
        public string id { get; set; }
    }

    public class S20
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P20
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Xyzrdh2krek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P21[] p { get; set; }
        public S21 s { get; set; }
        public string id { get; set; }
    }

    public class S21
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P21
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class V0dehyrjrek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P22[] p { get; set; }
        public S22 s { get; set; }
        public string id { get; set; }
    }

    public class S22
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P22
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _1Jn8gldkrek61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P23[] p { get; set; }
        public S23 s { get; set; }
        public string id { get; set; }
    }

    public class S23
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P23
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class A01sr6cirfk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P24[] p { get; set; }
        public S24 s { get; set; }
        public string id { get; set; }
    }

    public class S24
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P24
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Pgifcf3irfk61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P25[] p { get; set; }
        public S25 s { get; set; }
        public string id { get; set; }
    }

    public class S25
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P25
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _81H434fxdak61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P26[] p { get; set; }
        public S26 s { get; set; }
        public string id { get; set; }
    }

    public class S26
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P26
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Vttmmr4xdak61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P27[] p { get; set; }
        public S27 s { get; set; }
        public string id { get; set; }
    }

    public class S27
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P27
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _95Nytvoxdak61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P28[] p { get; set; }
        public S28 s { get; set; }
        public string id { get; set; }
    }

    public class S28
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P28
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class J88k94axdak61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P29[] p { get; set; }
        public S29 s { get; set; }
        public string id { get; set; }
    }

    public class S29
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P29
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class _3Os4hukxdak61
    {
        public string status { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public P30[] p { get; set; }
        public S30 s { get; set; }
        public string id { get; set; }
    }

    public class S30
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class P30
    {
        public int y { get; set; }
        public int x { get; set; }
        public string u { get; set; }
    }

    public class Gallery_Data
    {
        public Item[] items { get; set; }
    }

    public class Item
    {
        public string media_id { get; set; }
        public int id { get; set; }
    }

    public class Link_Flair_Richtext
    {
        public string e { get; set; }
        public string t { get; set; }
    }

    public class Author_Flair_Richtext
    {
        public string a { get; set; }
        public string e { get; set; }
        public string u { get; set; }
    }

    public class All_Awardings
    {
        public int? giver_coin_reward { get; set; }
        public object subreddit_id { get; set; }
        public bool is_new { get; set; }
        public int days_of_drip_extension { get; set; }
        public int coin_price { get; set; }
        public string id { get; set; }
        public int? penny_donate { get; set; }
        public string award_sub_type { get; set; }
        public int coin_reward { get; set; }
        public string icon_url { get; set; }
        public int days_of_premium { get; set; }
        public object tiers_by_required_awardings { get; set; }
        public Resized_Icons[] resized_icons { get; set; }
        public int icon_width { get; set; }
        public int static_icon_width { get; set; }
        public object start_date { get; set; }
        public bool is_enabled { get; set; }
        public object awardings_required_to_grant_benefits { get; set; }
        public string description { get; set; }
        public object end_date { get; set; }
        public int subreddit_coin_reward { get; set; }
        public int count { get; set; }
        public int static_icon_height { get; set; }
        public string name { get; set; }
        public Resized_Static_Icons[] resized_static_icons { get; set; }
        public string icon_format { get; set; }
        public int icon_height { get; set; }
        public int? penny_price { get; set; }
        public string award_type { get; set; }
        public string static_icon_url { get; set; }
    }

    public class Resized_Icons
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Resized_Static_Icons
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

}
