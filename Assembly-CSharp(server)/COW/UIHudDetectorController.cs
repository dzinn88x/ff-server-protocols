using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018A6 RID: 6310
	[Token(Token = "0x20018A6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F485C", Offset = "0x10F485C")]
	public class UIHudDetectorController : UIBaseController
	{
		// Token: 0x06007D4B RID: 32075 RVA: 0x000225C0 File Offset: 0x000207C0
		[Token(Token = "0x6007D4B")]
		[Address(RVA = "0x1BFB318", Offset = "0x1BFB318", VA = "0x7BBC3FB318")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4C")]
		[Address(RVA = "0x1BFB368", Offset = "0x1BFB368", VA = "0x7BBC3FB368", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4D")]
		[Address(RVA = "0x1BFB59C", Offset = "0x1BFB59C", VA = "0x7BBC3FB59C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4E")]
		[Address(RVA = "0x1BFB7B8", Offset = "0x1BFB7B8", VA = "0x7BBC3FB7B8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D4F")]
		[Address(RVA = "0x1BFBCA8", Offset = "0x1BFBCA8", VA = "0x7BBC3FBCA8")]
		private void OnEnableBigMap(params object[] param)
		{
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D50")]
		[Address(RVA = "0x1BFBD38", Offset = "0x1BFBD38", VA = "0x7BBC3FBD38")]
		private void OnDisableBigMap(params object[] param)
		{
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D51")]
		[Address(RVA = "0x1BFBCB4", Offset = "0x1BFBCB4", VA = "0x7BBC3FBCB4")]
		private void SetX(float x)
		{
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D52")]
		[Address(RVA = "0x1BFB854", Offset = "0x1BFB854", VA = "0x7BBC3FB854")]
		private void UpdateCount(params object[] param)
		{
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D53")]
		[Address(RVA = "0x1BFBBF4", Offset = "0x1BFBBF4", VA = "0x7BBC3FBBF4")]
		private void CheckPlayerStatus(params object[] param)
		{
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D54")]
		[Address(RVA = "0x1BFBD40", Offset = "0x1BFBD40", VA = "0x7BBC3FBD40")]
		private static Player GetLocalPlayer()
		{
			return null;
		}

		// Token: 0x06007D55 RID: 32085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D55")]
		[Address(RVA = "0x1BFBE18", Offset = "0x1BFBE18", VA = "0x7BBC3FBE18")]
		public UIHudDetectorController()
		{
		}

		// Token: 0x040090EE RID: 37102
		[Token(Token = "0x40090EE")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDetectorView m_View;

		// Token: 0x040090EF RID: 37103
		[Token(Token = "0x40090EF")]
		private const float BIG_MAP_X = -150f;

		// Token: 0x040090F0 RID: 37104
		[Token(Token = "0x40090F0")]
		[FieldOffset(Offset = "0x60")]
		private float m_InitialX;
	}
}
