using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018BA RID: 6330
	[Token(Token = "0x20018BA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4B1C", Offset = "0x10F4B1C")]
	internal class UIHudEscortTipsController : UIBaseController
	{
		// Token: 0x06007DEF RID: 32239 RVA: 0x00022800 File Offset: 0x00020A00
		[Token(Token = "0x6007DEF")]
		[Address(RVA = "0x1C077B4", Offset = "0x1C077B4", VA = "0x7BBC4077B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF0")]
		[Address(RVA = "0x1C07804", Offset = "0x1C07804", VA = "0x7BBC407804", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF1")]
		[Address(RVA = "0x1C07968", Offset = "0x1C07968", VA = "0x7BBC407968", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF2")]
		[Address(RVA = "0x1C07AC4", Offset = "0x1C07AC4", VA = "0x7BBC407AC4")]
		private void ShowTips()
		{
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF3")]
		[Address(RVA = "0x1C07BF4", Offset = "0x1C07BF4", VA = "0x7BBC407BF4")]
		private void HideTips()
		{
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF4")]
		[Address(RVA = "0x1C07C2C", Offset = "0x1C07C2C", VA = "0x7BBC407C2C")]
		public void SetData(string content, {QAb\u0082~u playerid)
		{
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF5")]
		[Address(RVA = "0x1C07E84", Offset = "0x1C07E84", VA = "0x7BBC407E84")]
		private void SetTeamColor({QAb\u0082~u playerid)
		{
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF6")]
		[Address(RVA = "0x1C07990", Offset = "0x1C07990", VA = "0x7BBC407990")]
		public void ClearData()
		{
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DF7")]
		[Address(RVA = "0x1C07F8C", Offset = "0x1C07F8C", VA = "0x7BBC407F8C")]
		public UIHudEscortTipsController()
		{
		}

		// Token: 0x0400914E RID: 37198
		[Token(Token = "0x400914E")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortTipsView m_View;

		// Token: 0x0400914F RID: 37199
		[Token(Token = "0x400914F")]
		[FieldOffset(Offset = "0x60")]
		private TweenAlpha m_FadeInAlpha;

		// Token: 0x04009150 RID: 37200
		[Token(Token = "0x4009150")]
		[FieldOffset(Offset = "0x68")]
		private TweenAlpha m_FadeOutAlpha;

		// Token: 0x04009151 RID: 37201
		[Token(Token = "0x4009151")]
		[FieldOffset(Offset = "0x70")]
		private uint m_ShowDelayCallID;

		// Token: 0x04009152 RID: 37202
		[Token(Token = "0x4009152")]
		[FieldOffset(Offset = "0x74")]
		private uint m_HideDelayCallID;

		// Token: 0x04009153 RID: 37203
		[Token(Token = "0x4009153")]
		[FieldOffset(Offset = "0x78")]
		private float m_ShowTime;

		// Token: 0x04009154 RID: 37204
		[Token(Token = "0x4009154")]
		[FieldOffset(Offset = "0x7C")]
		private Color Team1Color;

		// Token: 0x04009155 RID: 37205
		[Token(Token = "0x4009155")]
		[FieldOffset(Offset = "0x8C")]
		private Color Team2Color;
	}
}
