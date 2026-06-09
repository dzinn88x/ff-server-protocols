using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000151 RID: 337
[Token(Token = "0x2000151")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E210C", Offset = "0x10E210C")]
public class AmplifyColorTriggerProxyBase : MonoBehaviour
{
	// Token: 0x06000668 RID: 1640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x1F88998", Offset = "0x1F88998", VA = "0x7BBC788998")]
	public AmplifyColorTriggerProxyBase()
	{
	}

	// Token: 0x040005B5 RID: 1461
	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x18")]
	public Transform Reference;

	// Token: 0x040005B6 RID: 1462
	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x20")]
	public PostEffectManagerBase OwnerEffect;
}
