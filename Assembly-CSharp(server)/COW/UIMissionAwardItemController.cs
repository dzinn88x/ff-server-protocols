using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A78 RID: 6776
	[Token(Token = "0x2001A78")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F83D4", Offset = "0x10F83D4")]
	public class UIMissionAwardItemController : UIBaseController
	{
		// Token: 0x06008EBC RID: 36540 RVA: 0x000260E8 File Offset: 0x000242E8
		[Token(Token = "0x6008EBC")]
		[Address(RVA = "0x1484C2C", Offset = "0x1484C2C", VA = "0x7BBBC84C2C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EBD")]
		[Address(RVA = "0x1484C7C", Offset = "0x1484C7C", VA = "0x7BBBC84C7C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EBE")]
		[Address(RVA = "0x1484CE0", Offset = "0x1484CE0", VA = "0x7BBBC84CE0")]
		public void SetData(BaseItemInfo item)
		{
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EBF")]
		[Address(RVA = "0x1484D2C", Offset = "0x1484D2C", VA = "0x7BBBC84D2C")]
		public UIMissionAwardItemController()
		{
		}

		// Token: 0x04009A55 RID: 39509
		[Token(Token = "0x4009A55")]
		[FieldOffset(Offset = "0x58")]
		private UIMissionAwardItemView m_View;
	}
}
