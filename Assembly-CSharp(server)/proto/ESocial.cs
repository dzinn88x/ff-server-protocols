using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006C6 RID: 1734
	[Token(Token = "0x20006C6")]
	[ProtoContract]
	public class ESocial
	{
		// Token: 0x060023E0 RID: 9184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x21B9B44", Offset = "0x21B9B44", VA = "0x7BBC9B9B44")]
		public ESocial()
		{
		}

		// Token: 0x020006C7 RID: 1735
		[Token(Token = "0x20006C7")]
		[ProtoContract]
		public enum PlayerBattleTagID
		{
			// Token: 0x040021FD RID: 8701
			[Token(Token = "0x40021FD")]
			PlayerBattleTagID_NONE,
			// Token: 0x040021FE RID: 8702
			[Token(Token = "0x40021FE")]
			PlayerBattleTagID_DOMINATION = 1101,
			// Token: 0x040021FF RID: 8703
			[Token(Token = "0x40021FF")]
			PlayerBattleTagID_UNCROWN,
			// Token: 0x04002200 RID: 8704
			[Token(Token = "0x4002200")]
			PlayerBattleTagID_BESTPARTNER,
			// Token: 0x04002201 RID: 8705
			[Token(Token = "0x4002201")]
			PlayerBattleTagID_SNIPER,
			// Token: 0x04002202 RID: 8706
			[Token(Token = "0x4002202")]
			PlayerBattleTagID_MELEE,
			// Token: 0x04002203 RID: 8707
			[Token(Token = "0x4002203")]
			PlayerBattleTagID_PEACEMAKER,
			// Token: 0x04002204 RID: 8708
			[Token(Token = "0x4002204")]
			PlayerBattleTagID_AMBUSH,
			// Token: 0x04002205 RID: 8709
			[Token(Token = "0x4002205")]
			PlayerBattleTagID_SHORTSTOP
		}

		// Token: 0x020006C8 RID: 1736
		[Token(Token = "0x20006C8")]
		[ProtoContract]
		public enum PlayerBattleTagCdtType
		{
			// Token: 0x04002207 RID: 8711
			[Token(Token = "0x4002207")]
			PlayerBattleTagCdtType_NONE,
			// Token: 0x04002208 RID: 8712
			[Token(Token = "0x4002208")]
			PlayerBattleTagCdtType_BR_RANK_LARGER = 100101,
			// Token: 0x04002209 RID: 8713
			[Token(Token = "0x4002209")]
			PlayerBattleTagCdtType_BR_RANK_SMALLER,
			// Token: 0x0400220A RID: 8714
			[Token(Token = "0x400220A")]
			PlayerBattleTagCdtType_BR_LAST_ELIMINATED = 100201,
			// Token: 0x0400220B RID: 8715
			[Token(Token = "0x400220B")]
			PlayerBattleTagCdtType_BR_KILL_LARGER = 100501,
			// Token: 0x0400220C RID: 8716
			[Token(Token = "0x400220C")]
			PlayerBattleTagCdtType_BR_KILL_SMALLER,
			// Token: 0x0400220D RID: 8717
			[Token(Token = "0x400220D")]
			PlayerBattleTagCdtType_BR_DAMAGE_LARGER = 100601,
			// Token: 0x0400220E RID: 8718
			[Token(Token = "0x400220E")]
			PlayerBattleTagCdtType_BR_DAMAGE_SMALLER,
			// Token: 0x0400220F RID: 8719
			[Token(Token = "0x400220F")]
			PlayerBattleTagCdtType_BR_ASSIST_LARGER = 100701,
			// Token: 0x04002210 RID: 8720
			[Token(Token = "0x4002210")]
			PlayerBattleTagCdtType_BR_ASSIST_SMALLER,
			// Token: 0x04002211 RID: 8721
			[Token(Token = "0x4002211")]
			PlayerBattleTagCdtType_BR_REVIVE_LARGER = 100801,
			// Token: 0x04002212 RID: 8722
			[Token(Token = "0x4002212")]
			PlayerBattleTagCdtType_BR_REVIVE_SMALLER,
			// Token: 0x04002213 RID: 8723
			[Token(Token = "0x4002213")]
			PlayerBattleTagCdtType_BR_DISTANCE_LARGER_PER_MINIUE = 100901,
			// Token: 0x04002214 RID: 8724
			[Token(Token = "0x4002214")]
			PlayerBattleTagCdtType_BR_DISTANCE_SMALLER_PER_MINIUE,
			// Token: 0x04002215 RID: 8725
			[Token(Token = "0x4002215")]
			PlayerBattleTagCdtType_BR_DISTANCE_LARGER = 101001,
			// Token: 0x04002216 RID: 8726
			[Token(Token = "0x4002216")]
			PlayerBattleTagCdtType_BR_DISTANCE_SMALLER,
			// Token: 0x04002217 RID: 8727
			[Token(Token = "0x4002217")]
			PlayerBattleTagCdtType_CS_WIN = 200101,
			// Token: 0x04002218 RID: 8728
			[Token(Token = "0x4002218")]
			PlayerBattleTagCdtType_CS_KILL_MAX = 200201,
			// Token: 0x04002219 RID: 8729
			[Token(Token = "0x4002219")]
			PlayerBattleTagCdtType_CS_DAMAGE_MAX = 200301,
			// Token: 0x0400221A RID: 8730
			[Token(Token = "0x400221A")]
			PlayerBattleTagCdtType_CS_DEATH_PER_ROUND_LARGER = 200401,
			// Token: 0x0400221B RID: 8731
			[Token(Token = "0x400221B")]
			PlayerBattleTagCdtType_CS_DEATH_PER_ROUND_SMALLER,
			// Token: 0x0400221C RID: 8732
			[Token(Token = "0x400221C")]
			PlayerBattleTagCdtType_CS_KILL_PER_ROUND_LARGER = 200501,
			// Token: 0x0400221D RID: 8733
			[Token(Token = "0x400221D")]
			PlayerBattleTagCdtType_CS_KILL_PER_ROUND_SMALLER,
			// Token: 0x0400221E RID: 8734
			[Token(Token = "0x400221E")]
			PlayerBattleTagCdtType_CS_DAMAGE_PER_ROUND_LARGER = 200601,
			// Token: 0x0400221F RID: 8735
			[Token(Token = "0x400221F")]
			PlayerBattleTagCdtType_CS_DAMAGE_PER_ROUND_SMALLER,
			// Token: 0x04002220 RID: 8736
			[Token(Token = "0x4002220")]
			PlayerBattleTagCdtType_CS_ASSIST_PER_ROUND_LARGER = 200701,
			// Token: 0x04002221 RID: 8737
			[Token(Token = "0x4002221")]
			PlayerBattleTagCdtType_CS_ASSIST_PER_ROUND_SMALLER,
			// Token: 0x04002222 RID: 8738
			[Token(Token = "0x4002222")]
			PlayerBattleTagCdtType_CS_REVIVE_PER_ROUND_LARGER = 200801,
			// Token: 0x04002223 RID: 8739
			[Token(Token = "0x4002223")]
			PlayerBattleTagCdtType_CS_REVIVE_PER_ROUND_SMALLER,
			// Token: 0x04002224 RID: 8740
			[Token(Token = "0x4002224")]
			PlayerBattleTagCdtType_CS_DISTANCE_LARGER = 201001,
			// Token: 0x04002225 RID: 8741
			[Token(Token = "0x4002225")]
			PlayerBattleTagCdtType_CS_DISTANCE_SMALLER
		}

		// Token: 0x020006C9 RID: 1737
		[Token(Token = "0x20006C9")]
		[ProtoContract]
		public enum SocialTag
		{
			// Token: 0x04002227 RID: 8743
			[Token(Token = "0x4002227")]
			SocialTag_NONE,
			// Token: 0x04002228 RID: 8744
			[Token(Token = "0x4002228")]
			SocialTag_FASHION = 2101,
			// Token: 0x04002229 RID: 8745
			[Token(Token = "0x4002229")]
			SocialTag_SOCIAL,
			// Token: 0x0400222A RID: 8746
			[Token(Token = "0x400222A")]
			SocialTag_VETERAN,
			// Token: 0x0400222B RID: 8747
			[Token(Token = "0x400222B")]
			SocialTag_NEWBIE,
			// Token: 0x0400222C RID: 8748
			[Token(Token = "0x400222C")]
			SocialTag_PLAYFORWIN,
			// Token: 0x0400222D RID: 8749
			[Token(Token = "0x400222D")]
			SocialTag_PLAYFORFUN,
			// Token: 0x0400222E RID: 8750
			[Token(Token = "0x400222E")]
			SocialTag_VOICEON,
			// Token: 0x0400222F RID: 8751
			[Token(Token = "0x400222F")]
			SocialTag_VOICEOFF
		}

		// Token: 0x020006CA RID: 1738
		[Token(Token = "0x20006CA")]
		[ProtoContract]
		public enum Gender
		{
			// Token: 0x04002231 RID: 8753
			[Token(Token = "0x4002231")]
			Gender_NONE,
			// Token: 0x04002232 RID: 8754
			[Token(Token = "0x4002232")]
			Gender_MALE,
			// Token: 0x04002233 RID: 8755
			[Token(Token = "0x4002233")]
			Gender_FEMALE,
			// Token: 0x04002234 RID: 8756
			[Token(Token = "0x4002234")]
			Gender_UNLIMITED = 999
		}

		// Token: 0x020006CB RID: 1739
		[Token(Token = "0x20006CB")]
		[ProtoContract]
		public enum Language
		{
			// Token: 0x04002236 RID: 8758
			[Token(Token = "0x4002236")]
			Language_NONE,
			// Token: 0x04002237 RID: 8759
			[Token(Token = "0x4002237")]
			Language_EN,
			// Token: 0x04002238 RID: 8760
			[Token(Token = "0x4002238")]
			Language_CN_SIMPLIFIED,
			// Token: 0x04002239 RID: 8761
			[Token(Token = "0x4002239")]
			Language_CN_TRADITIONAL,
			// Token: 0x0400223A RID: 8762
			[Token(Token = "0x400223A")]
			Language_Thai,
			// Token: 0x0400223B RID: 8763
			[Token(Token = "0x400223B")]
			Language_VIETNAMESE,
			// Token: 0x0400223C RID: 8764
			[Token(Token = "0x400223C")]
			Language_INDONESIAN,
			// Token: 0x0400223D RID: 8765
			[Token(Token = "0x400223D")]
			Language_PORTUGUESE,
			// Token: 0x0400223E RID: 8766
			[Token(Token = "0x400223E")]
			Language_SPANISH,
			// Token: 0x0400223F RID: 8767
			[Token(Token = "0x400223F")]
			Language_RUSSIAN,
			// Token: 0x04002240 RID: 8768
			[Token(Token = "0x4002240")]
			Language_KOREAN,
			// Token: 0x04002241 RID: 8769
			[Token(Token = "0x4002241")]
			Language_FRENCH,
			// Token: 0x04002242 RID: 8770
			[Token(Token = "0x4002242")]
			Language_GERMAN,
			// Token: 0x04002243 RID: 8771
			[Token(Token = "0x4002243")]
			Language_TURKISH,
			// Token: 0x04002244 RID: 8772
			[Token(Token = "0x4002244")]
			Language_HINDI,
			// Token: 0x04002245 RID: 8773
			[Token(Token = "0x4002245")]
			Language_JAPANESE,
			// Token: 0x04002246 RID: 8774
			[Token(Token = "0x4002246")]
			Language_ROMANIAN,
			// Token: 0x04002247 RID: 8775
			[Token(Token = "0x4002247")]
			Language_ARABIC,
			// Token: 0x04002248 RID: 8776
			[Token(Token = "0x4002248")]
			Language_BURMESE,
			// Token: 0x04002249 RID: 8777
			[Token(Token = "0x4002249")]
			Language_URDU,
			// Token: 0x0400224A RID: 8778
			[Token(Token = "0x400224A")]
			Language_UNLIMITED = 999
		}

		// Token: 0x020006CC RID: 1740
		[Token(Token = "0x20006CC")]
		[ProtoContract]
		public enum RankShow
		{
			// Token: 0x0400224C RID: 8780
			[Token(Token = "0x400224C")]
			RankShow_NONE,
			// Token: 0x0400224D RID: 8781
			[Token(Token = "0x400224D")]
			RankShow_BR,
			// Token: 0x0400224E RID: 8782
			[Token(Token = "0x400224E")]
			RankShow_CS,
			// Token: 0x0400224F RID: 8783
			[Token(Token = "0x400224F")]
			RankShow_UNLIMITED = 999
		}

		// Token: 0x020006CD RID: 1741
		[Token(Token = "0x20006CD")]
		[ProtoContract]
		public enum TimeOnline
		{
			// Token: 0x04002251 RID: 8785
			[Token(Token = "0x4002251")]
			TimeOnline_NONE,
			// Token: 0x04002252 RID: 8786
			[Token(Token = "0x4002252")]
			TimeOnline_WORKDAY,
			// Token: 0x04002253 RID: 8787
			[Token(Token = "0x4002253")]
			TimeOnline_WEEKEND,
			// Token: 0x04002254 RID: 8788
			[Token(Token = "0x4002254")]
			TimeOnline_UNLIMITED = 999
		}

		// Token: 0x020006CE RID: 1742
		[Token(Token = "0x20006CE")]
		[ProtoContract]
		public enum TimeActive
		{
			// Token: 0x04002256 RID: 8790
			[Token(Token = "0x4002256")]
			TimeActive_NONE,
			// Token: 0x04002257 RID: 8791
			[Token(Token = "0x4002257")]
			TimeActive_MORNING,
			// Token: 0x04002258 RID: 8792
			[Token(Token = "0x4002258")]
			TimeActive_AFTERNOON,
			// Token: 0x04002259 RID: 8793
			[Token(Token = "0x4002259")]
			TimeActive_NIGHT,
			// Token: 0x0400225A RID: 8794
			[Token(Token = "0x400225A")]
			TimeActive_UNLIMITED = 999
		}

		// Token: 0x020006CF RID: 1743
		[Token(Token = "0x20006CF")]
		[ProtoContract]
		public enum ModePrefer
		{
			// Token: 0x0400225C RID: 8796
			[Token(Token = "0x400225C")]
			ModePrefer_NONE,
			// Token: 0x0400225D RID: 8797
			[Token(Token = "0x400225D")]
			ModePrefer_BR,
			// Token: 0x0400225E RID: 8798
			[Token(Token = "0x400225E")]
			ModePrefer_CS,
			// Token: 0x0400225F RID: 8799
			[Token(Token = "0x400225F")]
			ModePrefer_ENTERTAINMENT,
			// Token: 0x04002260 RID: 8800
			[Token(Token = "0x4002260")]
			ModePrefer_UNLIMITED = 999
		}
	}
}
