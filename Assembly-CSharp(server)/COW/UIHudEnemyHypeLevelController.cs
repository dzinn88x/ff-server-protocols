using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018B2 RID: 6322
	[Token(Token = "0x20018B2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F49F4", Offset = "0x10F49F4")]
	public class UIHudEnemyHypeLevelController : UIHudNameBaseController
	{
		// Token: 0x06007DB2 RID: 32178 RVA: 0x000226F8 File Offset: 0x000208F8
		[Token(Token = "0x6007DB2")]
		[Address(RVA = "0x1C0363C", Offset = "0x1C0363C", VA = "0x7BBC40363C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DB3 RID: 32179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DB3")]
		[Address(RVA = "0x1C0368C", Offset = "0x1C0368C", VA = "0x7BBC40368C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DB4")]
		[Address(RVA = "0x1C036F0", Offset = "0x1C036F0", VA = "0x7BBC4036F0")]
		public void BindPlayer({QAb\u0082~u pID, int hypeLevel)
		{
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x00022710 File Offset: 0x00020910
		[Token(Token = "0x6007DB5")]
		[Address(RVA = "0x1C03874", Offset = "0x1C03874", VA = "0x7BBC403874", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06007DB6 RID: 32182 RVA: 0x00022728 File Offset: 0x00020928
		[Token(Token = "0x6007DB6")]
		[Address(RVA = "0x1C03AC8", Offset = "0x1C03AC8", VA = "0x7BBC403AC8", Slot = "38")]
		protected override Vector3 ExtraScreenGap()
		{
			return default(Vector3);
		}

		// Token: 0x06007DB7 RID: 32183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DB7")]
		[Address(RVA = "0x1C03B04", Offset = "0x1C03B04", VA = "0x7BBC403B04")]
		public UIHudEnemyHypeLevelController()
		{
		}

		// Token: 0x0400912F RID: 37167
		[Token(Token = "0x400912F")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudEnemyHypeLevelView m_View;

		// Token: 0x04009130 RID: 37168
		[Token(Token = "0x4009130")]
		[FieldOffset(Offset = "0xB0")]
		private {QAb\u0082~u m_TargetPlayerID;

		// Token: 0x04009131 RID: 37169
		[Token(Token = "0x4009131")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_DelayCallID;
	}
}
