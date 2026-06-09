using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018AF RID: 6319
	[Token(Token = "0x20018AF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F494C", Offset = "0x10F494C")]
	internal class UIHudEatMushroomController : UIHudButtonBaseController
	{
		// Token: 0x06007D98 RID: 32152 RVA: 0x000226B0 File Offset: 0x000208B0
		[Token(Token = "0x6007D98")]
		[Address(RVA = "0x1C00738", Offset = "0x1C00738", VA = "0x7BBC400738")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D99")]
		[Address(RVA = "0x1C00788", Offset = "0x1C00788", VA = "0x7BBC400788", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D9A")]
		[Address(RVA = "0x1C007D0", Offset = "0x1C007D0", VA = "0x7BBC4007D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D9B RID: 32155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D9B")]
		[Address(RVA = "0x1C00988", Offset = "0x1C00988", VA = "0x7BBC400988", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D9C")]
		[Address(RVA = "0x1C00B08", Offset = "0x1C00B08", VA = "0x7BBC400B08", Slot = "34")]
		protected virtual void OnActionEnter(params object[] param)
		{
		}

		// Token: 0x06007D9D RID: 32157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D9D")]
		[Address(RVA = "0x1C01450", Offset = "0x1C01450", VA = "0x7BBC401450")]
		protected void OnActionEnd(params object[] param)
		{
		}

		// Token: 0x06007D9E RID: 32158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D9E")]
		[Address(RVA = "0x1C0151C", Offset = "0x1C0151C", VA = "0x7BBC40151C")]
		protected void OnShow(params object[] param)
		{
		}

		// Token: 0x06007D9F RID: 32159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D9F")]
		[Address(RVA = "0x1C01514", Offset = "0x1C01514", VA = "0x7BBC401514")]
		private void ClearActionCD()
		{
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA0")]
		[Address(RVA = "0x1C016AC", Offset = "0x1C016AC", VA = "0x7BBC4016AC")]
		private void Update()
		{
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DA1")]
		[Address(RVA = "0x1C017E4", Offset = "0x1C017E4", VA = "0x7BBC4017E4")]
		public UIHudEatMushroomController()
		{
		}

		// Token: 0x04009127 RID: 37159
		[Token(Token = "0x4009127")]
		[FieldOffset(Offset = "0x60")]
		private UIHudEatMushroomView m_View;

		// Token: 0x04009128 RID: 37160
		[Token(Token = "0x4009128")]
		[FieldOffset(Offset = "0x68")]
		private int m_CurrentActionType;

		// Token: 0x04009129 RID: 37161
		[Token(Token = "0x4009129")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_ShowState;

		// Token: 0x0400912A RID: 37162
		[Token(Token = "0x400912A")]
		[FieldOffset(Offset = "0x70")]
		private float m_ActionCD;

		// Token: 0x0400912B RID: 37163
		[Token(Token = "0x400912B")]
		[FieldOffset(Offset = "0x74")]
		private float m_ActionCDEndTime;
	}
}
