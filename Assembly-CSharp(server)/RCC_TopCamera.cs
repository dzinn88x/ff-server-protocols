using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000176 RID: 374
[Token(Token = "0x2000176")]
[Attribute(Name = "AddComponentMenu", RVA = "0x10E2458", Offset = "0x10E2458")]
public class RCC_TopCamera : MonoBehaviour
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000076")]
	public Transform _playerCar
	{
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x23D56C0", Offset = "0x23D56C0", VA = "0x7BBCBD56C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x23D56C8", Offset = "0x23D56C8", VA = "0x7BBCBD56C8")]
		set
		{
		}
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x23D5890", Offset = "0x23D5890", VA = "0x7BBCBD5890")]
	private void Awake()
	{
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x23D56D0", Offset = "0x23D56D0", VA = "0x7BBCBD56D0")]
	private void GetPlayerCar()
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x23D58E8", Offset = "0x23D58E8", VA = "0x7BBCBD58E8")]
	public void SetPlayerCar(GameObject player)
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x23D5928", Offset = "0x23D5928", VA = "0x7BBCBD5928")]
	private void Update()
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x23D5D2C", Offset = "0x23D5D2C", VA = "0x7BBCBD5D2C")]
	private Vector3 SmoothApproach(Vector3 pastPosition, Vector3 pastTargetPosition, Vector3 targetPosition, float delta)
	{
		return default(Vector3);
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x23D6028", Offset = "0x23D6028", VA = "0x7BBCBD6028")]
	public RCC_TopCamera()
	{
	}

	// Token: 0x04000767 RID: 1895
	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x18")]
	public Transform playerCar;

	// Token: 0x04000768 RID: 1896
	[Token(Token = "0x4000768")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody playerRigid;

	// Token: 0x04000769 RID: 1897
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x28")]
	private Camera cam;

	// Token: 0x0400076A RID: 1898
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject pivot;

	// Token: 0x0400076B RID: 1899
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x38")]
	public float distance;

	// Token: 0x0400076C RID: 1900
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x3C")]
	private float distanceOffset;

	// Token: 0x0400076D RID: 1901
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x40")]
	public float maximumDistanceOffset;

	// Token: 0x0400076E RID: 1902
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x44")]
	private float targetFieldOfView;

	// Token: 0x0400076F RID: 1903
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x48")]
	public float minimumOrtSize;

	// Token: 0x04000770 RID: 1904
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x4C")]
	public float maximumOrtSize;

	// Token: 0x04000771 RID: 1905
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 targetPosition;

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 pastFollowerPosition;

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 pastTargetPosition;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x74")]
	private float speed;
}
