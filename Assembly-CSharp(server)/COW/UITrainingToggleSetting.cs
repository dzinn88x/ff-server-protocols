using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200168A RID: 5770
	[Token(Token = "0x200168A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F055C", Offset = "0x10F055C")]
	public class UITrainingToggleSetting : MonoBehaviour
	{
		// Token: 0x060068DC RID: 26844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DC")]
		[Address(RVA = "0x1F5E780", Offset = "0x1F5E780", VA = "0x7BBC75E780")]
		private void Start()
		{
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DD")]
		[Address(RVA = "0x1F5E9DC", Offset = "0x1F5E9DC", VA = "0x7BBC75E9DC")]
		private void OnValueChange()
		{
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DE")]
		[Address(RVA = "0x1F5F310", Offset = "0x1F5F310", VA = "0x7BBC75F310")]
		public UITrainingToggleSetting()
		{
		}

		// Token: 0x04008581 RID: 34177
		[Token(Token = "0x4008581")]
		[FieldOffset(Offset = "0x18")]
		public ETrainingToggleType ToggleType;

		// Token: 0x04008582 RID: 34178
		[Token(Token = "0x4008582")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle NoneToggle;

		// Token: 0x04008583 RID: 34179
		[Token(Token = "0x4008583")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle Lv1Toggle;

		// Token: 0x04008584 RID: 34180
		[Token(Token = "0x4008584")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle Lv2Toggle;

		// Token: 0x04008585 RID: 34181
		[Token(Token = "0x4008585")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle Lv3Toggle;

		// Token: 0x04008586 RID: 34182
		[Token(Token = "0x4008586")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle Lv4Toggle;
	}
}
