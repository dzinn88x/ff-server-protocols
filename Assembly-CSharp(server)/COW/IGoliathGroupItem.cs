using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001380 RID: 4992
	[Token(Token = "0x2001380")]
	public interface IGoliathGroupItem
	{
		// Token: 0x06005046 RID: 20550
		[Token(Token = "0x6005046")]
		GoliathAFKGroupInfo GetItemInfo();

		// Token: 0x06005047 RID: 20551
		[Token(Token = "0x6005047")]
		int GetItemIndex();

		// Token: 0x06005048 RID: 20552
		[Token(Token = "0x6005048")]
		ulong GetGroupId();

		// Token: 0x06005049 RID: 20553
		[Token(Token = "0x6005049")]
		void SetGroupSelectView(bool isSelect);
	}
}
