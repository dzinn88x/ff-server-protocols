using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200141E RID: 5150
	[Token(Token = "0x200141E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC730", Offset = "0x10EC730")]
	public class UIHudArmsItemController : UIBaseController
	{
		// Token: 0x060054F0 RID: 21744 RVA: 0x000195A8 File Offset: 0x000177A8
		[Token(Token = "0x60054F0")]
		[Address(RVA = "0x18845C8", Offset = "0x18845C8", VA = "0x7BBC0845C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0x1884618", Offset = "0x1884618", VA = "0x7BBC084618", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0x188467C", Offset = "0x188467C", VA = "0x7BBC08467C")]
		public void SetData(YmQ\u0082E\u007FN armsInfo)
		{
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x1884980", Offset = "0x1884980", VA = "0x7BBC084980", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x1884A2C", Offset = "0x1884A2C", VA = "0x7BBC084A2C")]
		public UIHudArmsItemController()
		{
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x1884A90", Offset = "0x1884A90", VA = "0x7BBC084A90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E81C", Offset = "0x113E81C")]
		private void <SetData>b__5_0()
		{
		}

		// Token: 0x04007A21 RID: 31265
		[Token(Token = "0x4007A21")]
		[FieldOffset(Offset = "0x58")]
		private UIHudArmsItemView m_View;

		// Token: 0x04007A22 RID: 31266
		[Token(Token = "0x4007A22")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string m_SpriteNamePrefix;

		// Token: 0x04007A23 RID: 31267
		[Token(Token = "0x4007A23")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCall;
	}
}
