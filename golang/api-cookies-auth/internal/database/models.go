// Code generated by sqlc. DO NOT EDIT.
// versions:
//   sqlc v1.26.0

package database

import (
	"github.com/jackc/pgx/v5/pgtype"
)

type User struct {
	ID        int32
	CreatedAt pgtype.Timestamptz
	UpdatedAt pgtype.Timestamptz
	Name      pgtype.Text
	Username  pgtype.Text
	Email     pgtype.Text
	Password  pgtype.Text
}