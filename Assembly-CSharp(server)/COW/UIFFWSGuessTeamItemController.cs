using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200135C RID: 4956
	[Token(Token = "0x200135C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB2B8", Offset = "0x10EB2B8")]
	internal class UIFFWSGuessTeamItemController : UIBaseController
	{
		// Token: 0x06004EEA RID: 20202 RVA: 0x00018120 File Offset: 0x00016320
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x227A578", Offset = "0x227A578", VA = "0x7BBCA7A578")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x227A5C8", Offset = "0x227A5C8", VA = "0x7BBCA7A5C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x227772C", Offset = "0x227772C", VA = "0x7BBCA7772C")]
		public void SetData(uint teamId, uint roundIndex, bool isAIChoice, bool isPlayerChoice, bool isPlayerTempChoice)
		{
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x2279E80", Offset = "0x2279E80", VA = "0x7BBCA79E80")]
		public void PlayTweenAlphaPoint()
		{
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0x227AF10", Offset = "0x227AF10", VA = "0x7BBCA7AF10")]
		public void PlayTweenBreathe()
		{
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0x2277E30", Offset = "0x2277E30", VA = "0x7BBCA77E30")]
		public void PlayHaventChooseTeamVFX()
		{
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0x2276144", Offset = "0x2276144", VA = "0x7BBCA76144")]
		public void PlayPlayerChooseTeamVFX()
		{
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF1")]
		[Address(RVA = "0x2277E68", Offset = "0x2277E68", VA = "0x7BBCA77E68")]
		public void PlayAIChooseTeamVFX()
		{
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF2")]
		[Address(RVA = "0x227A848", Offset = "0x227A848", VA = "0x7BBCA7A848")]
		private void RefreshView(bool isAIChoice, bool isPlayerChoice, bool isPlayerTempChoice)
		{
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF3")]
		[Address(RVA = "0x227AF80", Offset = "0x227AF80", VA = "0x7BBCA7AF80")]
		private void PlayVFX(Transform tr)
		{
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF4")]
		[Address(RVA = "0x227B130", Offset = "0x227B130", VA = "0x7BBCA7B130")]
		private void OnBtnClickTeamChoose()
		{
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x227B2DC", Offset = "0x227B2DC", VA = "0x7BBCA7B2DC")]
		private void OnBtnClickTeamDetail()
		{
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF6")]
		[Address(RVA = "0x227B418", Offset = "0x227B418", VA = "0x7BBCA7B418")]
		public UIFFWSGuessTeamItemController()
		{
		}

		// Token: 0x040075FC RID: 30204
		[Token(Token = "0x40075FC")]
		[FieldOffset(Offset = "0x58")]
		private UIFFWSGuessTeamItemView m_View;

		// Token: 0x040075FD RID: 30205
		[Token(Token = "0x40075FD")]
		[FieldOffset(Offset = "0x60")]
		public uint TeamId;

		// Token: 0x040075FE RID: 30206
		[Token(Token = "0x40075FE")]
		[FieldOffset(Offset = "0x64")]
		private uint m_RoundIndex;

		// Token: 0x040075FF RID: 30207
		[Token(Token = "0x40075FF")]
		[FieldOffset(Offset = "0x68")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x04007600 RID: 30208
		[Token(Token = "0x4007600")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsAIChoice;

		// Token: 0x04007601 RID: 30209
		[Token(Token = "0x4007601")]
		[FieldOffset(Offset = "0x71")]
		private bool m_IsPlayerChoice;

		// Token: 0x04007602 RID: 30210
		[Token(Token = "0x4007602")]
		[FieldOffset(Offset = "0x72")]
		private bool m_IsPlayerTempChoice;

		// Token: 0x04007603 RID: 30211
		[Token(Token = "0x4007603")]
		[FieldOffset(Offset = "0x78")]
		private string m_CurrentIconUrl;
	}
}
