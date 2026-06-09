using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EF8 RID: 3832
	[Token(Token = "0x2000EF8")]
	public class StaticObjectQualitySelector : MonoBehaviour
	{
		// Token: 0x060035CA RID: 13770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x2494A48", Offset = "0x2494A48", VA = "0x7BBCC94A48")]
		private void Start()
		{
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x2494D44", Offset = "0x2494D44", VA = "0x7BBCC94D44")]
		public StaticObjectQualitySelector()
		{
		}

		// Token: 0x040048D7 RID: 18647
		[Token(Token = "0x40048D7")]
		[FieldOffset(Offset = "0x18")]
		public List<StaticObjectQualitySelector.DynamicObject> objList;

		// Token: 0x02000EF9 RID: 3833
		[Token(Token = "0x2000EF9")]
		[Serializable]
		public struct DynamicObject
		{
			// Token: 0x040048D8 RID: 18648
			[Token(Token = "0x40048D8")]
			[FieldOffset(Offset = "0x0")]
			public string resID;

			// Token: 0x040048D9 RID: 18649
			[Token(Token = "0x40048D9")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 position;

			// Token: 0x040048DA RID: 18650
			[Token(Token = "0x40048DA")]
			[FieldOffset(Offset = "0x14")]
			public Quaternion rotation;

			// Token: 0x040048DB RID: 18651
			[Token(Token = "0x40048DB")]
			[FieldOffset(Offset = "0x24")]
			public Vector3 scale;
		}
	}
}
