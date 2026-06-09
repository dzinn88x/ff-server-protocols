using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C1B RID: 7195
	[Token(Token = "0x2001C1B")]
	internal class FrontEndClickFilter : MonoBehaviour
	{
		// Token: 0x06009C9B RID: 40091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C9B")]
		[Address(RVA = "0x1B9CF04", Offset = "0x1B9CF04", VA = "0x7BBC39CF04")]
		private void Start()
		{
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C9C")]
		[Address(RVA = "0x1B9D46C", Offset = "0x1B9D46C", VA = "0x7BBC39D46C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C9D")]
		[Address(RVA = "0x1B9D320", Offset = "0x1B9D320", VA = "0x7BBC39D320")]
		private void RegisterUICameraCustomInput(UICamera.OnCustomInput handler)
		{
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C9E")]
		[Address(RVA = "0x1B9D5B4", Offset = "0x1B9D5B4", VA = "0x7BBC39D5B4")]
		private void UnRegisterUICameraCustomInput(UICamera.OnCustomInput handler)
		{
		}

		// Token: 0x06009C9F RID: 40095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C9F")]
		[Address(RVA = "0x1B9D700", Offset = "0x1B9D700", VA = "0x7BBC39D700")]
		private void OnAddClickFilter(params object[] data)
		{
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CA0")]
		[Address(RVA = "0x1B9D9CC", Offset = "0x1B9D9CC", VA = "0x7BBC39D9CC")]
		private void OnRemovelickFilter(params object[] data)
		{
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CA1")]
		[Address(RVA = "0x1B9DB6C", Offset = "0x1B9DB6C", VA = "0x7BBC39DB6C")]
		private void OnUICameraCustomInput()
		{
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CA2")]
		[Address(RVA = "0x1B9D148", Offset = "0x1B9D148", VA = "0x7BBC39D148")]
		private void AddRect(ClickFilterData fd)
		{
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CA3")]
		[Address(RVA = "0x1B9E0E8", Offset = "0x1B9E0E8", VA = "0x7BBC39E0E8")]
		public FrontEndClickFilter()
		{
		}

		// Token: 0x0400A298 RID: 41624
		[Token(Token = "0x400A298")]
		[FieldOffset(Offset = "0x18")]
		public ClickFilterData[] FilterArr;

		// Token: 0x0400A299 RID: 41625
		[Token(Token = "0x400A299")]
		[FieldOffset(Offset = "0x20")]
		private List<ClickFilterData> m_Filters;

		// Token: 0x0400A29A RID: 41626
		[Token(Token = "0x400A29A")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Rect> m_DictRect;

		// Token: 0x02001C1C RID: 7196
		[Token(Token = "0x2001C1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB69C", Offset = "0x10FB69C")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06009CA4 RID: 40100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CA4")]
			[Address(RVA = "0x1865A9C", Offset = "0x1865A9C", VA = "0x7BBC065A9C")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06009CA5 RID: 40101 RVA: 0x000291A8 File Offset: 0x000273A8
			[Token(Token = "0x6009CA5")]
			[Address(RVA = "0x1865AA4", Offset = "0x1865AA4", VA = "0x7BBC065AA4")]
			internal bool <OnAddClickFilter>b__0(ClickFilterData a)
			{
				return default(bool);
			}

			// Token: 0x0400A29B RID: 41627
			[Token(Token = "0x400A29B")]
			[FieldOffset(Offset = "0x10")]
			public object[] data;
		}

		// Token: 0x02001C1D RID: 7197
		[Token(Token = "0x2001C1D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB6AC", Offset = "0x10FB6AC")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06009CA6 RID: 40102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009CA6")]
			[Address(RVA = "0x1865C30", Offset = "0x1865C30", VA = "0x7BBC065C30")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06009CA7 RID: 40103 RVA: 0x000291C0 File Offset: 0x000273C0
			[Token(Token = "0x6009CA7")]
			[Address(RVA = "0x1865C38", Offset = "0x1865C38", VA = "0x7BBC065C38")]
			internal bool <OnRemovelickFilter>b__0(ClickFilterData a)
			{
				return default(bool);
			}

			// Token: 0x0400A29C RID: 41628
			[Token(Token = "0x400A29C")]
			[FieldOffset(Offset = "0x10")]
			public string key;
		}
	}
}
