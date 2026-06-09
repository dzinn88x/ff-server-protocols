using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C74 RID: 7284
	[Token(Token = "0x2001C74")]
	public class TipsParentChildrenDic
	{
		// Token: 0x06009EE5 RID: 40677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009EE5")]
		[Address(RVA = "0x1B47C88", Offset = "0x1B47C88", VA = "0x7BBC347C88")]
		public static List<ETipsType> GetChildType(ETipsType parent)
		{
			return null;
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x00029790 File Offset: 0x00027990
		[Token(Token = "0x6009EE6")]
		[Address(RVA = "0x1B4829C", Offset = "0x1B4829C", VA = "0x7BBC34829C")]
		public static ETipsType GetParentType(ETipsType child)
		{
			return ETipsType.None;
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EE7")]
		[Address(RVA = "0x1B48400", Offset = "0x1B48400", VA = "0x7BBC348400")]
		public TipsParentChildrenDic()
		{
		}

		// Token: 0x0400A5DA RID: 42458
		[Token(Token = "0x400A5DA")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<ETipsType, ETipsType> m_TipsChildParentDic;
	}
}
