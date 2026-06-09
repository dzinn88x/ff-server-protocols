using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F03 RID: 3843
	[Token(Token = "0x2000F03")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LocComponent : MonoBehaviour
	{
		// Token: 0x0600361C RID: 13852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x2120FA4", Offset = "0x2120FA4", VA = "0x7BBC920FA4")]
		private void Awake()
		{
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x2121030", Offset = "0x2121030", VA = "0x7BBC921030")]
		private void FindTarget()
		{
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x212105C", Offset = "0x212105C", VA = "0x7BBC92105C")]
		private void Process()
		{
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x2121910", Offset = "0x2121910", VA = "0x7BBC921910")]
		public UILabel GetTargetUILabel()
		{
			return null;
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x2121088", Offset = "0x2121088", VA = "0x7BBC921088")]
		private void FindTargetUILabel()
		{
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x2121314", Offset = "0x2121314", VA = "0x7BBC921314")]
		private void ProcessUILabel()
		{
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x2121234", Offset = "0x2121234", VA = "0x7BBC921234")]
		private void FindTargetUIPopupList()
		{
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x21215E8", Offset = "0x21215E8", VA = "0x7BBC9215E8")]
		private void ProcessUIPopupList()
		{
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x21212A4", Offset = "0x21212A4", VA = "0x7BBC9212A4")]
		private void FindTargetUISprite()
		{
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x2121768", Offset = "0x2121768", VA = "0x7BBC921768")]
		private void ProcessUISprite()
		{
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x2121E44", Offset = "0x2121E44", VA = "0x7BBC921E44")]
		public LocComponent()
		{
		}

		// Token: 0x04004950 RID: 18768
		[Token(Token = "0x4004950")]
		[FieldOffset(Offset = "0x18")]
		public string StringID;

		// Token: 0x04004951 RID: 18769
		[Token(Token = "0x4004951")]
		[FieldOffset(Offset = "0x20")]
		public string FontSetName;

		// Token: 0x04004952 RID: 18770
		[Token(Token = "0x4004952")]
		[FieldOffset(Offset = "0x28")]
		public string LocType;

		// Token: 0x04004953 RID: 18771
		[Token(Token = "0x4004953")]
		[FieldOffset(Offset = "0x30")]
		public string SpriteName;

		// Token: 0x04004954 RID: 18772
		[Token(Token = "0x4004954")]
		[FieldOffset(Offset = "0x38")]
		public string AtlasName;

		// Token: 0x04004955 RID: 18773
		[Token(Token = "0x4004955")]
		[FieldOffset(Offset = "0x40")]
		public bool NoArabic;

		// Token: 0x04004956 RID: 18774
		[Token(Token = "0x4004956")]
		[FieldOffset(Offset = "0x41")]
		public bool FixArabicInOtherLang;

		// Token: 0x04004957 RID: 18775
		[Token(Token = "0x4004957")]
		[FieldOffset(Offset = "0x42")]
		public bool FixArabicNoRegion;

		// Token: 0x04004958 RID: 18776
		[Token(Token = "0x4004958")]
		[FieldOffset(Offset = "0x43")]
		public bool UseArabicAlignment;

		// Token: 0x04004959 RID: 18777
		[Token(Token = "0x4004959")]
		[FieldOffset(Offset = "0x44")]
		public LocComponent.Alignment ArabicAlignment;

		// Token: 0x0400495A RID: 18778
		[Token(Token = "0x400495A")]
		[FieldOffset(Offset = "0x48")]
		private UILabel m_UILabel;

		// Token: 0x0400495B RID: 18779
		[Token(Token = "0x400495B")]
		[FieldOffset(Offset = "0x50")]
		private UIPopupList m_UIPopupList;

		// Token: 0x0400495C RID: 18780
		[Token(Token = "0x400495C")]
		[FieldOffset(Offset = "0x58")]
		private UISprite m_UISprite;

		// Token: 0x02000F04 RID: 3844
		[Token(Token = "0x2000F04")]
		public enum Alignment
		{
			// Token: 0x0400495E RID: 18782
			[Token(Token = "0x400495E")]
			Automatic,
			// Token: 0x0400495F RID: 18783
			[Token(Token = "0x400495F")]
			Left,
			// Token: 0x04004960 RID: 18784
			[Token(Token = "0x4004960")]
			Center,
			// Token: 0x04004961 RID: 18785
			[Token(Token = "0x4004961")]
			Right,
			// Token: 0x04004962 RID: 18786
			[Token(Token = "0x4004962")]
			Justified
		}
	}
}
