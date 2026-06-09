using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020014C9 RID: 5321
	[Token(Token = "0x20014C9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED8E4", Offset = "0x10ED8E4")]
	internal class UIHudRoundTransitionController : UIBaseController
	{
		// Token: 0x06005A9B RID: 23195 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		[Token(Token = "0x6005A9B")]
		[Address(RVA = "0x17FC478", Offset = "0x17FC478", VA = "0x7BBBFFC478")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x17FC4C8", Offset = "0x17FC4C8", VA = "0x7BBBFFC4C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x17FCB0C", Offset = "0x17FCB0C", VA = "0x7BBBFFCB0C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x17FCE58", Offset = "0x17FCE58", VA = "0x7BBBFFCE58", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0x17FD4E0", Offset = "0x17FD4E0", VA = "0x7BBBFFD4E0")]
		private void Update()
		{
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA0")]
		[Address(RVA = "0x17FD8C0", Offset = "0x17FD8C0", VA = "0x7BBBFFD8C0")]
		private void OnEarnedCoinChanged(params object[] data)
		{
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0x17FD23C", Offset = "0x17FD23C", VA = "0x7BBBFFD23C")]
		private void SetUIData()
		{
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0x17FD9AC", Offset = "0x17FD9AC", VA = "0x7BBBFFD9AC")]
		public void SetBonusDetailsView(D|\u007FgF\u007Ft res)
		{
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0x17FE100", Offset = "0x17FE100", VA = "0x7BBBFFE100")]
		private string GetDescriptionOfBonusType(kh{rwd\u0081 bonusType)
		{
			return null;
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0x17FE448", Offset = "0x17FE448", VA = "0x7BBBFFE448")]
		private void OnScoreChanged(params object[] data)
		{
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0x17FD54C", Offset = "0x17FD54C", VA = "0x7BBBFFD54C")]
		private void ShowScores()
		{
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0x17FD4D4", Offset = "0x17FD4D4", VA = "0x7BBBFFD4D4")]
		private void ResetScoreAnimation()
		{
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x17FE5A4", Offset = "0x17FE5A4", VA = "0x7BBBFFE5A4")]
		private void OnLocalPlayerJoin(params object[] data)
		{
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x17FE72C", Offset = "0x17FE72C", VA = "0x7BBBFFE72C")]
		private void OnNewPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0x17FE964", Offset = "0x17FE964", VA = "0x7BBBFFE964")]
		private void OnMatchPoint(params object[] data)
		{
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0x17FE9E8", Offset = "0x17FE9E8", VA = "0x7BBBFFE9E8")]
		private void OnAnimEventGridReposition(params object[] data)
		{
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0x17FEA2C", Offset = "0x17FEA2C", VA = "0x7BBBFFEA2C")]
		private void OnAnimEventShowMatchPoint(params object[] data)
		{
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0x17FEAF8", Offset = "0x17FEAF8", VA = "0x7BBBFFEAF8")]
		private void OnGameZoneIndexChanged(params object[] data)
		{
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAD")]
		[Address(RVA = "0x17FEDC0", Offset = "0x17FEDC0", VA = "0x7BBBFFEDC0")]
		public UIHudRoundTransitionController()
		{
		}

		// Token: 0x04007D7C RID: 32124
		[Token(Token = "0x4007D7C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudRoundTransitionView m_View;

		// Token: 0x04007D7D RID: 32125
		[Token(Token = "0x4007D7D")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007D7E RID: 32126
		[Token(Token = "0x4007D7E")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_BonusItemList;

		// Token: 0x04007D7F RID: 32127
		[Token(Token = "0x4007D7F")]
		[FieldOffset(Offset = "0x70")]
		private ZCvdc^^ mGame;

		// Token: 0x04007D80 RID: 32128
		[Token(Token = "0x4007D80")]
		[FieldOffset(Offset = "0x78")]
		private SafeZone m_CurrentSafeZone;

		// Token: 0x04007D81 RID: 32129
		[Token(Token = "0x4007D81")]
		[FieldOffset(Offset = "0x80")]
		private uint m_DelayCallId;

		// Token: 0x04007D82 RID: 32130
		[Token(Token = "0x4007D82")]
		[FieldOffset(Offset = "0x84")]
		private int m_ScoreCached;

		// Token: 0x04007D83 RID: 32131
		[Token(Token = "0x4007D83")]
		[FieldOffset(Offset = "0x88")]
		private float m_Time;

		// Token: 0x04007D84 RID: 32132
		[Token(Token = "0x4007D84")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_ScoreAnimTick;
	}
}
