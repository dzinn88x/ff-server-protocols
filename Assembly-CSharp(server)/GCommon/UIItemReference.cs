using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001029 RID: 4137
	[Token(Token = "0x2001029")]
	public class UIItemReference : MonoBehaviour
	{
		// Token: 0x06003EB3 RID: 16051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB3")]
		public T GetItem<T>(string itemName) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB4")]
		[Address(RVA = "0x202E0D0", Offset = "0x202E0D0", VA = "0x7BBC82E0D0")]
		private void CacheItem()
		{
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x6003EB5")]
		[Address(RVA = "0x202E350", Offset = "0x202E350", VA = "0x7BBC82E350")]
		private bool HasCached()
		{
			return default(bool);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB6")]
		[Address(RVA = "0x202E360", Offset = "0x202E360", VA = "0x7BBC82E360")]
		public UIItemReference()
		{
		}

		// Token: 0x04004EDC RID: 20188
		[Token(Token = "0x4004EDC")]
		[FieldOffset(Offset = "0x18")]
		public List<UIItemVariable> Items;

		// Token: 0x04004EDD RID: 20189
		[Token(Token = "0x4004EDD")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, UIItemVariable> m_ItemDict;
	}
}
