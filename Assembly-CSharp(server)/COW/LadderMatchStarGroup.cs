using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020015DF RID: 5599
	[Token(Token = "0x20015DF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF49C", Offset = "0x10EF49C")]
	public class LadderMatchStarGroup : MonoBehaviour
	{
		// Token: 0x0600634B RID: 25419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634B")]
		[Address(RVA = "0x13FE248", Offset = "0x13FE248", VA = "0x7BBBBFE248")]
		public void InitMatchStarGroup(Transform starRoot, GameObject starRes, uint starCont)
		{
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634C")]
		[Address(RVA = "0x13FE380", Offset = "0x13FE380", VA = "0x7BBBBFE380")]
		public void InitMatchRankLabel(UILabel rankLabel, UILabel rankLabel_after, [Optional] Animation labelAnimation)
		{
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634D")]
		[Address(RVA = "0x13FE25C", Offset = "0x13FE25C", VA = "0x7BBBBFE25C")]
		private void CreateStar(uint starCount)
		{
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634E")]
		[Address(RVA = "0x13FE390", Offset = "0x13FE390", VA = "0x7BBBBFE390")]
		public void InitStarsState(uint starOnCnt)
		{
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600634F")]
		[Address(RVA = "0x13FE4A4", Offset = "0x13FE4A4", VA = "0x7BBBBFE4A4")]
		public void ChangeStars(bool isUp)
		{
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006350")]
		[Address(RVA = "0x13FE4C0", Offset = "0x13FE4C0", VA = "0x7BBBBFE4C0")]
		public void ChangeLabelStars(bool isUp)
		{
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006351")]
		[Address(RVA = "0x13FE5B4", Offset = "0x13FE5B4", VA = "0x7BBBBFE5B4")]
		public LadderMatchStar GetNeedGainStar()
		{
			return null;
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006352")]
		[Address(RVA = "0x13FE66C", Offset = "0x13FE66C", VA = "0x7BBBBFE66C")]
		public LadderMatchStar GetNeedLoseStar()
		{
			return null;
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006353")]
		[Address(RVA = "0x13FE728", Offset = "0x13FE728", VA = "0x7BBBBFE728")]
		public Animation GetLabelAnimation()
		{
			return null;
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006354")]
		[Address(RVA = "0x13FE730", Offset = "0x13FE730", VA = "0x7BBBBFE730")]
		public LadderMatchStarGroup()
		{
		}

		// Token: 0x040081FD RID: 33277
		[Token(Token = "0x40081FD")]
		public const string ANIMATION_LABEL_CHANGE = "UILadderCSMatchLabelStarChange";

		// Token: 0x040081FE RID: 33278
		[Token(Token = "0x40081FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<LadderMatchStar> starsList;

		// Token: 0x040081FF RID: 33279
		[Token(Token = "0x40081FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint currentOnCnt;

		// Token: 0x04008200 RID: 33280
		[Token(Token = "0x4008200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private uint starCnt;

		// Token: 0x04008201 RID: 33281
		[Token(Token = "0x4008201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_starRoot;

		// Token: 0x04008202 RID: 33282
		[Token(Token = "0x4008202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject m_starRes;

		// Token: 0x04008203 RID: 33283
		[Token(Token = "0x4008203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UILabel m_starLabel;

		// Token: 0x04008204 RID: 33284
		[Token(Token = "0x4008204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UILabel m_starLabelAfter;

		// Token: 0x04008205 RID: 33285
		[Token(Token = "0x4008205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animation m_labelAnim;

		// Token: 0x04008206 RID: 33286
		[Token(Token = "0x4008206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isStarRank;
	}
}
