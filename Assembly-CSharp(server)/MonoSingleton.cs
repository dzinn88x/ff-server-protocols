using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000200 RID: 512
[Token(Token = "0x2000200")]
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<!0>
{
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B5")]
	public static T instance
	{
		[Token(Token = "0x6000A30")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x170000B6")]
	public static bool hasInstance
	{
		[Token(Token = "0x6000A31")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A32")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A33")]
	public virtual void Init()
	{
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A34")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A35")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A36")]
	protected MonoSingleton()
	{
	}

	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x0")]
	private static T m_Instance;
}
